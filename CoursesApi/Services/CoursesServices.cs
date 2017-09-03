using System.Collections.Generic;
using CoursesApi.Models.DTOModels;
using CoursesApi.Repositories;

namespace CoursesApi.Services
{
	public class CoursesServices : ICoursesService
	{
		private readonly ICoursesRepository _repo;

		public CoursesServices(ICoursesRepository repo)
		{
			_repo = repo;
		}

		public IEnumerable<CourseDTO> GetCourses()
		{
			//throw new System.NotImplementedException();
			var courses = _repo.GetCourses();
			return courses;
		}
	}

}