using Microsoft.AspNetCore.Mvc;
using Project2.Models;

namespace Project2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : Controller
{

  private static List<Employee> _employees = new List<Employee>();

  [HttpGet]
  public ActionResult<IEnumerable<Employee>> GetAll() => Ok(_employees);

  [HttpGet("{id}")]
  public ActionResult<Employee> GetById(int id)
  {
    var employee = _employees.First(e => e.Id == id);

    if (employee == null) return NotFound();

    return Ok(employee);
  }

  [HttpPost]
  public ActionResult<Employee> Create([FromBody] Employee newEmployee)
  {
    newEmployee.Id = _employees.Count + 1;

    _employees.Add(newEmployee);

    return CreatedAtAction(nameof(GetById), new {id = newEmployee.Id}, newEmployee);
  }

  [HttpPut("{id}")]
  public IActionResult Update(int id, [FromBody] Employee updatedEmployee)
  {
    var employee = _employees.First(e => e.Id == id);

    if (employee == null) return NotFound();

    employee.FullName = updatedEmployee.FullName;
    employee.Department = updatedEmployee.Department;
    employee.Salary = updatedEmployee.Salary;

    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var employee = _employees.First(e => e.Id == id);

    if (employee == null) return NotFound();

    _employees.Remove(employee);

    return NoContent();
  }
}
