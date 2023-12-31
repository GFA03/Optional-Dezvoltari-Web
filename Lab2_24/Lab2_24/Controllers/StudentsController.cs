﻿using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21},
            new Student { Id = 2, Name = "Maria", Age = 19},
            new Student { Id = 3, Name = "Vlad", Age = 22},
            new Student { Id = 4, Name = "Florin", Age = 25},
            new Student { Id = 5, Name = "Marian", Age = 20},
        };

        // endpoint 
        // Get 
        [HttpGet]
        public List<Student> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }

        [HttpGet("OrderedByName")]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(o => o.Name).ToList();
        }

        [HttpGet("byId")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("byId/{id}")]
        public Student GetByIdEndpoint(int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("filter/{name}/{age}")]
        public Student GetWithFilters(string name, int age)
        {
            return students.FirstOrDefault(s => s.Name.Equals(name) && s.Age.Equals(age));
        }

        [HttpGet("fromRouteWithId/{id}")]
        public Student GetByIdWithFromRoute([FromRoute] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromHeader")]
        public Student GetByIdWithFromHeader([FromHeader] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromQuery")]
        public Student GetByIdWithFromQuery([FromQuery] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromQueryAsync")]
        public async Task<Student> GetByIdWithFromQueryAsync([FromQuery] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        // Create

        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }

        [HttpPost("fromBody")]
        public IActionResult AddWithFromBody([FromBody] Student student)
        {
            students.Add(student);
            return Ok(students);
        }

        [HttpPost("fromForm")]
        public IActionResult AddWithFromForm([FromForm] Student student)
        {
            students.Add(student);
            return Ok(students);
        }

        // Delete

        [HttpDelete]
        public List<Student> Delete(Student student)
        {
            var studentIndex = students.FindIndex( x => x.Id == student.Id);
            students.RemoveAt(studentIndex);
            return students;
        }

        [HttpDelete("DeleteById")]
        public List<Student> DeleteById(int id)
        {
            // did this because in this stage there is no restriction on multiple students having the same id
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    i = i - 1;
                }
            }
            return students;
        }

        // Update

        //Partial Update
        [HttpPatch]
        public IActionResult Patch([FromRoute] int id, [FromBody] JsonPatchDocument<Student> student) 
        { 
            if(student != null)
            {
                var studentToUpdate = students.FirstOrDefault(s => s.Id.Equals(id));
                student.ApplyTo(studentToUpdate,(Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter) ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else return Ok(students);

            }
            return BadRequest("Object is null");

/*            return NotFound();
            return NoContent();
            return Forbid();*/
        }


    }
}
