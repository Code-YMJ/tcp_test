namespace tcp_test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbCommunication = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnSearchCSVDir = new System.Windows.Forms.Button();
            this.lbPort = new System.Windows.Forms.Label();
            this.gbTcpServer = new System.Windows.Forms.GroupBox();
            this.gbCSV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCSVDir = new System.Windows.Forms.TextBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogDir = new System.Windows.Forms.TextBox();
            this.btnSearchLogDir = new System.Windows.Forms.Button();
            this.gbTestParam = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDuty = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbInputAC = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbProximity = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbTempExternal = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbTempInternal = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbMachineId = new System.Windows.Forms.ComboBox();
            this.lbState = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbMachineID = new System.Windows.Forms.Label();
            this.gbTcpServer.SuspendLayout();
            this.gbCSV.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.gbTestParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(185, 45);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbCommunication
            // 
            this.tbCommunication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCommunication.Location = new System.Drawing.Point(3, 17);
            this.tbCommunication.Multiline = true;
            this.tbCommunication.Name = "tbCommunication";
            this.tbCommunication.ReadOnly = true;
            this.tbCommunication.Size = new System.Drawing.Size(880, 322);
            this.tbCommunication.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(52, 21);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(136, 21);
            this.tbPort.TabIndex = 2;
            // 
            // btnSearchCSVDir
            // 
            this.btnSearchCSVDir.Location = new System.Drawing.Point(21, 48);
            this.btnSearchCSVDir.Name = "btnSearchCSVDir";
            this.btnSearchCSVDir.Size = new System.Drawing.Size(185, 45);
            this.btnSearchCSVDir.TabIndex = 3;
            this.btnSearchCSVDir.Text = "Search";
            this.btnSearchCSVDir.UseVisualStyleBackColor = true;
            this.btnSearchCSVDir.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(19, 28);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(27, 12);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Port";
            // 
            // gbTcpServer
            // 
            this.gbTcpServer.Controls.Add(this.lbPort);
            this.gbTcpServer.Controls.Add(this.btnOpen);
            this.gbTcpServer.Controls.Add(this.tbPort);
            this.gbTcpServer.Location = new System.Drawing.Point(12, 12);
            this.gbTcpServer.Name = "gbTcpServer";
            this.gbTcpServer.Size = new System.Drawing.Size(225, 100);
            this.gbTcpServer.TabIndex = 5;
            this.gbTcpServer.TabStop = false;
            this.gbTcpServer.Text = "TCP Server";
            // 
            // gbCSV
            // 
            this.gbCSV.Controls.Add(this.label1);
            this.gbCSV.Controls.Add(this.tbCSVDir);
            this.gbCSV.Controls.Add(this.btnSearchCSVDir);
            this.gbCSV.Location = new System.Drawing.Point(322, 12);
            this.gbCSV.Name = "gbCSV";
            this.gbCSV.Size = new System.Drawing.Size(225, 100);
            this.gbCSV.TabIndex = 6;
            this.gbCSV.TabStop = false;
            this.gbCSV.Text = "CSV Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dir";
            // 
            // tbCSVDir
            // 
            this.tbCSVDir.Location = new System.Drawing.Point(58, 21);
            this.tbCSVDir.Name = "tbCSVDir";
            this.tbCSVDir.Size = new System.Drawing.Size(136, 21);
            this.tbCSVDir.TabIndex = 5;
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.label2);
            this.gbLog.Controls.Add(this.tbLogDir);
            this.gbLog.Controls.Add(this.btnSearchLogDir);
            this.gbLog.Location = new System.Drawing.Point(634, 12);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(225, 100);
            this.gbLog.TabIndex = 7;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dir";
            // 
            // tbLogDir
            // 
            this.tbLogDir.Location = new System.Drawing.Point(58, 21);
            this.tbLogDir.Name = "tbLogDir";
            this.tbLogDir.Size = new System.Drawing.Size(136, 21);
            this.tbLogDir.TabIndex = 5;
            // 
            // btnSearchLogDir
            // 
            this.btnSearchLogDir.Location = new System.Drawing.Point(21, 48);
            this.btnSearchLogDir.Name = "btnSearchLogDir";
            this.btnSearchLogDir.Size = new System.Drawing.Size(185, 45);
            this.btnSearchLogDir.TabIndex = 3;
            this.btnSearchLogDir.Text = "Search";
            this.btnSearchLogDir.UseVisualStyleBackColor = true;
            // 
            // gbTestParam
            // 
            this.gbTestParam.Controls.Add(this.lbMachineID);
            this.gbTestParam.Controls.Add(this.label3);
            this.gbTestParam.Controls.Add(this.textBox8);
            this.gbTestParam.Controls.Add(this.lbState);
            this.gbTestParam.Controls.Add(this.textBox7);
            this.gbTestParam.Controls.Add(this.cbMachineId);
            this.gbTestParam.Controls.Add(this.lbTempExternal);
            this.gbTestParam.Controls.Add(this.textBox5);
            this.gbTestParam.Controls.Add(this.lbTempInternal);
            this.gbTestParam.Controls.Add(this.textBox6);
            this.gbTestParam.Controls.Add(this.lbInputAC);
            this.gbTestParam.Controls.Add(this.textBox3);
            this.gbTestParam.Controls.Add(this.lbProximity);
            this.gbTestParam.Controls.Add(this.textBox4);
            this.gbTestParam.Controls.Add(this.lbDuty);
            this.gbTestParam.Controls.Add(this.textBox2);
            this.gbTestParam.Controls.Add(this.lbLevel);
            this.gbTestParam.Controls.Add(this.textBox1);
            this.gbTestParam.Location = new System.Drawing.Point(12, 126);
            this.gbTestParam.Name = "gbTestParam";
            this.gbTestParam.Size = new System.Drawing.Size(886, 137);
            this.gbTestParam.TabIndex = 8;
            this.gbTestParam.TabStop = false;
            this.gbTestParam.Text = "Detect Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCommunication);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 342);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detect Values";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(365, 45);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(35, 12);
            this.lbLevel.TabIndex = 6;
            this.lbLevel.Text = "Level";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 21);
            this.textBox1.TabIndex = 5;
            // 
            // lbDuty
            // 
            this.lbDuty.AutoSize = true;
            this.lbDuty.Location = new System.Drawing.Point(365, 95);
            this.lbDuty.Name = "lbDuty";
            this.lbDuty.Size = new System.Drawing.Size(30, 12);
            this.lbDuty.TabIndex = 8;
            this.lbDuty.Text = "Duty";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 21);
            this.textBox2.TabIndex = 7;
            // 
            // lbInputAC
            // 
            this.lbInputAC.AutoSize = true;
            this.lbInputAC.Location = new System.Drawing.Point(518, 95);
            this.lbInputAC.Name = "lbInputAC";
            this.lbInputAC.Size = new System.Drawing.Size(53, 12);
            this.lbInputAC.TabIndex = 12;
            this.lbInputAC.Text = "Input AC";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(583, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 21);
            this.textBox3.TabIndex = 11;
            // 
            // lbProximity
            // 
            this.lbProximity.AutoSize = true;
            this.lbProximity.Location = new System.Drawing.Point(518, 45);
            this.lbProximity.Name = "lbProximity";
            this.lbProximity.Size = new System.Drawing.Size(58, 12);
            this.lbProximity.TabIndex = 10;
            this.lbProximity.Text = "Proximity";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(582, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 21);
            this.textBox4.TabIndex = 9;
            // 
            // lbTempExternal
            // 
            this.lbTempExternal.AutoSize = true;
            this.lbTempExternal.Location = new System.Drawing.Point(692, 92);
            this.lbTempExternal.Name = "lbTempExternal";
            this.lbTempExternal.Size = new System.Drawing.Size(66, 12);
            this.lbTempExternal.TabIndex = 16;
            this.lbTempExternal.Text = "Temp EXT";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(767, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(103, 21);
            this.textBox5.TabIndex = 15;
            // 
            // lbTempInternal
            // 
            this.lbTempInternal.AutoSize = true;
            this.lbTempInternal.Location = new System.Drawing.Point(696, 45);
            this.lbTempInternal.Name = "lbTempInternal";
            this.lbTempInternal.Size = new System.Drawing.Size(62, 12);
            this.lbTempInternal.TabIndex = 14;
            this.lbTempInternal.Text = "Temp INT";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(764, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 21);
            this.textBox6.TabIndex = 13;
            // 
            // cbMachineId
            // 
            this.cbMachineId.FormattingEnabled = true;
            this.cbMachineId.Location = new System.Drawing.Point(21, 49);
            this.cbMachineId.Name = "cbMachineId";
            this.cbMachineId.Size = new System.Drawing.Size(150, 20);
            this.cbMachineId.TabIndex = 17;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(196, 45);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(33, 12);
            this.lbState.TabIndex = 19;
            this.lbState.Text = "State";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(247, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(103, 21);
            this.textBox7.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "HZ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(247, 89);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(103, 21);
            this.textBox8.TabIndex = 20;
            // 
            // lbMachineID
            // 
            this.lbMachineID.AutoSize = true;
            this.lbMachineID.Location = new System.Drawing.Point(25, 30);
            this.lbMachineID.Name = "lbMachineID";
            this.lbMachineID.Size = new System.Drawing.Size(69, 12);
            this.lbMachineID.TabIndex = 22;
            this.lbMachineID.Text = "Machine ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTestParam);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbCSV);
            this.Controls.Add(this.gbTcpServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTcpServer.ResumeLayout(false);
            this.gbTcpServer.PerformLayout();
            this.gbCSV.ResumeLayout(false);
            this.gbCSV.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.gbTestParam.ResumeLayout(false);
            this.gbTestParam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbCommunication;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnSearchCSVDir;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.GroupBox gbTcpServer;
        private System.Windows.Forms.GroupBox gbCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCSVDir;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogDir;
        private System.Windows.Forms.Button btnSearchLogDir;
        private System.Windows.Forms.GroupBox gbTestParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDuty;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbMachineId;
        private System.Windows.Forms.Label lbTempExternal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbTempInternal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbInputAC;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbProximity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbMachineID;
    }
}

