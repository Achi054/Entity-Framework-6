using System.Collections.Generic;

namespace NorthWindDomain.Entities
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
