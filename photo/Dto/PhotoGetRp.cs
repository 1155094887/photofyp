﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Dto
{
    public class PhotoGetRp
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public double Rating { get; set; }
    }
}
