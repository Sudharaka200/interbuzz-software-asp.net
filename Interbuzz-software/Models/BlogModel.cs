using System.Reflection.Metadata;

namespace Interbuzz_software.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public IFormFile BlogImage { get; set; } 
        public string BlogImagePath { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly Date { get; set; }

    }
}