using Microsoft.EntityFrameworkCore;
using MVClast.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVClast.Context
{


    public class SchoolContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=MVC3;Trusted_Connection=True;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var departments = new List<Department>()
                {
          new Department {  DeptId = 1 , DeptName = "Math" },

          new Department {  DeptId = 2 , DeptName = "Science" },
          new Department {  DeptId = 3 , DeptName = "Arabic" },
          new Department {  DeptId = 4 , DeptName = "English" },
     };

            var students = new List<Student>()
     {
       new Student { Id = 1, Name = "Ahmed Abdallah", Age = 20 , Address = "Ismaillia",DepartmentId = 1 ,Email="Ahmed.1222@example.com", Password="Ahmed1111" },
       new Student { Id = 2, Name = "Ali Ahmed", Age = 16 , Address = "Ismaillia",DepartmentId = 2 ,Email="Ali.1222@example.com", Password="Ali11112" },
        new Student { Id = 3, Name = "Maya", Age = 16 , Address = "Ismaillia", DepartmentId = 3 ,Email="Maya.1222@example.com", Password="Maya111113" },
        new Student { Id = 4, Name = "Omar", Age = 15 , Address = "Ismaillia",DepartmentId = 4 ,Email="Omar.1222@example.com", Password="Omar111123" },
           new Student { Id = 5, Name = "Abdallah", Age = 13 ,Address = "Ismaillia",DepartmentId = 1 ,Email="Abdallah.1222@example.com", Password="Abdallah111112" },
            new Student { Id = 6, Name = "Hatem", Age = 16 , Address = "Ismaillia",DepartmentId = 2,Email= "Hatem.1222@example.com", Password="Hatem111121" },
        new Student { Id = 7, Name = "Wael", Age = 19 , Address = "Ismaillia", DepartmentId = 3 ,Email="Wael.1222@example.com", Password="Wael1111"},
        new Student { Id = 8, Name = "Laila", Age = 18 , Address = "Ismaillia" , DepartmentId = 4 ,Email="Laila1222@example.com", Password="Laila1111"},
        new Student { Id = 9, Name = "Fathy", Age = 16 , Address = "Ismaillia", DepartmentId = 1 ,Email="Fathy.1222@example.com", Password="Fathy1111"},
         new Student { Id = 10, Name = "Osama", Age = 15 , Address = "Ismaillia" , DepartmentId = 2 ,Email="Osama.1222@example.com", Password="OSama1111" },
     };

         modelBuilder
             .Entity<Department>()
             .HasData(departments);

         modelBuilder
             .Entity<Student>()
             .HasData(students);
                    base.OnModelCreating(modelBuilder);
                }





     public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }


    }
}

