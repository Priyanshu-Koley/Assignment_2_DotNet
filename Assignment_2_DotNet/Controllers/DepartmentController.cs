using Assignment_2_DotNet.Data;
using Assignment_2_DotNet.Entities.Dtos;
using Assignment_2_DotNet.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public DepartmentController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Get all departments
    [HttpGet]
    public async Task<IActionResult> GetAllDepartmentsAsync()
    {
        var departments = await _context.Departments.ToListAsync();
        return Ok(departments);
    }

    // Create a department
    [HttpPost]
    public async Task<ActionResult<DepartmentDto>> CreateDepartmentAsync(DepartmentDto departmentDto)
    {
        try
        {
            var department = _mapper.Map<Department>(departmentDto);

            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return Ok(department);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Update a department by Id
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDepartmentByIdAsync(Guid id, DepartmentDto departmentDto)
    {

        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        _mapper.Map(departmentDto, department);

        _context.Entry(department).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            
           throw;
        }

        return Ok(department);
    }

    // Delete a department by Id
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDepartmentByIdAsync(Guid id)
    {
        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();

        return Ok(department);
    }

}
