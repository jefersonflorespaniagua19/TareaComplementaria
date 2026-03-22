using School.Domain.Entities;

namespace School.Application.Interfaces;

public interface IStudentRepository
{
    List<Student> GetAll();
    Student GetById(int id);
    void Add(Student student);
}