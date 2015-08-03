using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Conversation
{

    public class GetConversationList : RequestBase
    {
//Get list of all conversations for the logged in user.
//Method	GET
//Route	https://api.imgur.com/3/conversations
//Response Model	Array of Conversation

        //public string UserName { get; set; }
        //public string page { get; set; }

       

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("conversations"); }
        }
    }
}
