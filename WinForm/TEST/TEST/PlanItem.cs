using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class PlanItem
    {
        private DateTime date_create;
        public DateTime Date_create { get => date_create; set => date_create = value; }
        private string job;
        public string Job { get => job; set => job = value; }

        private Point fromTime;
        public Point FromTime { get => fromTime; set => fromTime = value; }

        private Point toTime;
        public Point Totime { get => toTime; set => toTime = value; }

        private string status;
        public string Status { get => status; set => status = value; }
        

        public static List<string> ListStatus = new List<string>() { "COMING", "DOING", "MISSED", "DONE" };
        
    }
    public enum EplanItem
    {
        COMING,
        DOING,
        MISSED,
        DONE
    }
}
