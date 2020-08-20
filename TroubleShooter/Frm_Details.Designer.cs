namespace TroubleShooter
{
    partial class Frm_Details
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Get_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pic_thumb = new System.Windows.Forms.PictureBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.GB_pic = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxdesc = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Get_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_thumb)).BeginInit();
            this.GB_pic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Get_DetailsBindingSource
            // 
            this.Get_DetailsBindingSource.DataMember = "Get_Details";
            // 
            // Pic_thumb
            // 
            this.Pic_thumb.Location = new System.Drawing.Point(6, 19);
            this.Pic_thumb.Name = "Pic_thumb";
            this.Pic_thumb.Size = new System.Drawing.Size(141, 141);
            this.Pic_thumb.TabIndex = 0;
            this.Pic_thumb.TabStop = false;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(153, 28);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(0, 13);
            this.lblOS.TabIndex = 1;
            this.lblOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(153, 57);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 13);
            this.lblIP.TabIndex = 2;
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(153, 94);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 13);
            this.lblusername.TabIndex = 3;
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_pic
            // 
            this.GB_pic.Controls.Add(this.Pic_thumb);
            this.GB_pic.Controls.Add(this.lblusername);
            this.GB_pic.Controls.Add(this.lblOS);
            this.GB_pic.Controls.Add(this.lblIP);
            this.GB_pic.Location = new System.Drawing.Point(12, 9);
            this.GB_pic.Name = "GB_pic";
            this.GB_pic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_pic.Size = new System.Drawing.Size(375, 183);
            this.GB_pic.TabIndex = 4;
            this.GB_pic.TabStop = false;
            this.GB_pic.Text = "مكان المشكلة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxdesc);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(375, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وصف المشكلة";
            // 
            // tbxdesc
            // 
            this.tbxdesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxdesc.Location = new System.Drawing.Point(3, 16);
            this.tbxdesc.Multiline = true;
            this.tbxdesc.Name = "tbxdesc";
            this.tbxdesc.ReadOnly = true;
            this.tbxdesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxdesc.Size = new System.Drawing.Size(369, 142);
            this.tbxdesc.TabIndex = 1;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(233, 365);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "حل المشكلة";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(84, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "خروج";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBugDetails";
            reportDataSource1.Value = this.Get_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TroubleShooter.Reports.rpt_Bug.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(393, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(424, 379);
            this.reportViewer1.TabIndex = 7;
            // 
            // Frm_Details
            // 
            this.AcceptButton = this.btnSolve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(829, 405);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_pic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Frm_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Get_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_thumb)).EndInit();
            this.GB_pic.ResumeLayout(false);
            this.GB_pic.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_thumb;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.GroupBox GB_pic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxdesc;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnCancel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Get_DetailsBindingSource;
     }
}