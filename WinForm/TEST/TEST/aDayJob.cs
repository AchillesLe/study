using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class aDayJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }
        private event EventHandler edited;
        private event EventHandler deleted;
        public event EventHandler Edited{
            add { edited += value; }
            remove { edited -= value; }
        }
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public aDayJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;
            this.cbx_status.DataSource = PlanItem.ListStatus;
            this.txt_job.Text = Job.Job;
            this.nmFromHour.Value = Job.FromTime.X;
            this.nmFromMinute.Value = Job.FromTime.Y;
            this.nmToHour.Value = Job.Totime.X;
            this.nmToMinute.Value = Job.Totime.Y;
            this.cbx_status.SelectedItem = Job.Status;
            this.chbx_job.Checked = Job.Status == PlanItem.ListStatus[(int)EplanItem.DONE] ? true : false;
            if (this.chbx_job.Checked == true)
            {
                this.main_panel.BackColor = Color.Gold;
            }
            if (this.Job.Job == string.Empty)
            {
                this.btn_edit.Text = "Thêm mới";
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Job.FromTime = new Point( (int)this.nmFromHour.Value , (int)this.nmFromMinute.Value ) ;
            this.Job.Totime = new Point( (int)this.nmToHour.Value , (int)this.nmToMinute.Value );
            this.Job.Status = this.cbx_status.SelectedItem.ToString();
            this.Job.Job = this.txt_job.Text;
            if (edited != null)
            {
                edited(this,new EventArgs());
                if(this.btn_edit.Text == "sửa")
                    MessageBox.Show("Cập nhật thành công !");
                else
                {
                    MessageBox.Show("Thêm mới thành công !");
                    this.btn_edit.Text = "sửa";
                }
                   
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void chbx_job_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbx_job.Checked == true)
            {
                this.main_panel.BackColor = Color.Gold;
            }
            else
            {
                this.main_panel.BackColor = DefaultBackColor;
            }
        }
    }
}
