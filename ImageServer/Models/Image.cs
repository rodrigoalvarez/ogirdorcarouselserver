using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageServer.Models
{
    public class ImageData
    {
        public List<Image> data { get; set; }
    }

    public class Image
    {
        public string id { get; set; }
        public string imgBig { get; set; }
        public string imgSmall { get; set; }
    }
}
