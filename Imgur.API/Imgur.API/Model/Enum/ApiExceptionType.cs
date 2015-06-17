namespace Imgur.API.Model
{
    /// <summary>
    /// Enumeration of possible API exception types
    /// </summary>
    public enum ApiExceptionType
    {
        NotInitialized,
        UnexpectedError,
        ServerError,
        InvalidServerResponse,
        NoServerResponse,
        InvalidUserAgent,
        NotAuthorized,
        Inv
    }
}