using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using efcore5_dbfirst_aspnetcore_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace efcore5_dbfirst_aspnetcore_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ContosoUniversityContext db;

        public DepartmentsController(ContosoUniversityContext db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await db.Departments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            return await db.Departments.FirstOrDefaultAsync(p => p.DepartmentId == id);
        }

        [HttpPost("")]
        public async Task<ActionResult<Department>> PostDepartment(Department model)
        {
            db.Departments.Add(model);
            await db.SaveChangesAsync();

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, Department model)
        {
            db.Update(model);
            await db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}/name")]
        public async Task<ActionResult<Department>> PatchDepartmentName(int id, Department model)
        {
            var item = await db.Departments.FirstOrDefaultAsync(p => p.DepartmentId == id);
            item.Name = model.Name;
            await db.SaveChangesAsync();

            return item;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteDepartmentById(int id)
        {
            var item = await db.Departments.FirstOrDefaultAsync(p => p.DepartmentId == id);
            db.Departments.Remove(item);
            await db.SaveChangesAsync();

            return item;
        }
    }
}