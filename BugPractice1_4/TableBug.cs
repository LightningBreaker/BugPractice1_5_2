using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugPractice1_4
{
    public class TableBug
    {
        private int bug_id;
        private int bug_status;
        private string bug_manager;
        private int manager_id;
        private string bug_name;
        private string bug_description;
        private string bug_reporter;
        private int reporter_id;
        private int bug_level;
        private string bug_reason;
        private int case_id;
        private int next_bug_id;
        private char head_tag;
        private string bug_analysis;

        public int Bug_id { get => bug_id; set => bug_id = value; }
        public int Bug_status { get => bug_status; set => bug_status = value; }
        public string Bug_manager { get => bug_manager; set => bug_manager = value; }
        public int Manager_id { get => manager_id; set => manager_id = value; }
        public string Bug_name { get => bug_name; set => bug_name = value; }
        public string Bug_description { get => bug_description; set => bug_description = value; }
        public string Bug_reporter { get => bug_reporter; set => bug_reporter = value; }
        public int Reporter_id { get => reporter_id; set => reporter_id = value; }
        public int Bug_level { get => bug_level; set => bug_level = value; }
        public string Bug_reason { get => bug_reason; set => bug_reason = value; }
        public int Case_id { get => case_id; set => case_id = value; }
        public int Next_bug_id { get => next_bug_id; set => next_bug_id = value; }
        public char Head_tag { get => head_tag; set => head_tag = value; }
        public string Bug_analysis { get => bug_analysis; set => bug_analysis = value; }
    }
}
