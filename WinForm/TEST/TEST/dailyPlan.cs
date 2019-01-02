using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class dailyPlan : Form
    {
        private DateTime date;
        private PlanData jobs;
        public DateTime Date { get => date; set => date = value; }
        public PlanData Jobs { get => jobs; set => jobs = value; }
        public dailyPlan(DateTime date , PlanData jobs)
        {
            InitializeComponent();
            this.Date = date;
            this.Jobs = jobs;
            ShowData(Date);
        }
        FlowLayoutPanel flowLayout;
        private void ShowData(DateTime date)
        {
            panel_job.Controls.Clear();
            flowLayout  = new FlowLayoutPanel();
            flowLayout.Width = panel_job.Width;
            flowLayout.Height = panel_job.Height;

            if (Jobs != null && Jobs.Jobs != null)
            {
                for (int i = 0; i < Jobs.Jobs.Count; i++)
                {
                    if (Jobs.Jobs[i].Date_create == date)
                    {
                        aDayJob adayjob = new aDayJob(Jobs.Jobs[i]);
                        adayjob.Edited += Adayjob_Edited;
                        adayjob.Deleted += Adayjob_Deleted;
                        flowLayout.Controls.Add(adayjob);
                        
                    }
                }
            }
            panel_job.Controls.Add(flowLayout);
            this.date_time_date.Value = date;
        }

        private void Adayjob_Deleted(object sender, EventArgs e)
        {
            aDayJob aDay = sender as aDayJob;
            PlanItem item = aDay.Job;
            flowLayout.Controls.Remove(aDay);
            this.Jobs.Jobs.Remove(item);
        }

        private void Adayjob_Edited(object sender, EventArgs e)
        {

        }

        private void date_time_date_ValueChanged(object sender, EventArgs e)
        {
            ShowData((sender as DateTimePicker).Value);
        }

        private void btn_ngaysau_Click(object sender, EventArgs e)
        {
            this.date_time_date.Value = this.date_time_date.Value.AddDays(1);
        }

        private void btn_ngaytruoc_Click(object sender, EventArgs e)
        {
            this.date_time_date.Value = this.date_time_date.Value.AddDays(-1);
        }

        private void menu_themviec_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() {
                Date_create = this.date_time_date.Value.Date,
                Status = PlanItem.ListStatus[(int)EplanItem.COMING],
                FromTime = new Point(6, 0),
                Totime = new Point(7, 0),
                Job = string.Empty
            };
            aDayJob dayJob = new aDayJob(item);
            dayJob.Edited += Adayjob_Edited;
            dayJob.Deleted += Adayjob_Deleted;
            flowLayout.Controls.Add(dayJob);
            this.Jobs.Jobs.Add(item);
        }

        private void menu_today_Click(object sender, EventArgs e)
        {
            this.date_time_date.Value = DateTime.Today;
        }
    }
}
