namespace Assignment.Models
{
    public class Enrolled
    {
        public int sid { get; set; } // Student ID
        public int cid { get; set; } // Class ID
                                     // Other enrolled properties

        // Navigation properties
        public Student Student { get; set; }
        public Class Class { get; set; }
    }
}
