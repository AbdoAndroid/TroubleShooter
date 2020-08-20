namespace TroubleShooter
{
    partial class frmUserError
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnAddProperty = new System.Windows.Forms.RadioButton();
            this.rdbtnEditData = new System.Windows.Forms.RadioButton();
            this.rdbtnUserError = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lnkLblDeveloper = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(83, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "إرسال";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(333, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وصف موجز";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 122);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnAddProperty);
            this.groupBox1.Controls.Add(this.rdbtnEditData);
            this.groupBox1.Controls.Add(this.rdbtnUserError);
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(333, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع المشكلة";
            // 
            // rdbtnAddProperty
            // 
            this.rdbtnAddProperty.AutoSize = true;
            this.rdbtnAddProperty.Location = new System.Drawing.Point(138, 64);
            this.rdbtnAddProperty.Name = "rdbtnAddProperty";
            this.rdbtnAddProperty.Size = new System.Drawing.Size(178, 17);
            this.rdbtnAddProperty.TabIndex = 2;
            this.rdbtnAddProperty.Tag = "4";
            this.rdbtnAddProperty.Text = "طلب إضافة أو تعديل وظيفة خاصية";
            this.rdbtnAddProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbtnAddProperty.UseVisualStyleBackColor = true;
            // 
            // rdbtnEditData
            // 
            this.rdbtnEditData.AutoSize = true;
            this.rdbtnEditData.Location = new System.Drawing.Point(23, 29);
            this.rdbtnEditData.Name = "rdbtnEditData";
            this.rdbtnEditData.Size = new System.Drawing.Size(143, 17);
            this.rdbtnEditData.TabIndex = 1;
            this.rdbtnEditData.Tag = "3";
            this.rdbtnEditData.Text = "طلب تعديل أو إضافة بيانات";
            this.rdbtnEditData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbtnEditData.UseVisualStyleBackColor = true;
            // 
            // rdbtnUserError
            // 
            this.rdbtnUserError.AutoSize = true;
            this.rdbtnUserError.Location = new System.Drawing.Point(229, 29);
            this.rdbtnUserError.Name = "rdbtnUserError";
            this.rdbtnUserError.Size = new System.Drawing.Size(84, 17);
            this.rdbtnUserError.TabIndex = 0;
            this.rdbtnUserError.Tag = "2";
            this.rdbtnUserError.Text = "خطأ بالبرنامج";
            this.rdbtnUserError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbtnUserError.UseVisualStyleBackColor = true;
            this.rdbtnUserError.CheckedChanged += new System.EventHandler(this.rdbtnUserError_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(361, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lnkLblDeveloper
            // 
            this.lnkLblDeveloper.AutoSize = true;
            this.lnkLblDeveloper.Location = new System.Drawing.Point(17, 327);
            this.lnkLblDeveloper.Name = "lnkLblDeveloper";
            this.lnkLblDeveloper.Size = new System.Drawing.Size(104, 13);
            this.lnkLblDeveloper.TabIndex = 9;
            this.lnkLblDeveloper.TabStop = true;
            this.lnkLblDeveloper.Text = "Log In As Developer";
            this.lnkLblDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDeveloper_LinkClicked);
            // 
            // frmUserError
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(361, 343);
            this.Controls.Add(this.lnkLblDeveloper);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserError";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الإبلاغ عن مشكلة";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnAddProperty;
        private System.Windows.Forms.RadioButton rdbtnEditData;
        private System.Windows.Forms.RadioButton rdbtnUserError;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel lnkLblDeveloper;
    }
}