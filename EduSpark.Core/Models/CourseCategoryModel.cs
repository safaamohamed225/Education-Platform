using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSpark.Core.Models
{
    public class CourseCategoryModel
    {
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; } = null!;

        [StringLength(250)]
        public string? Description { get; set; }
    }
}
