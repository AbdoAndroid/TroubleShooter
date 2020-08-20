namespace TroubleShooter
{
    partial class frm_Build
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
            this.lbl_buildno = new System.Windows.Forms.Label();
            this.lbl_Hotfix = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_Target = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Hotfix = new System.Windows.Forms.TextBox();
            this.txt_Buildno = new System.Windows.Forms.TextBox();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.Build_group = new System.Windows.Forms.GroupBox();
            this.CB_Target = new System.Windows.Forms.ComboBox();
            this.Build_details = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.App = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Build_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tester_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_submit = new System.Windows.Forms.Button();
            this.Build_group.SuspendLayout();
            this.Build_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_buildno
            // 
            this.lbl_buildno.AutoSize = true;
            this.lbl_buildno.Location = new System.Drawing.Point(263, 26);
            this.lbl_buildno.Name = "lbl_buildno";
            this.lbl_buildno.Size = new System.Drawing.Size(76, 13);
            this.lbl_buildno.TabIndex = 0;
            this.lbl_buildno.Text = "Build Number :";
            // 
            // lbl_Hotfix
            // 
            this.lbl_Hotfix.AutoSize = true;
            this.lbl_Hotfix.Location = new System.Drawing.Point(258, 65);
            this.lbl_Hotfix.Name = "lbl_Hotfix";
            this.lbl_Hotfix.Size = new System.Drawing.Size(88, 13);
            this.lbl_Hotfix.TabIndex = 1;
            this.lbl_Hotfix.Text = "Hot Fix Number :";
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(6, 65);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(39, 13);
            this.lbl_Code.TabIndex = 2;
            this.lbl_Code.Text = "Code :";
            // 
            // lbl_Target
            // 
            this.lbl_Target.AutoSize = true;
            this.lbl_Target.Location = new System.Drawing.Point(473, 41);
            this.lbl_Target.Name = "lbl_Target";
            this.lbl_Target.Size = new System.Drawing.Size(46, 13);
            this.lbl_Target.TabIndex = 3;
            this.lbl_Target.Text = "Target :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(6, 26);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(37, 13);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date :";
            // 
            // txt_Code
            // 
            this.txt_Code.Enabled = false;
            this.txt_Code.Location = new System.Drawing.Point(44, 62);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 20);
            this.txt_Code.TabIndex = 6;
            // 
            // txt_Hotfix
            // 
            this.txt_Hotfix.Enabled = false;
            this.txt_Hotfix.Location = new System.Drawing.Point(345, 62);
            this.txt_Hotfix.Name = "txt_Hotfix";
            this.txt_Hotfix.Size = new System.Drawing.Size(100, 20);
            this.txt_Hotfix.TabIndex = 7;
            // 
            // txt_Buildno
            // 
            this.txt_Buildno.Location = new System.Drawing.Point(345, 23);
            this.txt_Buildno.Name = "txt_Buildno";
            this.txt_Buildno.Size = new System.Drawing.Size(100, 20);
            this.txt_Buildno.TabIndex = 9;
            this.txt_Buildno.TextChanged += new System.EventHandler(this.txt_Buildno_TextChanged);
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(44, 23);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(200, 20);
            this.DTP_date.TabIndex = 10;
            // 
            // Build_group
            // 
            this.Build_group.Controls.Add(this.CB_Target);
            this.Build_group.Controls.Add(this.DTP_date);
            this.Build_group.Controls.Add(this.txt_Buildno);
            this.Build_group.Controls.Add(this.txt_Hotfix);
            this.Build_group.Controls.Add(this.txt_Code);
            this.Build_group.Controls.Add(this.lbl_date);
            this.Build_group.Controls.Add(this.lbl_Target);
            this.Build_group.Controls.Add(this.lbl_Code);
            this.Build_group.Controls.Add(this.lbl_Hotfix);
            this.Build_group.Controls.Add(this.lbl_buildno);
            this.Build_group.Location = new System.Drawing.Point(8, 12);
            this.Build_group.Name = "Build_group";
            this.Build_group.Size = new System.Drawing.Size(652, 99);
            this.Build_group.TabIndex = 12;
            this.Build_group.TabStop = false;
            this.Build_group.Text = "Build";
            // 
            // CB_Target
            // 
            this.CB_Target.FormattingEnabled = true;
            this.CB_Target.Location = new System.Drawing.Point(522, 38);
            this.CB_Target.Name = "CB_Target";
            this.CB_Target.Size = new System.Drawing.Size(121, 21);
            this.CB_Target.TabIndex = 12;
            this.CB_Target.SelectedIndexChanged += new System.EventHandler(this.CB_Target_SelectedIndexChanged);
            // 
            // Build_details
            // 
            this.Build_details.Controls.Add(this.dataGridView1);
            this.Build_details.Location = new System.Drawing.Point(8, 117);
            this.Build_details.Name = "Build_details";
            this.Build_details.Size = new System.Drawing.Size(652, 254);
            this.Build_details.TabIndex = 13;
            this.Build_details.TabStop = false;
            this.Build_details.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.App,
            this.Build_Type,
            this.Details,
            this.Developer_Name,
            this.Tester_Name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // App
            // 
            this.App.HeaderText = "APP Name";
            this.App.Name = "App";
            // 
            // Build_Type
            // 
            this.Build_Type.HeaderText = "Build Type";
            this.Build_Type.Name = "Build_Type";
            this.Build_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Build_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Details
            // 
            this.Details.HeaderText = "Build Details";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Details.Width = 200;
            // 
            // Developer_Name
            // 
            this.Developer_Name.HeaderText = "Developer Name";
            this.Developer_Name.Name = "Developer_Name";
            // 
            // Tester_Name
            // 
            this.Tester_Name.HeaderText = "Tester _Name";
            this.Tester_Name.Name = "Tester_Name";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(254, 386);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(167, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // frm_Build
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 421);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.Build_details);
            this.Controls.Add(this.Build_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Build";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build";
            this.Load += new System.EventHandler(this.Build_Load);
            this.Build_group.ResumeLayout(false);
            this.Build_group.PerformLayout();
            this.Build_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_buildno;
        private System.Windows.Forms.Label lbl_Hotfix;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Target;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Hotfix;
        private System.Windows.Forms.TextBox txt_Buildno;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.GroupBox Build_group;
        private System.Windows.Forms.ComboBox CB_Target;
        private System.Windows.Forms.GroupBox Build_details;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn App;
        private System.Windows.Forms.DataGridViewComboBoxColumn Build_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewComboBoxColumn Developer_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tester_Name;
        private System.Windows.Forms.Button btn_submit;
    }
}