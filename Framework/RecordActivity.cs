using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class RecordActivity
    {
        private string activity_name;
        private double total_burn;
        private double goal_burn;

        public RecordActivity() { }
        public RecordActivity(string activity_name, double total_burn, double goal_burn)
        {
            this.activity_name = activity_name;
            this.total_burn = total_burn;
            this.goal_burn = goal_burn;
        }
        public string ActivityName
        {
            get { return this.activity_name; }
            set { this.activity_name = value; }
        }
        public double TotalBurn
        {
            get { return this.total_burn; }
            set { this.total_burn = value; }
        }
        public double GoalBurn
        {
            get { return this.goal_burn; }
            set { this.goal_burn = value; }
        }
    }
}
