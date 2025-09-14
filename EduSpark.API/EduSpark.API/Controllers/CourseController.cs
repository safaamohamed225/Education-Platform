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
        [HttpGet("")]
        public async Task<ActionResult<List<CourseModel>>> GetAll()
        {
            var result = await _courseService.GetAllCourses();
            return Ok(result);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<List<CourseModel>>> GetAllByCategory([FromRoute] int categoryId)
        {
            var result = await _courseService.GetAllCourses(categoryId);
            return Ok(result);
        }

        [HttpGet("details/{courseId}")]
        public async Task<ActionResult<List<CourseDetailModel>>> GetDetails([FromRoute] int courseId)
        {
            var result = await _courseService.GetCourseDetails(courseId);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
