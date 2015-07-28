using System.Collections.Generic;

namespace Imgur.API.Model.Entities
{
    public class DataCaption
    {
        public object image { get; set; }
        public List<Caption> captions { get; set; }
    }
}