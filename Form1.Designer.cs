namespace npfhttp
{
    partial class npfhttp
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
            this.label1 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.hostTB = new System.Windows.Forms.TextBox();
            this.portTB = new System.Windows.Forms.TextBox();
            this.stopBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "npfhttp";
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(46, 257);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(84, 36);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // hostTB
            // 
            this.hostTB.Location = new System.Drawing.Point(12, 172);
            this.hostTB.Name = "hostTB";
            this.hostTB.Size = new System.Drawing.Size(118, 20);
            this.hostTB.TabIndex = 3;
            this.hostTB.Text = "Host";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(215, 172);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(118, 20);
            this.portTB.TabIndex = 4;
            this.portTB.Text = "Port";
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBT.Location = new System.Drawing.Point(215, 257);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(84, 36);
            this.stopBT.TabIndex = 5;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // npfhttp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 336);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.hostTB);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label1);
            this.Name = "npfhttp";
            this.Text = "npfhttp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.TextBox hostTB;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.Button stopBT;
    }
}

