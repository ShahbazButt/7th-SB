namespace Assignment.Models
{
    public class Faculty
    {
        public int fid { get; set; }
        public int did { get; set; } // Department ID
                                     // Other faculty properties

        // Navigation property for Enrolled students
        public ICollection<Enrolled> EnrolledStudents { get; set; }
    }
}

