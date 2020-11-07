using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Data
{
    public class PhotoRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        public PhotoRepository(DbContext context) : base(context)
        {

        }
    }
}
