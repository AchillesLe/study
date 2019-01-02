namespace TEST
{
    partial class LapLich
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.chbx_notify = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_today = new System.Windows.Forms.Button();
            this.date_time_date = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_matrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_sunday = new System.Windows.Forms.Button();
            this.btn_saturday = new System.Windows.Forms.Button();
            this.btn_friday = new System.Windows.Forms.Button();
            this.btn_thursday = new System.Windows.Forms.Button();
            this.btn_wednesday = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tuesday = new System.Windows.Forms.Button();
            this.btn_monday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.chbx_notify);
            this.panel6.Location = new System.Drawing.Point(3, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 23);
            this.panel6.TabIndex = 0;
            // 
            // nmNotify
            // 
            this.nmNotify.Location = new System.Drawing.Point(62, 3);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(41, 20);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chbx_notify
            // 
            this.chbx_notify.AutoSize = true;
            this.chbx_notify.Location = new System.Drawing.Point(3, 4);
            this.chbx_notify.Name = "chbx_notify";
            this.chbx_notify.Size = new System.Drawing.Size(53, 17);
            this.chbx_notify.TabIndex = 0;
            this.chbx_notify.Text = "Notify";
            this.chbx_notify.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_today);
            this.panel3.Controls.Add(this.date_time_date);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 29);
            this.panel3.TabIndex = 0;
            // 
            // btn_today
            // 
            this.btn_today.Location = new System.Drawing.Point(737, 3);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(75, 23);
            this.btn_today.TabIndex = 1;
            this.btn_today.Text = "Today";
            this.btn_today.UseVisualStyleBackColor = true;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // date_time_date
            // 
            this.date_time_date.Location = new System.Drawing.Point(530, 6);
            this.date_time_date.Name = "date_time_date";
            this.date_time_date.Size = new System.Drawing.Size(200, 20);
            this.date_time_date.TabIndex = 0;
            this.date_time_date.ValueChanged += new System.EventHandler(this.date_time_date_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_matrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(4, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 488);
            this.panel2.TabIndex = 0;
            // 
            // panel_matrix
            // 
            this.panel_matrix.Location = new System.Drawing.Point(131, 117);
            this.panel_matrix.Name = "panel_matrix";
            this.panel_matrix.Size = new System.Drawing.Size(706, 357);
            this.panel_matrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btn_sunday);
            this.panel4.Controls.Add(this.btn_saturday);
            this.panel4.Controls.Add(this.btn_friday);
            this.panel4.Controls.Add(this.btn_thursday);
            this.panel4.Controls.Add(this.btn_wednesday);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_tuesday);
            this.panel4.Controls.Add(this.btn_monday);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 55);
            this.panel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(896, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tháng sau";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sunday
            // 
            this.btn_sunday.Location = new System.Drawing.Point(748, 6);
            this.btn_sunday.Name = "btn_sunday";
            this.btn_sunday.Size = new System.Drawing.Size(89, 49);
            this.btn_sunday.TabIndex = 0;
            this.btn_sunday.Text = "Chủ nhật";
            this.btn_sunday.UseVisualStyleBackColor = true;
            // 
            // btn_saturday
            // 
            this.btn_saturday.Location = new System.Drawing.Point(645, 6);
            this.btn_saturday.Name = "btn_saturday";
            this.btn_saturday.Size = new System.Drawing.Size(89, 49);
            this.btn_saturday.TabIndex = 0;
            this.btn_saturday.Text = "Thứ 7";
            this.btn_saturday.UseVisualStyleBackColor = true;
            // 
            // btn_friday
            // 
            this.btn_friday.Location = new System.Drawing.Point(542, 6);
            this.btn_friday.Name = "btn_friday";
            this.btn_friday.Size = new System.Drawing.Size(89, 49);
            this.btn_friday.TabIndex = 0;
            this.btn_friday.Text = "Thứ 6";
            this.btn_friday.UseVisualStyleBackColor = true;
            // 
            // btn_thursday
            // 
            this.btn_thursday.Location = new System.Drawing.Point(440, 6);
            this.btn_thursday.Name = "btn_thursday";
            this.btn_thursday.Size = new System.Drawing.Size(89, 49);
            this.btn_thursday.TabIndex = 0;
            this.btn_thursday.Text = "Thứ 5";
            this.btn_thursday.UseVisualStyleBackColor = true;
            // 
            // btn_wednesday
            // 
            this.btn_wednesday.Location = new System.Drawing.Point(336, 6);
            this.btn_wednesday.Name = "btn_wednesday";
            this.btn_wednesday.Size = new System.Drawing.Size(89, 49);
            this.btn_wednesday.TabIndex = 0;
            this.btn_wednesday.Text = "Thứ 4";
            this.btn_wednesday.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tháng trước";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_tuesday
            // 
            this.btn_tuesday.Location = new System.Drawing.Point(234, 6);
            this.btn_tuesday.Name = "btn_tuesday";
            this.btn_tuesday.Size = new System.Drawing.Size(89, 49);
            this.btn_tuesday.TabIndex = 0;
            this.btn_tuesday.Text = "Thứ 3";
            this.btn_tuesday.UseVisualStyleBackColor = true;
            // 
            // btn_monday
            // 
            this.btn_monday.Location = new System.Drawing.Point(131, 6);
            this.btn_monday.Name = "btn_monday";
            this.btn_monday.Size = new System.Drawing.Size(89, 49);
            this.btn_monday.TabIndex = 0;
            this.btn_monday.Text = "Thứ 2";
            this.btn_monday.UseVisualStyleBackColor = true;
            // 
            // LapLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 540);
            this.Controls.Add(this.panel1);
            this.Name = "LapLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapLich";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LapLich_FormClosing);
            this.Load += new System.EventHandler(this.LapLich_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.DateTimePicker date_time_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_matrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_sunday;
        private System.Windows.Forms.Button btn_saturday;
        private System.Windows.Forms.Button btn_friday;
        private System.Windows.Forms.Button btn_thursday;
        private System.Windows.Forms.Button btn_wednesday;
        private System.Windows.Forms.Button btn_tuesday;
        private System.Windows.Forms.Button btn_monday;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox chbx_notify;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}