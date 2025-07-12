using Microsoft.AspNetCore.Mvc;

namespace Interbuzz_software.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public IFormFile ServiceImgLogo { get; set; }
        public string ServiceImgLogoPath { get; set; }
        public IFormFile ServiceBgImg1 { get; set;  }
        public string ServicebgImg1Path { get; set; }
        public IFormFile ServiceBgimg2 { get; set; }
        public string ServiceBgImg2Path { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { set; get; }

    }
}
