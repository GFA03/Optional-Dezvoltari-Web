using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using tema_lab4.Data;
using tema_lab4.Models.DTOs;
using tema_lab4.Models.One_to_many;

namespace tema_lab4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly TemaLab4Context _temaLab4Context;

        public DatabaseController(TemaLab4Context temaLab4Context)
        {
            _temaLab4Context = temaLab4Context;
        }

        [HttpGet("Get Team")]
        public async Task<IActionResult> GetTeam()
        {
            return Ok(await _temaLab4Context.Teams.ToListAsync());
        }

        [HttpPost("Create Team")]
        public async Task<IActionResult> CreateTeam(TeamDTO teamDto)
        {
            var newTeam = new Team
            {
                Id = Guid.NewGuid(),
                Name = teamDto.Name,
                FoundedYear = teamDto.FoundedYear,
                Country = teamDto.Country
            };

            await _temaLab4Context.AddAsync(newTeam);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(newTeam);
        }
    }
}
