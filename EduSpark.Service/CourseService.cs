using EduSpark.Core.Models;
using EduSpark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSpark.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<List<CourseModel>> GetAllCourses(int? categoryId = null)
        {
            var result = await _courseRepository.GetAllCoursesAsync(categoryId);

            return result;
        }

        public Task<CourseDetailModel> GetCourseDetails(int courseId)
        {
            var result = _courseRepository.GetCourseDetailsAsync(courseId);
            return result;
        }
    }
}
