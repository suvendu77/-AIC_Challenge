using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPrint
{
    class ReportModel
    {
        public ReportModel()
        {
           
        }
        public List<StudentModel> report
        {
            get;
            set;
        }

        public void print()
        {
            foreach(var student in report)
            {
                student.print();
            }
        }
    }
}
