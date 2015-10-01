using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Gallery
{
    public class GetGalleryTopicImage : RequestBase
    {
        //Route		https://api.imgur.com/3/topics/{topic_id}/{sort}/{window}/{page}

     
        public string sort { get; set; }
        public string window { get; set; }
        public int page { get; set; }
        public string topic_id { get; set; }

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?q=query",); }
            get { return string.Format("topics/{0}/{1}/{2}/{3}", topic_id, sort, window, page); }
        }
    }
}