namespace TEST
{
    partial class Form3
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
            this.progress_1 = new System.Windows.Forms.ProgressBar();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_reset = new System.Windows.Forms.Button();
            this.lable_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress_1
            // 
            this.progress_1.Location = new System.Drawing.Point(209, 71);
            this.progress_1.Name = "progress_1";
            this.progress_1.Size = new System.Drawing.Size(300, 23);
            this.progress_1.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(209, 144);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "load progressbar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(377, 144);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(132, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "reset progressbar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lable_time
            // 
            this.lable_time.AutoSize = true;
            this.lable_time.Location = new System.Drawing.Point(206, 9);
            this.lable_time.Name = "lable_time";
            this.lable_time.Size = new System.Drawing.Size(26, 13);
            this.lable_time.TabIndex = 4;
            this.lable_time.Text = "time";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lable_time);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.progress_1);
            this.Controls.Add(this.btn_start);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ProgressBar progress_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lable_time;
    }
}