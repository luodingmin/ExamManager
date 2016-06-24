using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Model
{
    public class Specialty
    {
        public int SpecialtyID { get; set; }
        public string SpecialtyName { get; set; }
        public int SpecialtyEasyName { get; set; }
        public int DepartmentID { get; set; }
        public int SpecialtyBewrite { get; set; }
    }
}
