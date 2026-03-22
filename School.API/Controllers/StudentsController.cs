using Microsoft.AspNetCore.Mvc;
using School.Application.Interfaces;
using School.Domain.Entities;

namespace School.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentsController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Post(Student student)
        => Ok(await _service.CreateAsync(student));

    [HttpPut]
    public async Task<IActionResult> Put(Student student)
    {
        await _service.UpdateAsync(student);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}