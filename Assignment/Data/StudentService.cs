// StudentService.cs
using Assignment.Models;
using System.Threading.Tasks;

public class StudentService
{
    private readonly WebDbContext _dbContext; 

    public StudentService(WebDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddStudent(Student student)
    {
        _dbContext.Students.Add(student); 
        await _dbContext.SaveChangesAsync();
    }
}
