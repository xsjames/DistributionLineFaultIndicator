﻿namespace DistributionLineFaultIndicator
{
    partial class LinkMonitor
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPA = new System.Windows.Forms.TextBox();
            this.comboBoxCOTLen = new System.Windows.Forms.ComboBox();
            this.comboBoxPALen = new System.Windows.Forms.ComboBox();
            this.comboBoxLAddrLen = new System.Windows.Forms.ComboBox();
            this.comboBoxInAddrLen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(59, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(155, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "端口号：";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(138, 37);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxIP.TabIndex = 12;
            this.textBoxIP.Text = "127.0.0.1";
            this.textBoxIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_Ip_KeyPress);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(138, 69);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxPort.TabIndex = 13;
            this.textBoxPort.Text = "4000";
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "传送原因长度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "公共地址长度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "链路地址长度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "信息体地址长度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "链路地址：";
            // 
            // textBoxLA
            // 
            this.textBoxLA.Location = new System.Drawing.Point(138, 101);
            this.textBoxLA.Name = "textBoxLA";
            this.textBoxLA.Size = new System.Drawing.Size(100, 21);
            this.textBoxLA.TabIndex = 23;
            this.textBoxLA.Text = "1";
            this.textBoxLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "公共地址：";
            // 
            // textBoxPA
            // 
            this.textBoxPA.Location = new System.Drawing.Point(138, 134);
            this.textBoxPA.Name = "textBoxPA";
            this.textBoxPA.Size = new System.Drawing.Size(100, 21);
            this.textBoxPA.TabIndex = 25;
            this.textBoxPA.Text = "1";
            this.textBoxPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // comboBoxCOTLen
            // 
            this.comboBoxCOTLen.FormattingEnabled = true;
            this.comboBoxCOTLen.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxCOTLen.Location = new System.Drawing.Point(139, 232);
            this.comboBoxCOTLen.Name = "comboBoxCOTLen";
            this.comboBoxCOTLen.Size = new System.Drawing.Size(84, 20);
            this.comboBoxCOTLen.TabIndex = 26;
            this.comboBoxCOTLen.Text = "2";
            this.comboBoxCOTLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // comboBoxPALen
            // 
            this.comboBoxPALen.FormattingEnabled = true;
            this.comboBoxPALen.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxPALen.Location = new System.Drawing.Point(139, 258);
            this.comboBoxPALen.Name = "comboBoxPALen";
            this.comboBoxPALen.Size = new System.Drawing.Size(84, 20);
            this.comboBoxPALen.TabIndex = 27;
            this.comboBoxPALen.Text = "2";
            this.comboBoxPALen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // comboBoxLAddrLen
            // 
            this.comboBoxLAddrLen.FormattingEnabled = true;
            this.comboBoxLAddrLen.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxLAddrLen.Location = new System.Drawing.Point(140, 205);
            this.comboBoxLAddrLen.Name = "comboBoxLAddrLen";
            this.comboBoxLAddrLen.Size = new System.Drawing.Size(84, 20);
            this.comboBoxLAddrLen.TabIndex = 28;
            this.comboBoxLAddrLen.Text = "2";
            this.comboBoxLAddrLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // comboBoxInAddrLen
            // 
            this.comboBoxInAddrLen.FormattingEnabled = true;
            this.comboBoxInAddrLen.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxInAddrLen.Location = new System.Drawing.Point(139, 284);
            this.comboBoxInAddrLen.Name = "comboBoxInAddrLen";
            this.comboBoxInAddrLen.Size = new System.Drawing.Size(84, 20);
            this.comboBoxInAddrLen.TabIndex = 29;
            this.comboBoxInAddrLen.Text = "2";
            this.comboBoxInAddrLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validating_KeyPress);
            // 
            // LinkMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 425);
            this.Controls.Add(this.comboBoxInAddrLen);
            this.Controls.Add(this.comboBoxLAddrLen);
            this.Controls.Add(this.comboBoxPALen);
            this.Controls.Add(this.comboBoxCOTLen);
            this.Controls.Add(this.textBoxPA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 463);
            this.Name = "LinkMonitor";
            this.Text = "LinkMonitor";
            this.Load += new System.EventHandler(this.LinkMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPA;
        private System.Windows.Forms.ComboBox comboBoxCOTLen;
        private System.Windows.Forms.ComboBox comboBoxPALen;
        private System.Windows.Forms.ComboBox comboBoxLAddrLen;
        private System.Windows.Forms.ComboBox comboBoxInAddrLen;
    }
}