using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Models
{
    public class Comment
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
