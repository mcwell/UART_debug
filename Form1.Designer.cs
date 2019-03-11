namespace UART_COM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_openCom = new System.Windows.Forms.Button();
            this.cbBox_BAUD = new System.Windows.Forms.ComboBox();
            this.cbBox_PORT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Received = new System.Windows.Forms.RichTextBox();
            this.txt_SendStr = new System.Windows.Forms.RichTextBox();
            this.lbl_RevCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBox_CheckBit = new System.Windows.Forms.ComboBox();
            this.cbBox_DataBit = new System.Windows.Forms.ComboBox();
            this.cbBox_StopBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refresh_Uart = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.ckBox_HexDis = new System.Windows.Forms.CheckBox();
            this.ckBox_disTime = new System.Windows.Forms.CheckBox();
            this.ckBox_pauseRev = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckBox_disRevByte = new System.Windows.Forms.CheckBox();
            this.ckBox_savData = new System.Windows.Forms.CheckBox();
            this.linkLab_clearRevDis = new System.Windows.Forms.LinkLabel();
            this.ckBox_newline = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_openCom
            // 
            this.btn_openCom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openCom.Location = new System.Drawing.Point(28, 150);
            this.btn_openCom.Name = "btn_openCom";
            this.btn_openCom.Size = new System.Drawing.Size(107, 30);
            this.btn_openCom.TabIndex = 0;
            this.btn_openCom.Text = "打开串口";
            this.btn_openCom.UseVisualStyleBackColor = true;
            this.btn_openCom.Click += new System.EventHandler(this.btn_openCom_Click);
            // 
            // cbBox_BAUD
            // 
            this.cbBox_BAUD.FormattingEnabled = true;
            this.cbBox_BAUD.Location = new System.Drawing.Point(62, 46);
            this.cbBox_BAUD.Name = "cbBox_BAUD";
            this.cbBox_BAUD.Size = new System.Drawing.Size(109, 20);
            this.cbBox_BAUD.TabIndex = 1;
            // 
            // cbBox_PORT
            // 
            this.cbBox_PORT.FormattingEnabled = true;
            this.cbBox_PORT.Location = new System.Drawing.Point(62, 20);
            this.cbBox_PORT.Name = "cbBox_PORT";
            this.cbBox_PORT.Size = new System.Drawing.Size(109, 20);
            this.cbBox_PORT.TabIndex = 2;
            this.cbBox_PORT.MouseHover += new System.EventHandler(this.cbBox_PORT_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // txt_Received
            // 
            this.txt_Received.Location = new System.Drawing.Point(222, 12);
            this.txt_Received.Name = "txt_Received";
            this.txt_Received.ReadOnly = true;
            this.txt_Received.Size = new System.Drawing.Size(566, 277);
            this.txt_Received.TabIndex = 4;
            this.txt_Received.Text = "";
            // 
            // txt_SendStr
            // 
            this.txt_SendStr.Location = new System.Drawing.Point(222, 308);
            this.txt_SendStr.Name = "txt_SendStr";
            this.txt_SendStr.Size = new System.Drawing.Size(566, 130);
            this.txt_SendStr.TabIndex = 5;
            this.txt_SendStr.Text = "";
            // 
            // lbl_RevCount
            // 
            this.lbl_RevCount.AutoSize = true;
            this.lbl_RevCount.Location = new System.Drawing.Point(325, 441);
            this.lbl_RevCount.Name = "lbl_RevCount";
            this.lbl_RevCount.Size = new System.Drawing.Size(11, 12);
            this.lbl_RevCount.TabIndex = 6;
            this.lbl_RevCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "接收：";
            // 
            // cbBox_CheckBit
            // 
            this.cbBox_CheckBit.FormattingEnabled = true;
            this.cbBox_CheckBit.Location = new System.Drawing.Point(62, 72);
            this.cbBox_CheckBit.Name = "cbBox_CheckBit";
            this.cbBox_CheckBit.Size = new System.Drawing.Size(109, 20);
            this.cbBox_CheckBit.TabIndex = 1;
            // 
            // cbBox_DataBit
            // 
            this.cbBox_DataBit.FormattingEnabled = true;
            this.cbBox_DataBit.Location = new System.Drawing.Point(62, 98);
            this.cbBox_DataBit.Name = "cbBox_DataBit";
            this.cbBox_DataBit.Size = new System.Drawing.Size(109, 20);
            this.cbBox_DataBit.TabIndex = 1;
            // 
            // cbBox_StopBit
            // 
            this.cbBox_StopBit.FormattingEnabled = true;
            this.cbBox_StopBit.Location = new System.Drawing.Point(62, 124);
            this.cbBox_StopBit.Name = "cbBox_StopBit";
            this.cbBox_StopBit.Size = new System.Drawing.Size(109, 20);
            this.cbBox_StopBit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "停止位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh_Uart);
            this.groupBox1.Controls.Add(this.btn_openCom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 183);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btn_refresh_Uart
            // 
            this.btn_refresh_Uart.Location = new System.Drawing.Point(166, 18);
            this.btn_refresh_Uart.Name = "btn_refresh_Uart";
            this.btn_refresh_Uart.Size = new System.Drawing.Size(16, 23);
            this.btn_refresh_Uart.TabIndex = 0;
            this.btn_refresh_Uart.Text = "○";
            this.btn_refresh_Uart.UseVisualStyleBackColor = true;
            this.btn_refresh_Uart.Click += new System.EventHandler(this.btn_refresh_Uart_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(29, 351);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(107, 30);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "发送数据";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ckBox_HexDis
            // 
            this.ckBox_HexDis.AutoSize = true;
            this.ckBox_HexDis.Location = new System.Drawing.Point(15, 189);
            this.ckBox_HexDis.Name = "ckBox_HexDis";
            this.ckBox_HexDis.Size = new System.Drawing.Size(66, 16);
            this.ckBox_HexDis.TabIndex = 14;
            this.ckBox_HexDis.Text = "HEX显示";
            this.ckBox_HexDis.UseVisualStyleBackColor = true;
            this.ckBox_HexDis.CheckedChanged += new System.EventHandler(this.ckBox_HexDis_CheckedChanged);
            // 
            // ckBox_disTime
            // 
            this.ckBox_disTime.AutoSize = true;
            this.ckBox_disTime.Location = new System.Drawing.Point(15, 210);
            this.ckBox_disTime.Name = "ckBox_disTime";
            this.ckBox_disTime.Size = new System.Drawing.Size(72, 16);
            this.ckBox_disTime.TabIndex = 14;
            this.ckBox_disTime.Text = "显示时间";
            this.ckBox_disTime.UseVisualStyleBackColor = true;
            this.ckBox_disTime.CheckedChanged += new System.EventHandler(this.ckBox_disTime_CheckedChanged);
            // 
            // ckBox_pauseRev
            // 
            this.ckBox_pauseRev.AutoSize = true;
            this.ckBox_pauseRev.Location = new System.Drawing.Point(15, 231);
            this.ckBox_pauseRev.Name = "ckBox_pauseRev";
            this.ckBox_pauseRev.Size = new System.Drawing.Size(72, 16);
            this.ckBox_pauseRev.TabIndex = 14;
            this.ckBox_pauseRev.Text = "暂停显示";
            this.ckBox_pauseRev.UseVisualStyleBackColor = true;
            this.ckBox_pauseRev.CheckedChanged += new System.EventHandler(this.ckBox_pauseRev_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "发送：";
            // 
            // ckBox_disRevByte
            // 
            this.ckBox_disRevByte.AutoSize = true;
            this.ckBox_disRevByte.Location = new System.Drawing.Point(15, 252);
            this.ckBox_disRevByte.Name = "ckBox_disRevByte";
            this.ckBox_disRevByte.Size = new System.Drawing.Size(78, 16);
            this.ckBox_disRevByte.TabIndex = 15;
            this.ckBox_disRevByte.Text = "接收Bytes";
            this.ckBox_disRevByte.UseVisualStyleBackColor = true;
            this.ckBox_disRevByte.CheckedChanged += new System.EventHandler(this.ckBox_disRevByte_CheckedChanged);
            // 
            // ckBox_savData
            // 
            this.ckBox_savData.AutoSize = true;
            this.ckBox_savData.Location = new System.Drawing.Point(111, 211);
            this.ckBox_savData.Name = "ckBox_savData";
            this.ckBox_savData.Size = new System.Drawing.Size(72, 16);
            this.ckBox_savData.TabIndex = 16;
            this.ckBox_savData.Text = "数据保存";
            this.ckBox_savData.UseVisualStyleBackColor = true;
            this.ckBox_savData.CheckedChanged += new System.EventHandler(this.ckBox_savData_CheckedChanged);
            // 
            // linkLab_clearRevDis
            // 
            this.linkLab_clearRevDis.AutoSize = true;
            this.linkLab_clearRevDis.Location = new System.Drawing.Point(15, 277);
            this.linkLab_clearRevDis.Name = "linkLab_clearRevDis";
            this.linkLab_clearRevDis.Size = new System.Drawing.Size(53, 12);
            this.linkLab_clearRevDis.TabIndex = 18;
            this.linkLab_clearRevDis.TabStop = true;
            this.linkLab_clearRevDis.Text = "清除接收";
            this.linkLab_clearRevDis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLab_clearRevDis_LinkClicked);
            // 
            // ckBox_newline
            // 
            this.ckBox_newline.AutoSize = true;
            this.ckBox_newline.Location = new System.Drawing.Point(111, 189);
            this.ckBox_newline.Name = "ckBox_newline";
            this.ckBox_newline.Size = new System.Drawing.Size(72, 16);
            this.ckBox_newline.TabIndex = 19;
            this.ckBox_newline.Text = "添加换行";
            this.ckBox_newline.UseVisualStyleBackColor = true;
            this.ckBox_newline.CheckedChanged += new System.EventHandler(this.ckBox_newline_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.ckBox_newline);
            this.Controls.Add(this.linkLab_clearRevDis);
            this.Controls.Add(this.ckBox_savData);
            this.Controls.Add(this.ckBox_disRevByte);
            this.Controls.Add(this.ckBox_pauseRev);
            this.Controls.Add(this.ckBox_disTime);
            this.Controls.Add(this.ckBox_HexDis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_RevCount);
            this.Controls.Add(this.txt_SendStr);
            this.Controls.Add(this.txt_Received);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBox_PORT);
            this.Controls.Add(this.cbBox_StopBit);
            this.Controls.Add(this.cbBox_DataBit);
            this.Controls.Add(this.cbBox_CheckBit);
            this.Controls.Add(this.cbBox_BAUD);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.cbBox_PORT_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openCom;
        private System.Windows.Forms.ComboBox cbBox_BAUD;
        private System.Windows.Forms.ComboBox cbBox_PORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_Received;
        private System.Windows.Forms.RichTextBox txt_SendStr;
        private System.Windows.Forms.Label lbl_RevCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBox_CheckBit;
        private System.Windows.Forms.ComboBox cbBox_DataBit;
        private System.Windows.Forms.ComboBox cbBox_StopBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_refresh_Uart;
        private System.Windows.Forms.CheckBox ckBox_HexDis;
        private System.Windows.Forms.CheckBox ckBox_disTime;
        private System.Windows.Forms.CheckBox ckBox_pauseRev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckBox_disRevByte;
        private System.Windows.Forms.CheckBox ckBox_savData;
        private System.Windows.Forms.LinkLabel linkLab_clearRevDis;
        private System.Windows.Forms.CheckBox ckBox_newline;
    }
}

