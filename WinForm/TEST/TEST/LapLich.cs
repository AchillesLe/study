using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TEST
{
    public partial class LapLich : Form
    {
        public LapLich()
        {
            InitializeComponent();
        }
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private PlanData jobs;
        public PlanData Jobs { get => jobs; set => jobs = value; }
        private String filePath = "data.xml";

        private List<string> dateOfweek = new List<string>() {"Monday","Tuesday","Wednesday","Thursday","Friday", "Saturday", "Sunday"};
        private void LapLich_Load(object sender, EventArgs e)
        {
            Loadmatrix();
            try {
                Jobs = DeserializableFromXml(filePath) as PlanData;
            }
            catch {
                SetDefaultJob();
            }

        }
        private void SetDefaultJob()
        {
            jobs = new PlanData();
            jobs.Jobs = new List<PlanItem>();

            jobs.Jobs.Add( new PlanItem() {
                Date_create = DateTime.Today ,
                Job = "Test plan",
                FromTime = new Point(4,0) ,
                Totime = new Point(5,0),
                Status = PlanItem.ListStatus[(int)EplanItem.MISSED]
            });

            jobs.Jobs.Add(new PlanItem()
            {
                Date_create = DateTime.Today,
                Job = "Test plan",
                FromTime = new Point(4, 0),
                Totime = new Point(5, 0),
                Status = PlanItem.ListStatus[(int)EplanItem.COMING]
            });

            jobs.Jobs.Add(new PlanItem()
            {
                Date_create = DateTime.Today,
                Job = "Test plan",
                FromTime = new Point(4, 0),
                Totime = new Point(5, 0),
                Status = PlanItem.ListStatus[(int)EplanItem.DOING]
            });
        }
        private void Loadmatrix()
        {
            matrix = new List<List<Button>>();
            Button old_Button = new Button() { Width = 0 , Height = 0 , Location = new Point(0,0) };
            for(int i=0 ; i< constant.DayOfColumn ; i++)
            {
                Matrix.Add(new List<Button>());
                for ( int j = 0; j < constant.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = constant.dateButtonWidth, Height = constant.dateButtonHeight };
                    if ( j == 0 )
                    {
                        btn.Location = new Point(old_Button.Location.X + old_Button.Width , old_Button.Location.Y);
                    }
                    else
                    {
                        btn.Location = new Point(old_Button.Location.X + old_Button.Width + constant.margin_x, old_Button.Location.Y);
                    }
                    btn.BackColor = Color.FromArgb(220, 220, 220);
                    this.panel_matrix.Controls.Add(btn);
                   
                    this.Matrix[i].Add(btn);
                    old_Button = btn;
                }
                old_Button = new Button() { Width = 0, Height = 0, Location = new Point(0, old_Button.Location.Y + constant.dateButtonHeight + constant.margin_y) };
            }
            AddnuNumberIntoMaxtrix(this.date_time_date.Value);
        }

        private int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 == 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default: return 30;

            }
        }
        private void AddnuNumberIntoMaxtrix(DateTime date)
        {
            DateTime userDate = new DateTime(date.Year,date.Month,1);
            int line = 0;
            int days = DayOfMonth(date);
            for (int i = 1;i < days ; i++ )
            {
                int column = dateOfweek.IndexOf(userDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (userDate.Date == DateTime.Today)
                {
                    btn.BackColor = Color.FromArgb(255, 153, 153);
                }
                btn.Click += choose_day;
                if (column >= 6)
                    line++;
                userDate = userDate.AddDays(1);
            }
        }
        private void SetDefaultDate()
        {
            this.date_time_date.Value = DateTime.Now;
        }
        private void ResetTextDays()
        {
            for(int i=0 ; i< Matrix.Count ; i++)
            {
                for(int j=0; j< Matrix[i].Count; j++)
                {
                    Matrix[i][j].Text = "";
                    Matrix[i][j].BackColor = Color.FromArgb(220, 220, 220);
                }
            }
        }
        private void date_time_date_ValueChanged(object sender, EventArgs e)
        {
            ResetTextDays();
            AddnuNumberIntoMaxtrix(date_time_date.Value);
        }
        private void changDate(DateTime date)
        {
            ResetTextDays();
            AddnuNumberIntoMaxtrix(date);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            date_time_date.Value = date_time_date.Value.AddMonths(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {     
            date_time_date.Value = date_time_date.Value.AddMonths(-1);
        }
        private void btn_today_Click(object sender, EventArgs e)
        {
            date_time_date.Value = System.DateTime.Now;
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    if(Matrix[i][j].Text == date_time_date.Value.Day.ToString())
                    {
                        Matrix[i][j].BackColor = Color.FromArgb(255, 153, 153);
                    }
                }
            }
        }
        private void choose_day(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //if(btn.BackColor != Color.FromArgb(255, 153, 153))
            //{
            //    if (btn.BackColor == Color.FromArgb(255, 255, 0))
            //    {
            //        btn.BackColor = Color.FromArgb(220, 220, 220);
            //    }
            //    else
            //    {
            //        btn.BackColor = Color.FromArgb(255, 255, 0);
            //    }
            //}
             dailyPlan daily = new dailyPlan( new DateTime(date_time_date.Value.Year, date_time_date.Value.Month, int.Parse( (sender as Button).Text) ) , Jobs );
            daily.ShowDialog();
        }

        private void SerializableToXml(object data,string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xsr = new XmlSerializer(typeof(PlanData));
            xsr.Serialize(fs, data);
            fs.Close();
        }
        private object DeserializableFromXml(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xsr = new XmlSerializer(typeof(PlanData));
                object result = xsr.Deserialize(fs);
                fs.Close();
                return result;
            }catch(Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
                
            }
            return null;
        }

        private void LapLich_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializableToXml(jobs,filePath);
        }
    }
}
