namespace TroubleShooter
{
    partial class frm_Notification
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerShowMessage = new System.Windows.Forms.Timer(this.components);
            this.btnrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 108);
            this.textBox1.TabIndex = 0;
            // 
            // timerShowMessage
            // 
            this.timerShowMessage.Interval = 1000;
            this.timerShowMessage.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnrate
            // 
            this.btnrate.Location = new System.Drawing.Point(96, 194);
            this.btnrate.Name = "btnrate";
            this.btnrate.Size = new System.Drawing.Size(75, 23);
            this.btnrate.TabIndex = 1;
            this.btnrate.Text = "تأكيد";
            this.btnrate.UseVisualStyleBackColor = true;
            this.btnrate.Click += new System.EventHandler(this.btnrate_Click);
            // 
            // frm_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnrate);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerShowMessage;
        private System.Windows.Forms.Button btnrate;
    }
}