using School.Application.Interfaces;
using School.Domain.Entities;

namespace School.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    private static List<Student> students = new List<Student>()
    {
        new Student { Id = 1, Name = "Juan", Age = 20 },
        new Student { Id = 2, Name = "Maria", Age = 22 }
    };

    public List<Student> GetAll()
    {
        return students;
    }

    public Student GetById(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public void Add(Student student)
    {
        student.Id = students.Count + 1;
        students.Add(student);
    }
}