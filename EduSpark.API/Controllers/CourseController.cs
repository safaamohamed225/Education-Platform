using EduSpark.Core.Entities;
using EduSpark.Core.Models;
using EduSpark.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduSpark.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseModel>>> GetAllCouses()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<List<CourseModel>>> GetCoursesByCategoryId([FromRoute] int categoryId)
        {
            var courses = await _courseService.GetAllCoursesAsync(categoryId);
            return Ok(courses);
        }

        [HttpGet("details/{courseId}")]
        public async Task<ActionResult<CourseDetailModel>> GetCourseDetails([FromRoute] int courseId)
        {
            var course = await _courseService.GetCourseDetailAsync(courseId);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }
    }
}
