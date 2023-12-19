using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Student
    {
        public int sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public string Standing{ get; set; }
        // Other student properties

        // Navigation property for Enrolled classes
        public ICollection<Enrolled> EnrolledClasses { get; set; }
    }
}
