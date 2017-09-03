using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursesApi.Services;

namespace API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        private readonly ICoursesService _coursesService;

        public CoursesController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        // GET api/courses
        [HttpGet]
        [Route("")]
        public IActionResult GetCourses()
        {
            var courses = _coursesService.GetCourses();
            return Ok(courses);
        }

        // GET api/courses/1
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _coursesService.GetCourses();
            return Ok(course);
        }

        /*// POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }*/

        // PUT api/courses/1
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/courses/1
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/courses/1/students
        [HttpGet]
        [Route("{id}/students")]

        // POST api/courses/1/students
        [HttpPost]
        [Route("{id}/students")]
    }
}
