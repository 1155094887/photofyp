using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Dto
{
    public class Follow
    {
        [Key]
        public int FollowingId { get; set; }
        [Required]
        public string FollowerName { get; set; }
    }
}
