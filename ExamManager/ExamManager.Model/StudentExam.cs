using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamManager.Model
{
    public class StudentExam
    {
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        public int LessonID { get; set; }
        public float PeacetimeExam { get; set; }
        public float PeacetimePercentage { get; set; }
        public float ExperimentExam { get; set; }
        public float ExperimentPercentage { get; set; }
        public float LastExam { get; set; }
        public float LastPercentage { get; set; }
        public int AllExam { get; set; }
        public string TermName { get; set; }

    }
}
