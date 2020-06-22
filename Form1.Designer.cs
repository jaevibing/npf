namespace npf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.floodTimer = new System.Windows.Forms.Timer(this.components);
            this.intervalTxt = new System.Windows.Forms.TextBox();
            this.ProtocolBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(12, 176);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(151, 20);
            this.IPText.TabIndex = 0;
            this.IPText.Text = "IP Address";
            this.IPText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "npf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "A network DOS tool for Windows";
            // 
            // DataText
            // 
            this.DataText.Location = new System.Drawing.Point(275, 176);
            this.DataText.Name = "DataText";
            this.DataText.Size = new System.Drawing.Size(152, 20);
            this.DataText.TabIndex = 4;
            this.DataText.Text = "Message";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop Attack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // floodTimer
            // 
            this.floodTimer.Interval = 1;
            this.floodTimer.Tick += new System.EventHandler(this.floodTimer_Tick);
            // 
            // intervalTxt
            // 
            this.intervalTxt.Location = new System.Drawing.Point(169, 176);
            this.intervalTxt.Name = "intervalTxt";
            this.intervalTxt.Size = new System.Drawing.Size(100, 20);
            this.intervalTxt.TabIndex = 6;
            this.intervalTxt.Text = "Packet Interval";
            // 
            // ProtocolBox
            // 
            this.ProtocolBox.FormattingEnabled = true;
            this.ProtocolBox.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.ProtocolBox.Location = new System.Drawing.Point(177, 233);
            this.ProtocolBox.Name = "ProtocolBox";
            this.ProtocolBox.Size = new System.Drawing.Size(76, 34);
            this.ProtocolBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(444, 291);
            this.Controls.Add(this.ProtocolBox);
            this.Controls.Add(this.intervalTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IPText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "npf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.Timer floodTimer;
        private System.Windows.Forms.TextBox intervalTxt;
        private System.Windows.Forms.CheckedListBox ProtocolBox;
    }
}

