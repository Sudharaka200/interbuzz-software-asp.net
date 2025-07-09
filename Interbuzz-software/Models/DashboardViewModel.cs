namespace Interbuzz_software.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<BlogModel> Blogs { get; set; }
        public IEnumerable<ServiceModel> Services { get; set; }
        public IEnumerable<ProjectModel> Projects { get; set; }
    }
}
