using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace kaninos.Models
{
    public class CriadorDTO
    {
        public int id_criador { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string logotipo { get; set; }
        public IFormFile logo { get; set; }
        public string fotografia { get; set; }
        public IFormFile foto { get; set; }
    }
}