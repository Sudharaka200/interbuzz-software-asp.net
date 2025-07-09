using Microsoft.AspNetCore.Mvc;

namespace Interbuzz_software.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public IFormFile ProjectImg { get; set; }
        public string ProjectImgPath { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }

    }
}
