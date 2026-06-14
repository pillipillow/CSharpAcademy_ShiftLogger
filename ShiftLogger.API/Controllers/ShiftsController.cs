using Microsoft.AspNetCore.Mvc;
using ShiftLogger.API.Data;
using ShiftLogger.API.Models;

namespace ShiftLogger.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsController : ControllerBase
    {
        private readonly ShiftDbContext dbContext;

        public ShiftsController(ShiftDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllShifts()
        {
            return Ok(dbContext.Shifts.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetShiftbyId(int id)
        {
            var shift = dbContext.Shifts.Find(id);
            if (shift == null)
            {
                return NotFound($"Shift with ID: {id} not found");
            }

            return Ok(shift);
        }

        [HttpPost]
        public IActionResult AddShift(ShiftDto shiftDto) 
        {
            var shift = new Shift()
            {
                StartTime = shiftDto.StartTime,
                EndTime = shiftDto.EndTime,
                Duration = shiftDto.Duration,
            };

            dbContext.Shifts.Add(shift);
            dbContext.SaveChanges();

            return Ok(shift);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShift(int id,ShiftDto shiftDto)
        {
            var shift = dbContext.Shifts.Find(id);
            if (shift == null)
            {
                return NotFound($"Shift with ID: {id} not found");
            }

            shift.StartTime = shiftDto.StartTime;
            shift.EndTime = shiftDto.EndTime;
            shift.Duration = shiftDto.Duration;

            dbContext.SaveChanges();

            return Ok($"Shift with ID: {id} has been updated.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShift(int id) 
        {
            var shift = dbContext.Shifts.Find(id);
            if (shift == null)
            {
                return NotFound($"Shift with ID: {id} not found");
            }

            dbContext.Shifts.Remove(shift);
            dbContext.SaveChanges();

            return Ok($"Shift with ID {id} has been deleted.");
        }

    }
}
