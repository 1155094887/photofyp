using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using photo.Data;
using photo.Models;

namespace photo.Controllers
{
    [Route("api/photo")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoController(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        //get all photos
        [HttpGet]
        public ActionResult<IEnumerable<Photo>> GetAllPhotos()
        {
            var all_photo = _photoRepository.GetAllPhotos();
            return Ok(all_photo);
        }
        //get photo by id
        [HttpGet("{id}")]
        public ActionResult<Photo> GetPhotoById(int id)
        {
            var photo = _photoRepository.GetPhotoById(id);
            return photo;
        }
    }
}
