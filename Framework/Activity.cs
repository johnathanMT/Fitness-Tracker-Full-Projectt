using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Activity
    {
        private int activity_id;
        private string activity_name;
        private string[] metric_names;
        private double[] metric_values;
        private double daily_burn;

        public Activity() { }
        public Activity(int activity_id, string activity_name, string[] metric_names, double[] metric_values, double daily_burn)
        {
            this.activity_id = activity_id;
            this.activity_name = activity_name;
            this.metric_names = metric_names;
            this.metric_values = metric_values;
            this.daily_burn = daily_burn;
        }
        public int ActivityId {  get { return activity_id; }
            set { activity_id = value; } }
        public string ActivityName {  get { return activity_name; } 
            set { activity_name = value; } }
        public string[] MetricNames { get { return metric_names; }
            set { metric_names = value; } }
        public double[] MetricValues { get { return metric_values; }
            set { metric_values = value; } }
        public double DailyBurn { get { return daily_burn; } 
            set { daily_burn = value; } }
    }
}
