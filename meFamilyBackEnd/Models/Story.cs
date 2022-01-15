using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace meFamilyBackEnd.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
    }
}
