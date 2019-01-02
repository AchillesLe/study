namespace TEST
{
    partial class dailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ngaytruoc = new System.Windows.Forms.Button();
            this.btn_ngaysau = new System.Windows.Forms.Button();
            this.date_time_date = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_themviec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_today = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_job = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_job);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ngaytruoc);
            this.panel2.Controls.Add(this.btn_ngaysau);
            this.panel2.Controls.Add(this.date_time_date);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 29);
            this.panel2.TabIndex = 0;
            // 
            // btn_ngaytruoc
            // 
            this.btn_ngaytruoc.Location = new System.Drawing.Point(270, 3);
            this.btn_ngaytruoc.Name = "btn_ngaytruoc";
            this.btn_ngaytruoc.Size = new System.Drawing.Size(75, 23);
            this.btn_ngaytruoc.TabIndex = 1;
            this.btn_ngaytruoc.Text = "Ngày trước";
            this.btn_ngaytruoc.UseVisualStyleBackColor = true;
            this.btn_ngaytruoc.Click += new System.EventHandler(this.btn_ngaytruoc_Click);
            // 
            // btn_ngaysau
            // 
            this.btn_ngaysau.Location = new System.Drawing.Point(684, 4);
            this.btn_ngaysau.Name = "btn_ngaysau";
            this.btn_ngaysau.Size = new System.Drawing.Size(75, 23);
            this.btn_ngaysau.TabIndex = 1;
            this.btn_ngaysau.Text = "Ngày sau";
            this.btn_ngaysau.UseVisualStyleBackColor = true;
            this.btn_ngaysau.Click += new System.EventHandler(this.btn_ngaysau_Click);
            // 
            // date_time_date
            // 
            this.date_time_date.Location = new System.Drawing.Point(418, 5);
            this.date_time_date.Name = "date_time_date";
            this.date_time_date.Size = new System.Drawing.Size(200, 20);
            this.date_time_date.TabIndex = 0;
            this.date_time_date.ValueChanged += new System.EventHandler(this.date_time_date_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_themviec,
            this.menu_today});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_themviec
            // 
            this.menu_themviec.Name = "menu_themviec";
            this.menu_themviec.Size = new System.Drawing.Size(74, 20);
            this.menu_themviec.Text = "Thêm việc";
            this.menu_themviec.Click += new System.EventHandler(this.menu_themviec_Click);
            // 
            // menu_today
            // 
            this.menu_today.Name = "menu_today";
            this.menu_today.Size = new System.Drawing.Size(68, 20);
            this.menu_today.Text = "Hôm nay";
            this.menu_today.Click += new System.EventHandler(this.menu_today_Click);
            // 
            // panel_job
            // 
            this.panel_job.Location = new System.Drawing.Point(3, 38);
            this.panel_job.Name = "panel_job";
            this.panel_job.Size = new System.Drawing.Size(1044, 468);
            this.panel_job.TabIndex = 1;
            // 
            // dailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dailyPlan";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_themviec;
        private System.Windows.Forms.ToolStripMenuItem menu_today;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date_time_date;
        private System.Windows.Forms.Button btn_ngaytruoc;
        private System.Windows.Forms.Button btn_ngaysau;
        private System.Windows.Forms.Panel panel_job;
    }
}