using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Sex { get; set; }
        public int ClassID { get; set; }
        public string Homeaddress { get; set; }
        public string StudentCall { get; set; }
        public int LeanSituationID { get; set; }
    }
}
