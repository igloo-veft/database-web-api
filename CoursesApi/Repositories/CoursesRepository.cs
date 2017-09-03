using System;
using System.Linq;
using System.Collections.Generic;
using CoursesApi.Models.DTOModels;

namespace CoursesApi.Repositories
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly AppDataContext _db;

        public CoursesRepository(AppDataContext db)
        {
            _db = db;
        }

        public IEnumerable<CourseDTO> GetCourses()
        {
            //throw new NotImplementedException();
           /* return new List<CourseDTO>
            {
                new CourseDTO {Id = 1, Name = "Programming"},
                new CourseDTO {Id = 2, Name = "Web Services"}
            };*/
            var courses = (from c in _db.Courses select new CourseDTO
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return courses;
        }
    }
}
