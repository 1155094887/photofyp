using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace photo.Dto
{
    [JsonObject(MemberSerialization.OptOut)]
    public class UserRt
    {
        public string Name { get; set; }
        public List<PhotoGetRt> Photos { get; set; }
    }
}
