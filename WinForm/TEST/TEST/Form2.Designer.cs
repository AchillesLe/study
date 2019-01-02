namespace TEST
{
    partial class Form2
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
            this.btn_send_2 = new System.Windows.Forms.Button();
            this.txt_message_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_send_2
            // 
            this.btn_send_2.Location = new System.Drawing.Point(202, 192);
            this.btn_send_2.Name = "btn_send_2";
            this.btn_send_2.Size = new System.Drawing.Size(75, 23);
            this.btn_send_2.TabIndex = 0;
            this.btn_send_2.Text = "button2";
            this.btn_send_2.UseVisualStyleBackColor = true;
            this.btn_send_2.Click += new System.EventHandler(this.btn_send_2_Click);
            // 
            // txt_message_2
            // 
            this.txt_message_2.Location = new System.Drawing.Point(141, 117);
            this.txt_message_2.Name = "txt_message_2";
            this.txt_message_2.Size = new System.Drawing.Size(209, 20);
            this.txt_message_2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 278);
            this.Controls.Add(this.txt_message_2);
            this.Controls.Add(this.btn_send_2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send_2;
        private System.Windows.Forms.TextBox txt_message_2;
    }
}