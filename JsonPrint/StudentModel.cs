using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPrint
{
    class StudentModel
    {
        public string enrollment
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public List<SubjectModel> subject
        {
            get;
            set;
        }

        internal void print()
        {
            foreach(var sub in subject)
            {
                Console.Write($" {sub.code} {sub.grade} {this.enrollment} {this.name}\n");
            }
        }
    }
}
