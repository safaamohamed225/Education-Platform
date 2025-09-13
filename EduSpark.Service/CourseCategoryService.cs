using EduSpark.Core.Models;
using EduSpark.Data;
namespace EduSpark.Service
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _categoryRepository;
        public CourseCategoryService(ICourseCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<CourseCategoryModel?> GetByIdAsync(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            if (result == null) 
                return null;

            return new CourseCategoryModel()
            {
                CategoryId = result.CategoryId,
                CategoryName = result.CategoryName,
                Description = result.Description
            };
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategoriesAsync()
        {
            var results = await _categoryRepository.GetCourseCategoriesAsync();
            
            return new List<CourseCategoryModel>(results.Select(result => new CourseCategoryModel()
            {
                CategoryId = result.CategoryId,
                CategoryName = result.CategoryName,
                Description = result.Description
            })).ToList();
        }
    }
}
