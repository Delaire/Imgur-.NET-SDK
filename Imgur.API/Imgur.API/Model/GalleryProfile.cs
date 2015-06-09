using System.Collections.Generic;

namespace Imgur.API.Model
{
    public class GalleryProfile
    {
        public int total_gallery_comments { get; set; }
        public int total_gallery_likes { get; set; }
        public int total_gallery_submissions { get; set; }
        public List<Trophy> trophies { get; set; }
    }
}