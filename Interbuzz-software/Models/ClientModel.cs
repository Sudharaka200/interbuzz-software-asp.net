using Microsoft.AspNetCore.Mvc;

namespace Interbuzz_software.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public IFormFile ClientProfile { get; set; }
        public string ClientProfilePath { get; set; }
        public string ClientName { get; set; }
        public string ClinetJob { get; set; }
        public string ClientComment { get; set; }
    }
}
