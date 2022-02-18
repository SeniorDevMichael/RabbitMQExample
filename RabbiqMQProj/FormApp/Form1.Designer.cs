
namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblStateConnectionStatus = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numeriRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.chbxUseCounter = new System.Windows.Forms.CheckBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.cbExchangeType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeclareRoutingKey = new System.Windows.Forms.TextBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeriRepeatCount)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(316, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ConnectionString";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(111, 17);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(199, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtLog.Location = new System.Drawing.Point(3, 491);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(650, 89);
            this.txtLog.TabIndex = 17;
            // 
            // lblStateConnectionStatus
            // 
            this.lblStateConnectionStatus.AutoSize = true;
            this.lblStateConnectionStatus.Location = new System.Drawing.Point(8, 585);
            this.lblStateConnectionStatus.Name = "lblStateConnectionStatus";
            this.lblStateConnectionStatus.Size = new System.Drawing.Size(159, 13);
            this.lblStateConnectionStatus.TabIndex = 18;
            this.lblStateConnectionStatus.Text = "Connection state not connected";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox5);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.pnl);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(3, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(650, 420);
            this.pnlMain.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numeriRepeatCount);
            this.groupBox5.Controls.Add(this.chbxUseCounter);
            this.groupBox5.Controls.Add(this.btnPublish);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtMessage);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtRoutingKey);
            this.groupBox5.Controls.Add(this.cbExchangeType);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtExchangeName);
            this.groupBox5.Location = new System.Drawing.Point(143, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 220);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exchange Name / Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Repeat";
            // 
            // numeriRepeatCount
            // 
            this.numeriRepeatCount.Location = new System.Drawing.Point(84, 195);
            this.numeriRepeatCount.Name = "numeriRepeatCount";
            this.numeriRepeatCount.Size = new System.Drawing.Size(76, 20);
            this.numeriRepeatCount.TabIndex = 15;
            this.numeriRepeatCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbxUseCounter
            // 
            this.chbxUseCounter.AutoSize = true;
            this.chbxUseCounter.Location = new System.Drawing.Point(177, 196);
            this.chbxUseCounter.Name = "chbxUseCounter";
            this.chbxUseCounter.Size = new System.Drawing.Size(85, 17);
            this.chbxUseCounter.TabIndex = 14;
            this.chbxUseCounter.Text = "Use Counter";
            this.chbxUseCounter.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(269, 192);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(86, 23);
            this.btnPublish.TabIndex = 13;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(82, 69);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(272, 101);
            this.txtMessage.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Routing Key";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(134, 43);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(220, 20);
            this.txtRoutingKey.TabIndex = 9;
            // 
            // cbExchangeType
            // 
            this.cbExchangeType.FormattingEnabled = true;
            this.cbExchangeType.Location = new System.Drawing.Point(253, 18);
            this.cbExchangeType.Name = "cbExchangeType";
            this.cbExchangeType.Size = new System.Drawing.Size(101, 21);
            this.cbExchangeType.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Exchange Name / Type";
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(134, 18);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(115, 20);
            this.txtExchangeName.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDeclareRoutingKey);
            this.groupBox4.Controls.Add(this.btnBindQueue);
            this.groupBox4.Location = new System.Drawing.Point(143, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 82);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bind Queue and Exchange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Routing Key";
            // 
            // txtDeclareRoutingKey
            // 
            this.txtDeclareRoutingKey.Location = new System.Drawing.Point(84, 25);
            this.txtDeclareRoutingKey.Name = "txtDeclareRoutingKey";
            this.txtDeclareRoutingKey.Size = new System.Drawing.Size(197, 20);
            this.txtDeclareRoutingKey.TabIndex = 4;
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.Location = new System.Drawing.Point(15, 51);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(266, 23);
            this.btnBindQueue.TabIndex = 3;
            this.btnBindQueue.Text = "Bind";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.btnBindQueue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDeclareExchangeType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDeclareExchangeName);
            this.groupBox3.Controls.Add(this.btnDeclareExchange);
            this.groupBox3.Location = new System.Drawing.Point(336, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 95);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declare Exchange";
            // 
            // cbDeclareExchangeType
            // 
            this.cbDeclareExchangeType.FormattingEnabled = true;
            this.cbDeclareExchangeType.Location = new System.Drawing.Point(50, 65);
            this.cbDeclareExchangeType.Name = "cbDeclareExchangeType";
            this.cbDeclareExchangeType.Size = new System.Drawing.Size(199, 21);
            this.cbDeclareExchangeType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(50, 40);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(199, 20);
            this.txtDeclareExchangeName.TabIndex = 4;
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(174, 13);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(75, 23);
            this.btnDeclareExchange.TabIndex = 3;
            this.btnDeclareExchange.Text = "Declare";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.btnDeclareExchange_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.txtDeclareQueueName);
            this.pnl.Controls.Add(this.btnDeclareQueue);
            this.pnl.Location = new System.Drawing.Point(20, 25);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(294, 69);
            this.pnl.TabIndex = 14;
            this.pnl.TabStop = false;
            this.pnl.Text = "Declare Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queue Name";
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(84, 41);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(199, 20);
            this.txtDeclareQueueName.TabIndex = 4;
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.Location = new System.Drawing.Point(208, 13);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDeclareQueue.TabIndex = 3;
            this.btnDeclareQueue.Text = "Declare";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.btnDeclareQueue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Queue/Exchang Declare  and Bind";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 604);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblStateConnectionStatus);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeriRepeatCount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblStateConnectionStatus;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numeriRepeatCount;
        private System.Windows.Forms.CheckBox chbxUseCounter;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.ComboBox cbExchangeType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeclareRoutingKey;
        private System.Windows.Forms.Button btnBindQueue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDeclareExchangeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.GroupBox pnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.Button btnDeclareQueue;
        private System.Windows.Forms.Label label2;
    }
}

