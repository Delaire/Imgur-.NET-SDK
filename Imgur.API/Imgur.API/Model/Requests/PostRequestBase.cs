namespace Imgur.API.Model.Requests
{
    public abstract class PostRequestBase : RequestBase
    {
        /// <summary>
        /// Global Parameter
        /// string get post message To pass
        /// </summary>
        public abstract string CallPostMessage { get; }
    }
}