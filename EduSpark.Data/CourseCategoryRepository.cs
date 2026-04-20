using EduSpark.Core.Entities;
using EduSpark.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSpark.Data
{
    public class CourseCategoryRepository(EduSparkDB context) : ICourseCategoryRepository
    {
        private readonly EduSparkDB _context = context;
        public async Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data =  await _context.CourseCategories.FindAsync(id);
            return data;
        }
        public async Task<List<CourseCategory>> GetCourseCategoriesAsync()
        {
            var data = await _context.CourseCategories.ToListAsync();
            return data;
        }
    }
}
