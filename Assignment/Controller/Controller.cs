using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Assignment.Controller
{
    public class Controller
    {
        private readonly WebDbContext _context;
        private int id;

        public Controller(WebDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ClassesWithMoreThan100Students()
        {
            var classes = _context.GetClasses()
                .Where(c => _context.GetEnrolled().Count(e => e.cid == c.cid) > 100) // Assuming e.cid represents class id in the Enrolled table
                .Select(c => new { ClassName = c.Name, c.RoomNumber })
                .ToList();

            return View(classes); // Return a view to display this data
        }


        // b. Retrieve the ids and majors of students who take no classes with teachers in department 22.
        [HttpGet]
        public IActionResult StudentsWithNoClassesInDept22()
        {
            var students = _context.Students
                .Where(s => !_context.GetEnrolled().Any(e => e.sid == s.sid && _context.Faculty.Any(t => t.did == 22 && t.fid == e.sid))) // Assuming t.did represents department id in the Faculty table
                .Select(s => new { StudentId = s.sid, s.Major })
                .ToList();

            return View(students); // Return a view to display this data
        }


        private IActionResult View(object students)
        {
            throw new NotImplementedException();
        }
    }
}
