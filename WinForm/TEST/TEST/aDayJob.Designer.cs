namespace TEST
{
    partial class aDayJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHour = new System.Windows.Forms.NumericUpDown();
            this.nmFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmFromHour = new System.Windows.Forms.NumericUpDown();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.chbx_job = new System.Windows.Forms.CheckBox();
            this.main_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.txt_job);
            this.main_panel.Controls.Add(this.chbx_job);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(973, 40);
            this.main_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.cbx_status);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmToMinute);
            this.panel2.Controls.Add(this.nmToHour);
            this.panel2.Controls.Add(this.nmFromMinute);
            this.panel2.Controls.Add(this.nmFromHour);
            this.panel2.Location = new System.Drawing.Point(468, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 31);
            this.panel2.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(445, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(378, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(50, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(251, 6);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(121, 21);
            this.cbx_status.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến";
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(196, 7);
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(37, 20);
            this.nmToMinute.TabIndex = 0;
            // 
            // nmToHour
            // 
            this.nmToHour.Location = new System.Drawing.Point(139, 7);
            this.nmToHour.Name = "nmToHour";
            this.nmToHour.Size = new System.Drawing.Size(36, 20);
            this.nmToHour.TabIndex = 0;
            // 
            // nmFromMinute
            // 
            this.nmFromMinute.Location = new System.Drawing.Point(60, 7);
            this.nmFromMinute.Name = "nmFromMinute";
            this.nmFromMinute.Size = new System.Drawing.Size(37, 20);
            this.nmFromMinute.TabIndex = 0;
            // 
            // nmFromHour
            // 
            this.nmFromHour.Location = new System.Drawing.Point(3, 7);
            this.nmFromHour.Name = "nmFromHour";
            this.nmFromHour.Size = new System.Drawing.Size(36, 20);
            this.nmFromHour.TabIndex = 0;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(87, 12);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(375, 20);
            this.txt_job.TabIndex = 1;
            // 
            // chbx_job
            // 
            this.chbx_job.AutoSize = true;
            this.chbx_job.Location = new System.Drawing.Point(12, 14);
            this.chbx_job.Name = "chbx_job";
            this.chbx_job.Size = new System.Drawing.Size(51, 17);
            this.chbx_job.TabIndex = 0;
            this.chbx_job.Text = "Chọn";
            this.chbx_job.UseVisualStyleBackColor = true;
            this.chbx_job.CheckedChanged += new System.EventHandler(this.chbx_job_CheckedChanged);
            // 
            // aDayJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Name = "aDayJob";
            this.Size = new System.Drawing.Size(973, 42);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHour;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
        private System.Windows.Forms.NumericUpDown nmFromHour;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.CheckBox chbx_job;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cbx_status;
    }
}
