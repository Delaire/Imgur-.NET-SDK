using Imgur.API.Model.Requests;

namespace Imgur.API.EndPoints.Conversation
{
    public class GetConversation : RequestBase
    {
//Get information about a specific conversation. Includes messages.
//Method	GET
//Route	https://api.imgur.com/3/conversations/{id}/{page}/{offset}
//Response Model	Conversation
//Parameters
//Key	Required	Description
//page	optional	Page of message thread. Starting at 1 for the most recent 25 messages and counting upwards. Defaults to 1
//offset	optional	Additional offset in current page, defaults to 0.

        public string offset { get; set; }
        public string page { get; set; }
        public string id { get; set; }

       

        public override string CallIdentifier
        {
            //get { return string.Format("gallery/{section}/{sort}/{window}/{page}?showViral=bool",); }
            get { return string.Format("conversations/{0}/{1}/{2}", id,page,offset); }
        }
    }
}