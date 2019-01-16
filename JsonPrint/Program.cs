using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an expression:");
            ////var myJSON = "{    \"report\":[        {            \"enrollment\": \"rit201100\",            \"name\": \"Julia\",            \"subject\":[                {                    \"code\": \"DSA\",                    \"grade\": \"A\"                }            ]        },        {         \"enrollment\": \"rit2011020\",            \"name\": \"Samantha\",            \"subject\":[                {                    \"code\": \"COM\",                    \"grade\": \"B\"                },                {                    \"code\": \"DSA\",                    \"grade\": \"A\"                }            ]        }    ]}";
            string line, myJSON = "";
            while ((line = Console.ReadLine()) != null)
            {
                myJSON += line;
            }

            ////var report = new ReportModel();
            ////report.report = new List<StudentModel>();
            ////var student1 = new StudentModel();
            ////student1.name = "abc";
            ////student1.enrollment = "rrr123";
            ////student1.subject = new List<SubjectModel>();
            ////student1.subject.Add(new SubjectModel() { code = "End", grade = "A" });

            ////var student2 = new StudentModel();
            ////student2.name = "xyz";
            ////student2.enrollment = "rrr456";
            ////student2.subject = new List<SubjectModel>();
            ////student2.subject.Add(new SubjectModel() { code = "End", grade = "A" });

            ////report.report.Add(student1);
            ////report.report.Add(student2);

            ////var reportInJson = Newtonsoft.Json.JsonConvert.SerializeObject(report);

            var reportModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ReportModel>(myJSON);
            reportModel.print();
            Console.ReadLine();
        }
    }
}
