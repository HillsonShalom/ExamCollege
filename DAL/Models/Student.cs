using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCollege.DAL.Models
{
    internal class Student
    {
        public int id { get; set; }
        public string name {  get; set; }
        public double owes { get; set; }
        public Student() { }
        public Student(int id, string name, double owes)
        {
            this.id = id;
            this.name = name;
            this.owes = owes;
        }
        public Student( string name, double owes)
        {
            this.name = name;
            this.owes = owes;
        }
    }
}
