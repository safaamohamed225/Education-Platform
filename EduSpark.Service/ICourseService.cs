using EduSpark.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSpark.Service
{
    public interface ICourseService
    {
        Task<List<CourseModel>> GetAllCourses(int? categoryId = null);
        Task<CourseDetailModel> GetCourseDetails(int courseId);
    }
}
