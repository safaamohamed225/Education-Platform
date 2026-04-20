using EduSpark.Core.Entities;
using EduSpark.Core.Models;
using EduSpark.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduSpark.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EduSparkDB _context;
        public CourseRepository(EduSparkDB context)
        {
            _context = context;
        }

        public Task AddCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null)
        {
            var query = _context.Courses
                  .Include(c => c.Category)
                  .AsQueryable();
            if(categoryId.HasValue)
            {
                query = query.Where(c => c.CategoryId == categoryId);
            }

            var courses = await query
                .Select(c => new CourseModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Description = c.Description,
                    Price = c.Price,
                    CourseType = c.CourseType,
                    SeatsAvailable = c.SeatsAvailable,
                    Duration = c.Duration,
                    CategoryId = c.CategoryId,
                    InstructorId = c.InstructorId,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    Category = new CourseCategoryModel
                    {
                        CategoryId = c.Category.CategoryId,
                        CategoryName = c.Category.CategoryName,
                        Description = c.Category.Description
                    },
                    UserRating = new UserRatingModel
                    {
                        CourseId = c.CourseId,
                        AverageRating = c.Reviews.Any() ? Convert.ToDecimal(c.Reviews.Average(r => r.Rating)) : 0,
                        TotalRating = c.Reviews.Count()
                    }
                }).ToListAsync();
            return courses;
        }

        public Task<List<Instructor>> GetAllInstructorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourseByIdAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<CourseDetailModel> GetCourseDetailAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<CourseDetailModel> GetCourseDetailsAsync(int courseId)
        {
          if(courseId <= 0)
            {
                return null!;
            }
            var courseDetails = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.Reviews)
                .Include(c => c.SessionDetails)
                .Where(c => c.CourseId == courseId)
                .Select(c => new CourseDetailModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Description = c.Description,
                    Price = c.Price,
                    CourseType = c.CourseType,
                    SeatsAvailable = c.SeatsAvailable,
                    Duration = c.Duration,
                    CategoryId = c.CategoryId,
                    InstructorId = c.InstructorId,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    Category = new CourseCategoryModel
                    {
                        CategoryId = c.Category.CategoryId,
                        CategoryName = c.Category.CategoryName,
                        Description = c.Category.Description
                    },
                    Reviews = c.Reviews.Select(r => new UserReviewModel
                    {
                        CourseId = r.CourseId,
                        UserName = r.User.DisplayName,
                        Rating = r.Rating,
                        Comments = r.Comments,
                        ReviewDate = r.ReviewDate

                    }).OrderByDescending(o => o.Rating).Take(10).ToList(),
                    SessionDetails = c.SessionDetails.Select(c => new SessionDetailModel
                    {
                        SessionId = c.SessionId,
                        CourseId = c.CourseId,
                        Title = c.Title,
                        Description = c.Description,
                        VideoUrl = c.VideoUrl,
                        VideoOrder = c.VideoOrder
                    }).OrderBy(s => s.VideoOrder).ToList(),
                    UserRating = new UserRatingModel
                    {
                        CourseId = c.CourseId,
                        AverageRating = c.Reviews.Any() ? Convert.ToDecimal(c.Reviews.Average(r => r.Rating)) : 0,
                        TotalRating = c.Reviews.Count()
                    }
                }).FirstOrDefaultAsync();
            return courseDetails!;
        }

        public void RemoveSessionDetail(SessionDetail sessionDetail)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourseThumbnail(string courseThumbnailUrl, int courseId)
        {
            throw new NotImplementedException();
        }
    }     
}

