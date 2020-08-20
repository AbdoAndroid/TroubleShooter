namespace TroubleShooter
{
    partial class frm_Solution_Summary
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
            this.txt_summary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_BuildNumber = new System.Windows.Forms.ComboBox();
            this.CB_HotFix = new System.Windows.Forms.ComboBox();
            this.App = new System.Windows.Forms.ComboBox();
            this.lbl_app = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_summary
            // 
            this.txt_summary.Location = new System.Drawing.Point(13, 19);
            this.txt_summary.Multiline = true;
            this.txt_summary.Name = "txt_summary";
            this.txt_summary.Size = new System.Drawing.Size(333, 136);
            this.txt_summary.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txt_summary);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(352, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وصف الحل";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(13, 19);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(333, 58);
            this.txt_message.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_message);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(352, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "رسالة الى المستخدم";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(226, 406);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(93, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "تأكيد الحل";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(55, 406);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Build Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "HotFix Number\r\n";
            // 
            // CB_BuildNumber
            // 
            this.CB_BuildNumber.DisplayMember = "-1";
            this.CB_BuildNumber.FormattingEnabled = true;
            this.CB_BuildNumber.Location = new System.Drawing.Point(211, 303);
            this.CB_BuildNumber.Name = "CB_BuildNumber";
            this.CB_BuildNumber.Size = new System.Drawing.Size(121, 21);
            this.CB_BuildNumber.TabIndex = 6;
            this.CB_BuildNumber.SelectedIndexChanged += new System.EventHandler(this.CB_BuildNumber_SelectedIndexChanged);
            // 
            // CB_HotFix
            // 
            this.CB_HotFix.Enabled = false;
            this.CB_HotFix.FormattingEnabled = true;
            this.CB_HotFix.Location = new System.Drawing.Point(46, 303);
            this.CB_HotFix.Name = "CB_HotFix";
            this.CB_HotFix.Size = new System.Drawing.Size(121, 21);
            this.CB_HotFix.TabIndex = 7;
            this.CB_HotFix.SelectedIndexChanged += new System.EventHandler(this.CB_HotFix_SelectedIndexChanged);
            // 
            // App
            // 
            this.App.DisplayMember = "-1";
            this.App.Enabled = false;
            this.App.FormattingEnabled = true;
            this.App.Location = new System.Drawing.Point(128, 360);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(121, 21);
            this.App.TabIndex = 8;
            this.App.SelectedIndexChanged += new System.EventHandler(this.App_SelectedIndexChanged);
            // 
            // lbl_app
            // 
            this.lbl_app.AutoSize = true;
            this.lbl_app.Location = new System.Drawing.Point(164, 344);
            this.lbl_app.Name = "lbl_app";
            this.lbl_app.Size = new System.Drawing.Size(56, 13);
            this.lbl_app.TabIndex = 9;
            this.lbl_app.Text = "App Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dataGridView1.Location = new System.Drawing.Point(370, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 417);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // frm_Solution_Summary
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(770, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_app);
            this.Controls.Add(this.App);
            this.Controls.Add(this.CB_HotFix);
            this.Controls.Add(this.CB_BuildNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Solution_Summary";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Solve";
            this.Load += new System.EventHandler(this.frm_Solution_Summary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_summary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_BuildNumber;
        private System.Windows.Forms.ComboBox CB_HotFix;
        private System.Windows.Forms.ComboBox App;
        private System.Windows.Forms.Label lbl_app;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}