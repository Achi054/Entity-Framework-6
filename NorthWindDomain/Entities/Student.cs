using System.Collections.Generic;

namespace NorthWindDomain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress StudentAddress { get; set; }
        public virtual int? StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Course> courses { get; set; }
    }
}
