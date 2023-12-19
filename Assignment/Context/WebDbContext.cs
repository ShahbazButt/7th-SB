using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class WebDbContext :DbContext
{
    internal IEnumerable<object> Classes;

    public WebDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<WebDbContext> options) : base(options)
    { }

    private DbSet<Class> classes;

    public DbSet<Class> GetClasses()
    {
        return classes;
    }

    public void SetClasses(DbSet<Class> value)
    {
        classes = value;
    }

    public DbSet<Student> Students { get; set; }

    private DbSet<Enrolled> enrolled;

    public DbSet<Enrolled> GetEnrolled()
    {
        return enrolled;
    }

    public void SetEnrolled(DbSet<Enrolled> value)
    {
        enrolled = value;
    }

    public DbSet<Faculty> Faculty { get; set; }

        // Your DbContext configuration code

    public object Enrolled { get; internal set; }
}