using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Tracker
    {
        private int tracker_id;
        private string user_name;
        private int goal_burn;
        private string play_date;
        private string track_status;
        public Tracker() { }
        public Tracker(int tracker_id, string user_name, int goal_burn, string play_date, string track_status)
        {
            this.tracker_id = tracker_id;
            this.user_name = user_name;
            this.goal_burn = goal_burn;
            this.play_date = play_date;
            this.track_status = track_status;
        }
        public int TrackerId { get { return tracker_id; } set { tracker_id = value; } } 
        public string UserName {  get { return user_name; } set { user_name = value; } }
        public int GoalBurn {  get { return goal_burn; } set { goal_burn = value; } }
        public string PlayDate { get { return play_date; } set { play_date = value; } }
        public string TrackStatus { get { return track_status; } set { track_status = value; } }

    }
}
