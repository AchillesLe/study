namespace TEST
{
    partial class Form1
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
            this.btn_send_1 = new System.Windows.Forms.Button();
            this.txt_message_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_send_1
            // 
            this.btn_send_1.Location = new System.Drawing.Point(131, 111);
            this.btn_send_1.Name = "btn_send_1";
            this.btn_send_1.Size = new System.Drawing.Size(75, 23);
            this.btn_send_1.TabIndex = 0;
            this.btn_send_1.Text = "button1";
            this.btn_send_1.UseVisualStyleBackColor = true;
            this.btn_send_1.Click += new System.EventHandler(this.btn_send_1_Click);
            // 
            // txt_message_1
            // 
            this.txt_message_1.Location = new System.Drawing.Point(76, 23);
            this.txt_message_1.Name = "txt_message_1";
            this.txt_message_1.Size = new System.Drawing.Size(191, 20);
            this.txt_message_1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.txt_message_1);
            this.Controls.Add(this.btn_send_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send_1;
        private System.Windows.Forms.TextBox txt_message_1;
    }
}

