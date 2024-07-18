using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCollege.DAL.Models
{
    internal class Course
    {
        public string name { get; set; }
        public DateOnly starts { get; set; }
        public string ends { get; set; }
        public Days[] days; 

        public Course(string name, DateOnly starts)
        {
            this.name = name;
            this.starts = starts;
        }
        public Course() { }
    }

    internal enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
