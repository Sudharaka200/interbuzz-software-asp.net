using Microsoft.AspNetCore.Mvc;

namespace Interbuzz_software.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public IFormFile ServiceImg { get; set; }
        public string ServiceImgPath { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { set; get; }

    }
}
