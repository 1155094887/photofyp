using System;
using System.ComponentModel.DataAnnotations;

namespace photo.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }
        public double Rating { get; set; }
        [Required]
        public int ByUserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
