namespace Assignment.Models
{
    public class Class
    {
        public int cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        // Other class properties

        // Navigation property for Enrolled students
        public ICollection<Enrolled> EnrolledStudents { get; set; }
    }
}
