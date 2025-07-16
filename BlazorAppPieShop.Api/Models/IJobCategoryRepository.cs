using System.Collections.Generic;
using BlazorAppPieShop.Shared;

namespace BlazorAppPieShop.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
