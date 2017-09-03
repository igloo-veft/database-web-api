using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursesApi.Services;
using CoursesApi.Models.EntityModels;

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
        public IActionResult GetCourseById(int id)
        {
            var course = _coursesService.GetCourseById(id);
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
        public IActionResult UpdateCourse(int id, [FromBody]Course course)
        {
            return Ok();
        }

        // DELETE api/courses/1
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            return Ok();
        }

        // GET api/courses/1/students
        [HttpGet]
        [Route("{id}/students")]
        public IActionResult GetStudentsInCourse(int id)
        {
            var studentlist = _coursesService.GetStudentsInCourse(id);
            return Ok(studentlist);
        }

        // POST api/courses/1/students
        [HttpPost]
        [Route("{id}/students")]
        public IActionResult AddStudentToCourse(int id, [FromBody]Student student)
        {
            return Ok();
        }
    }
}
