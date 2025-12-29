using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Students_CRUD_WebAPI.Data;
using Students_CRUD_WebAPI.Models;

namespace Students_CRUD_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentModelsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StudentModelsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentModel>>> GetStudentModel()
        {
            return await _context.StudentModel.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentModel>> GetStudentModel(int id)
        {
            var studentModel = await _context.StudentModel.FindAsync(id);
            if (studentModel == null)
                return NotFound();
            return studentModel;
        }

        [HttpPost]
        public async Task<ActionResult<StudentModel>> PostStudentModel(StudentModel studentModel)
        {
            _context.StudentModel.Add(studentModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetStudentModel", new { id = studentModel.Id }, studentModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentModel(int id, StudentModel studentModel)
        {
            if (id != studentModel.Id)
                return BadRequest();

            _context.Entry(studentModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentModel(int id)
        {
            var studentModel = await _context.StudentModel.FindAsync(id);
            if (studentModel == null)
                return NotFound();

            _context.StudentModel.Remove(studentModel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}
