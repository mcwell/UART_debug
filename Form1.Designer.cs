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
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_clearRev = new System.Windows.Forms.Button();
            this.btn_refresh_Uart = new System.Windows.Forms.Button();
            this.btn_saveData = new System.Windows.Forms.Button();
            this.ckBox_HexDis = new System.Windows.Forms.CheckBox();
            this.ckBox_disTime = new System.Windows.Forms.CheckBox();
            this.ckBox_pauseRev = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_openCom
            // 
            this.btn_openCom.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openCom.Location = new System.Drawing.Point(29, 174);
            this.btn_openCom.Name = "btn_openCom";
            this.btn_openCom.Size = new System.Drawing.Size(142, 32);
            this.btn_openCom.TabIndex = 0;
            this.btn_openCom.Text = "打开串口";
            this.btn_openCom.UseVisualStyleBackColor = true;
            this.btn_openCom.Click += new System.EventHandler(this.btn_openCom_Click);
            // 
            // cbBox_BAUD
            // 
            this.cbBox_BAUD.FormattingEnabled = true;
            this.cbBox_BAUD.Location = new System.Drawing.Point(62, 48);
            this.cbBox_BAUD.Name = "cbBox_BAUD";
            this.cbBox_BAUD.Size = new System.Drawing.Size(121, 20);
            this.cbBox_BAUD.TabIndex = 1;
            // 
            // cbBox_PORT
            // 
            this.cbBox_PORT.FormattingEnabled = true;
            this.cbBox_PORT.Location = new System.Drawing.Point(62, 20);
            this.cbBox_PORT.Name = "cbBox_PORT";
            this.cbBox_PORT.Size = new System.Drawing.Size(121, 20);
            this.cbBox_PORT.TabIndex = 2;
            this.cbBox_PORT.MouseHover += new System.EventHandler(this.cbBox_PORT_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
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
            this.cbBox_CheckBit.Location = new System.Drawing.Point(62, 76);
            this.cbBox_CheckBit.Name = "cbBox_CheckBit";
            this.cbBox_CheckBit.Size = new System.Drawing.Size(121, 20);
            this.cbBox_CheckBit.TabIndex = 1;
            // 
            // cbBox_DataBit
            // 
            this.cbBox_DataBit.FormattingEnabled = true;
            this.cbBox_DataBit.Location = new System.Drawing.Point(62, 104);
            this.cbBox_DataBit.Name = "cbBox_DataBit";
            this.cbBox_DataBit.Size = new System.Drawing.Size(121, 20);
            this.cbBox_DataBit.TabIndex = 1;
            // 
            // cbBox_StopBit
            // 
            this.cbBox_StopBit.FormattingEnabled = true;
            this.cbBox_StopBit.Location = new System.Drawing.Point(62, 132);
            this.cbBox_StopBit.Name = "cbBox_StopBit";
            this.cbBox_StopBit.Size = new System.Drawing.Size(121, 20);
            this.cbBox_StopBit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "停止位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh_Uart);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 216);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(29, 351);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(142, 32);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "发送数据";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn_clearRev
            // 
            this.btn_clearRev.Location = new System.Drawing.Point(110, 282);
            this.btn_clearRev.Name = "btn_clearRev";
            this.btn_clearRev.Size = new System.Drawing.Size(61, 23);
            this.btn_clearRev.TabIndex = 12;
            this.btn_clearRev.Text = "清除接收";
            this.btn_clearRev.UseVisualStyleBackColor = true;
            this.btn_clearRev.Click += new System.EventHandler(this.btn_clearRev_Click);
            // 
            // btn_refresh_Uart
            // 
            this.btn_refresh_Uart.Location = new System.Drawing.Point(182, 18);
            this.btn_refresh_Uart.Name = "btn_refresh_Uart";
            this.btn_refresh_Uart.Size = new System.Drawing.Size(13, 23);
            this.btn_refresh_Uart.TabIndex = 0;
            this.btn_refresh_Uart.Text = "○";
            this.btn_refresh_Uart.UseVisualStyleBackColor = true;
            this.btn_refresh_Uart.Click += new System.EventHandler(this.btn_refresh_Uart_Click);
            // 
            // btn_saveData
            // 
            this.btn_saveData.Location = new System.Drawing.Point(12, 282);
            this.btn_saveData.Name = "btn_saveData";
            this.btn_saveData.Size = new System.Drawing.Size(64, 23);
            this.btn_saveData.TabIndex = 13;
            this.btn_saveData.Text = "保存数据";
            this.btn_saveData.UseVisualStyleBackColor = true;
            // 
            // ckBox_HexDis
            // 
            this.ckBox_HexDis.AutoSize = true;
            this.ckBox_HexDis.Location = new System.Drawing.Point(15, 224);
            this.ckBox_HexDis.Name = "ckBox_HexDis";
            this.ckBox_HexDis.Size = new System.Drawing.Size(96, 16);
            this.ckBox_HexDis.TabIndex = 14;
            this.ckBox_HexDis.Text = "十六进制显示";
            this.ckBox_HexDis.UseVisualStyleBackColor = true;
            this.ckBox_HexDis.CheckedChanged += new System.EventHandler(this.ckBox_HexDis_CheckedChanged);
            // 
            // ckBox_disTime
            // 
            this.ckBox_disTime.AutoSize = true;
            this.ckBox_disTime.Location = new System.Drawing.Point(15, 243);
            this.ckBox_disTime.Name = "ckBox_disTime";
            this.ckBox_disTime.Size = new System.Drawing.Size(96, 16);
            this.ckBox_disTime.TabIndex = 14;
            this.ckBox_disTime.Text = "显示接收时间";
            this.ckBox_disTime.UseVisualStyleBackColor = true;
            this.ckBox_disTime.CheckedChanged += new System.EventHandler(this.ckBox_disTime_CheckedChanged);
            // 
            // ckBox_pauseRev
            // 
            this.ckBox_pauseRev.AutoSize = true;
            this.ckBox_pauseRev.Location = new System.Drawing.Point(15, 262);
            this.ckBox_pauseRev.Name = "ckBox_pauseRev";
            this.ckBox_pauseRev.Size = new System.Drawing.Size(96, 16);
            this.ckBox_pauseRev.TabIndex = 14;
            this.ckBox_pauseRev.Text = "暂停接收显示";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.ckBox_pauseRev);
            this.Controls.Add(this.ckBox_disTime);
            this.Controls.Add(this.ckBox_HexDis);
            this.Controls.Add(this.btn_saveData);
            this.Controls.Add(this.btn_clearRev);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.btn_openCom);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.cbBox_PORT_MouseHover);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_clearRev;
        private System.Windows.Forms.Button btn_refresh_Uart;
        private System.Windows.Forms.Button btn_saveData;
        private System.Windows.Forms.CheckBox ckBox_HexDis;
        private System.Windows.Forms.CheckBox ckBox_disTime;
        private System.Windows.Forms.CheckBox ckBox_pauseRev;
        private System.Windows.Forms.Label label7;
    }
}

