using photo.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Models
{
    public class UserDetail
    {
        [Required]
        public string Name { get; set; }

        public List<Photo> PhotoList { get; set; }
    }
}
