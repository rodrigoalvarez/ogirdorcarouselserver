using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        // GET api/images
        [HttpGet]
        public ActionResult<ImageData> Get()
        {
            List<Image> images = new List<Image>();
            images.Add(new Image()
            {
                id = "1",
                imgBig = "https://picsum.photos/id/1/1024/200",
                imgSmall = "https://picsum.photos/id/1/424/306"
            });
            images.Add(new Image()
            {
                id = "2",
                imgBig = "https://picsum.photos/id/2/1024/200",
                imgSmall = "https://picsum.photos/id/2/424/306"
            });
            images.Add(new Image()
            {
                id = "3",
                imgBig = "https://picsum.photos/id/3/1024/200",
                imgSmall = "https://picsum.photos/id/3/424/306"
            });
            images.Add(new Image()
            {
                id = "4",
                imgBig = "https://picsum.photos/id/4/1024/200",
                imgSmall = "https://picsum.photos/id/4/424/306"
            });
            images.Add(new Image()
            {
                id = "5",
                imgBig = "https://picsum.photos/id/5/1024/200",
                imgSmall = "https://picsum.photos/id/5/424/306"
            });
            images.Add(new Image()
            {
                id = "6",
                imgBig = "https://picsum.photos/id/6/1024/200",
                imgSmall = "https://picsum.photos/id/6/424/306"
            });
            return new ImageData() { data = images };
        }

        // GET api/images/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
