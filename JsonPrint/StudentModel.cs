using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPrint
{
    class StudentModel
    {
        public string enrollment;
        public string name;
        List<SubjectModel> subject = new List<SubjectModel>;
    }
}
