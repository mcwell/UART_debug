using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.IO;

namespace UART_COM
{
    public partial class Form1 : Form
    {
        SerialPort uart1 = new SerialPort();
        List<string> port_descrpt,port_names;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strCom = SerialPort.GetPortNames();
            if (strCom.Length<1)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            //通过WMI获取COM端口
            string[] port_allnames = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            int portSize = port_allnames.Count();
            port_descrpt=new List<string>();
            port_names = new List<string>();
            for(int i=0;i<portSize;i++)
            {
                string name = port_allnames[i];
                int istrs= name.LastIndexOf('(');
                int istre = name.LastIndexOf(')');
                port_names.Add(name.Substring(istrs + 1, istre - istrs-1));
                port_descrpt.Add(name.Substring(0, istrs));
            }

            cbBox_PORT.Items.AddRange(port_names.ToArray());
            cbBox_PORT.SelectedIndex = 0;

            string[] strbaud =new string[] { "9600", "19200","115200","460800","921600" };
            cbBox_BAUD.Items.AddRange(strbaud);
            cbBox_BAUD.SelectedIndex = 0;

            cbBox_CheckBit.Items.AddRange(new string[] { "无","奇校验","偶校验" });
            cbBox_CheckBit.SelectedIndex = 0;
            cbBox_DataBit.Items.Add("8");
            cbBox_DataBit.SelectedIndex = 0;
            cbBox_StopBit.Items.AddRange(new string[]{ "1" ,"1.5","2"});
            cbBox_StopBit.SelectedIndex = 0;


            uart1.BaudRate = 9600;
            Control.CheckForIllegalCrossThreadCalls = false;
            uart1.DataReceived += uart1_DataReceived;

            uart1.DtrEnable = false;//获取或设置一个值，该值在串行通信过程中启用数据终端就绪 (DTR) 信号。
            uart1.RtsEnable = false;//获取或设置一个值，该值指示在串行通信中是否启用请求发送 (RTS) 信号
            //设置数据读取超时为1秒
            uart1.ReadTimeout = 1000;

            uart1.Close();

        }
        DateTime startRevTime, endRevTime;
        int revByteNumAll = 0;
        FileStream mfileStream;
        StreamWriter mstreamWriter;
        private void btn_openCom_Click(object sender, EventArgs e)
        {
            //serialPort1.IsOpen
            if (!uart1.IsOpen)
            {
                try
                {
                    if (isSaveData)
                    {
                        string filename = String.Format("uartRev{0:H_mm_ss}.tmp", DateTime.Now);
                        mfileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                        mstreamWriter = new StreamWriter(mfileStream);
                    }
                    //设置串口号
                    string serialName = cbBox_PORT.SelectedItem.ToString();
                    uart1.PortName = serialName;

                    //设置各“串口设置”
                    string strBaudRate = cbBox_BAUD.Text;
                    string strDateBits = cbBox_DataBit.Text;
                    string strStopBits = cbBox_StopBit.Text;
                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    uart1.BaudRate = iBaudRate;       //波特率
                    uart1.DataBits = iDateBits;       //数据位
                    switch (cbBox_StopBit.Text)            //停止位
                    {
                        case "1":
                            uart1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            uart1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            uart1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (cbBox_CheckBit.Text)             //校验位
                    {
                        case "无":
                            uart1.Parity = Parity.None;
                            break;
                        case "奇校验":
                            uart1.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            uart1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }

                    if (uart1.IsOpen == true)//如果打开状态，则先关闭一下
                    {
                        uart1.Close();
                    }

                    //设置必要控件不可用
                    cbBox_PORT.Enabled = false;
                    cbBox_BAUD.Enabled = false;
                    cbBox_DataBit.Enabled = false;
                    cbBox_StopBit.Enabled = false;
                    cbBox_CheckBit.Enabled = false;
                    revByteNumAll = 0;
                    startRevTime = DateTime.Now;
                    AddContent("Start Receive\n", 0);
                    uart1.Open();     //打开串口
                    btn_openCom.Text = "关闭串口";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
            else
            {
                //恢复控件功能
                //设置必要控件不可用
                cbBox_PORT.Enabled = true;
                cbBox_BAUD.Enabled = true;
                cbBox_DataBit.Enabled = true;
                cbBox_StopBit.Enabled = true;
                cbBox_CheckBit.Enabled = true;
                endRevTime = DateTime.Now;
                uart1.Close();                    //关闭串口
                btn_openCom.Text = "打开串口";
                TimeSpan dt = endRevTime - startRevTime;
                double transDataRate = (double)revByteNumAll / dt.TotalMilliseconds * 1000;
                AddContent(String.Format("Data Rate:{0}Byte/s,Time is {1}s",transDataRate,dt.TotalSeconds),revByteNumAll);
                if (isSaveData)
                {
                    mstreamWriter.Flush();
                    mfileStream.Close();
                }
            }
        }
        private void uart1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            if (uart1.IsOpen)     //判断是否打开串口
            {
                if (uart1.BytesToRead <=0) return;
                //输出当前时间
                try
                {
                    int receiveLen = uart1.BytesToRead;
                    revByteNumAll += receiveLen;
                    Byte[] receivedData = new Byte[receiveLen];        //创建接收字节数组
                    uart1.Read(receivedData, 0, receiveLen);         //读取数据
                   
                    string strget="";
                    if (isHexDisplay)
                        strget = BitConverter.ToString(receivedData).Replace("-",string.Empty);
                    else
                        strget = new UTF8Encoding().GetString(receivedData);
                    String strTime = "";
                    if (isTimeDisplay)
                    {
                        DateTime dt = DateTime.Now;
                        strTime = String.Format("{0:H:mm:ss:fff}", dt);
                    }

                   String strbuf= String.Concat(strget," ",strTime);
                   if(isSaveData) mstreamWriter.WriteLine(strbuf);

                    if (isPauseDisplay) return;
                    if (isRevByteDis)
                        AddContent(String.Format("{0},{1}", receiveLen, strbuf),revByteNumAll);
                    else
                        AddContent(strbuf, revByteNumAll);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示!!!!!");
                    txt_SendStr.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        //将接受到的内容显示出来
        private void AddContent(string content,int bufLen)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                txt_Received.AppendText(content);
                if(isNewLine)txt_Received.AppendText("\r\n");
                lbl_RevCount.Text = (bufLen).ToString();
            }));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] sendData = null;
            if (!uart1.IsOpen) //如果没打开
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }
            String strSend = txt_SendStr.Text;
            try
            {
                sendData = Encoding.UTF8.GetBytes(txt_SendStr.Text.Trim());
                //uart1.WriteLine(txtSendStr.Text);    //写入数据
                uart1.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error");
            }

        }

        private void cbBox_PORT_MouseHover(object sender, EventArgs e)
        {
            string ss = cbBox_PORT.Text;
            if (ss.Length <1) return;
            int i1= port_names.IndexOf(ss);
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.ReshowDelay = 500;
            toolTip.SetToolTip(cbBox_PORT, port_descrpt[i1]);
            toolTip.InitialDelay = 200;
        }
       

        private void btn_clearRev_Click(object sender, EventArgs e)
        {
            txt_Received.Clear();
            revByteNumAll = 0;
            startRevTime = DateTime.Now;
        }

        private void btn_refresh_Uart_Click(object sender, EventArgs e)
        {
            string[] strCom = SerialPort.GetPortNames();
            if (strCom.Length <1)
            {
                MessageBox.Show("本机没有串口！", "Error");
                cbBox_PORT.Items.Clear();
                return;
            }
            //通过WMI获取COM端口
            string[] port_allnames = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            int portSize = port_allnames.Count();
            port_descrpt = new List<string>();
            port_names = new List<string>();
            for (int i = 0; i < portSize; i++)
            {
                string name = port_allnames[i];
                int istrs = name.LastIndexOf('(');
                int istre = name.LastIndexOf(')');
                port_names.Add(name.Substring(istrs + 1, istre - istrs - 1));
                port_descrpt.Add(name.Substring(0, istrs));
            }
            cbBox_PORT.Items.Clear();
            cbBox_PORT.Items.AddRange(port_names.ToArray());
            cbBox_PORT.SelectedIndex = 0;
        }
        bool isHexDisplay = false;
        private void ckBox_HexDis_CheckedChanged(object sender, EventArgs e)
        {
            isHexDisplay = ckBox_HexDis.Checked;
        }
        bool isTimeDisplay = false;
        private void ckBox_disTime_CheckedChanged(object sender, EventArgs e)
        {
            isTimeDisplay = ckBox_disTime.Checked;
        }

        bool isRevByteDis = false;
        private void ckBox_disRevByte_CheckedChanged(object sender, EventArgs e)
        {
            isRevByteDis = ckBox_disRevByte.Checked;
        }

        bool isPauseDisplay = false;

        private void txt_clearDis_Click(object sender, EventArgs e)
        {
            txt_Received.Clear();
            revByteNumAll = 0;
            startRevTime = DateTime.Now;
        }

        private void linkLab_clearRevDis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Received.Clear();
            revByteNumAll = 0;
            startRevTime = DateTime.Now;
        }

        bool isSaveData = false;
        private void ckBox_savData_CheckedChanged(object sender, EventArgs e)
        {
            isSaveData = ckBox_savData.Checked;
        }
        bool isNewLine = false;
        private void ckBox_newline_CheckedChanged(object sender, EventArgs e)
        {
            isNewLine = ckBox_newline.Checked;
        }

        private void ckBox_pauseRev_CheckedChanged(object sender, EventArgs e)
        {
            isPauseDisplay = ckBox_pauseRev.Checked;
        }



        /// <summary>
        /// WMI取硬件信息
        /// </summary>
        /// <param name="hardType"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        public static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {
            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null)
                            if (hardInfo.Properties[propKey].Value.ToString().Contains("COM"))
                            {
                                strs.Add(hardInfo.Properties[propKey].Value.ToString());
                            }

                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            { strs = null; }
        }
    }

    /// <summary>
    /// 枚举win32 api
    /// </summary>
    public enum HardwareEnum
    {
        // 硬件
        Win32_Processor, // CPU 处理器
        Win32_PhysicalMemory, // 物理内存条
        Win32_Keyboard, // 键盘
        Win32_PointingDevice, // 点输入设备，包括鼠标。
        Win32_FloppyDrive, // 软盘驱动器
        Win32_DiskDrive, // 硬盘驱动器
        Win32_CDROMDrive, // 光盘驱动器
        Win32_BaseBoard, // 主板
        Win32_BIOS, // BIOS 芯片
        Win32_ParallelPort, // 并口
        Win32_SerialPort, // 串口
        Win32_SerialPortConfiguration, // 串口配置
        Win32_SoundDevice, // 多媒体设置，一般指声卡。
        Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
        Win32_USBController, // USB 控制器
        Win32_NetworkAdapter, // 网络适配器
        Win32_NetworkAdapterConfiguration, // 网络适配器设置
        Win32_Printer, // 打印机
        Win32_PrinterConfiguration, // 打印机设置
        Win32_PrintJob, // 打印机任务
        Win32_TCPIPPrinterPort, // 打印机端口
        Win32_POTSModem, // MODEM
        Win32_POTSModemToSerialPort, // MODEM 端口
        Win32_DesktopMonitor, // 显示器
        Win32_DisplayConfiguration, // 显卡
        Win32_DisplayControllerConfiguration, // 显卡设置
        Win32_VideoController, // 显卡细节。
        Win32_VideoSettings, // 显卡支持的显示模式。

        // 操作系统
        Win32_TimeZone, // 时区
        Win32_SystemDriver, // 驱动程序
        Win32_DiskPartition, // 磁盘分区
        Win32_LogicalDisk, // 逻辑磁盘
        Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
        Win32_LogicalMemoryConfiguration, // 逻辑内存配置
        Win32_PageFile, // 系统页文件信息
        Win32_PageFileSetting, // 页文件设置
        Win32_BootConfiguration, // 系统启动配置
        Win32_ComputerSystem, // 计算机信息简要
        Win32_OperatingSystem, // 操作系统信息
        Win32_StartupCommand, // 系统自动启动程序
        Win32_Service, // 系统安装的服务
        Win32_Group, // 系统管理组
        Win32_GroupUser, // 系统组帐号
        Win32_UserAccount, // 用户帐号
        Win32_Process, // 系统进程
        Win32_Thread, // 系统线程
        Win32_Share, // 共享
        Win32_NetworkClient, // 已安装的网络客户端
        Win32_NetworkProtocol, // 已安装的网络协议
        Win32_PnPEntity,//all device
    }

   
}
