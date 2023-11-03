using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using tema_lab4.Data;
using tema_lab4.Models.DTOs;
using tema_lab4.Models.One_to_many;
using tema_lab4.Models.One_to_one;

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

        [HttpGet("GetTeam")]
        public async Task<IActionResult> GetTeam()
        {
            return Ok(await _temaLab4Context.Teams.ToListAsync());
        }

        [HttpPost("CreateTeam")]
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

        [HttpPost("UpdateTeam")]
        public async Task<IActionResult> UpdateTeam(TeamDTO teamDto)
        {
            Team teamById = await _temaLab4Context.Teams.FirstOrDefaultAsync(x =>  x.Id == teamDto.Id);
            if(teamById == null)
            {
                return BadRequest("Team object does not exist");
            }

            teamById.Name = teamDto.Name;
            teamById.FoundedYear = teamDto.FoundedYear;
            teamById.Country = teamDto.Country;

            _temaLab4Context.Update(teamById);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(teamById);
        }

        [HttpGet("GetSponsor")]
        public async Task<IActionResult> GetSponsor()
        {
            return Ok(await _temaLab4Context.Sponsors.ToListAsync());
        }

        [HttpPost("CreateSponsor")]
        public async Task<IActionResult> CreateSponsor(SponsorDTO sponsorDto)
        {
            var newSponsor = new Sponsor
            {
                Id = Guid.NewGuid(),
                Name = sponsorDto.Name,
                Buget = sponsorDto.Buget,
                Country = sponsorDto.Country
            };

            await _temaLab4Context.AddAsync(newSponsor);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(newSponsor);
        }

        [HttpPost("UpdateSponsor")]
        public async Task<IActionResult> UpdateSponsor(SponsorDTO sponsorDto)
        {
            Sponsor sponsorById = await _temaLab4Context.Sponsors.FirstOrDefaultAsync(x => x.Id == sponsorDto.Id);
            if (sponsorById == null)
            {
                return BadRequest("Sponsor object does not exist");
            }

            sponsorById.Name = sponsorDto.Name;
            sponsorById.Buget = sponsorDto.Buget;
            sponsorById.Country = sponsorDto.Country;

            _temaLab4Context.Update(sponsorById);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(sponsorById);
        }

        [HttpGet("GetPilot")]
        public async Task<IActionResult> GetPilot()
        {
            return Ok(await _temaLab4Context.Pilots.ToListAsync());
        }

        [HttpPost("CreatePilot")]
        public async Task<IActionResult> CreatePilot(PilotDTO pilotDto)
        {
            var newPilot = new Pilot
            {
                Id = Guid.NewGuid(),
                Name = pilotDto.Name,
                Age = pilotDto.Age,
                Country = pilotDto.Country
            };

            await _temaLab4Context.AddAsync(newPilot);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(newPilot);
        }

        [HttpPost("UpdatePilot")]
        public async Task<IActionResult> UpdatePilot(PilotDTO pilotDto)
        {
            Pilot pilotById = await _temaLab4Context.Pilots.FirstOrDefaultAsync(x => x.Id == pilotDto.Id);
            if (pilotById == null)
            {
                return BadRequest("Pilot object does not exist");
            }

            pilotById.Name = pilotDto.Name;
            pilotById.Age = pilotDto.Age;
            pilotById.Country = pilotDto.Country;

            _temaLab4Context.Update(pilotById);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(pilotById);
        }

        [HttpGet("GetCar")]
        public async Task<IActionResult> GetCar()
        {
            return Ok(await _temaLab4Context.Cars.ToListAsync());
        }

        [HttpPost("CreateCar")]
        public async Task<IActionResult> CreateCar(CarDTO carDto)
        {
            var newCar = new Car
            {
                Id = Guid.NewGuid(),
                Name = carDto.Name,
                HorsePower = carDto.HorsePower,
                Model = carDto.Model
            };

            await _temaLab4Context.AddAsync(newCar);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(newCar);
        }

        [HttpPost("UpdateCar")]
        public async Task<IActionResult> UpdateCar(CarDTO carDto)
        {
            Car carById = await _temaLab4Context.Cars.FirstOrDefaultAsync(x => x.Id == carDto.Id);
            if (carById == null)
            {
                return BadRequest("Car object does not exist");
            }

            carById.Name = carDto.Name;
            carById.HorsePower = carDto.HorsePower;
            carById.Model = carDto.Model;

            _temaLab4Context.Update(carById);
            await _temaLab4Context.SaveChangesAsync();

            return Ok(carById);
        }
    }
}
