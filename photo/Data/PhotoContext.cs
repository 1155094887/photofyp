using System;
using Microsoft.EntityFrameworkCore;
using photo.Models;

namespace photo.Data
{
    public class PhotoContext : DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> options) : base(options)
        {

        }
        public DbSet<Photo> Photos { get; set; }
    }
}
