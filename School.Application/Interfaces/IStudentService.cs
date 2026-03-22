using School.Domain.Entities;

namespace School.Application.Interfaces;

public interface IStudentService
{
    Task<List<Student>> GetAllAsync();
    Task<Student> GetByIdAsync(int id);
    Task<Student> CreateAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(int id);
}