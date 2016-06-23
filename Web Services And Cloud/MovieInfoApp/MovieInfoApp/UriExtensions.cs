namespace MovieInfoApp
{
    using System;
    using System.Web;

    public static class UriExtensions
    {
        public static Uri AddParameter(this Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);

            if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
            {
                uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + paramName + "=" + paramValue;
            }
            else
            {
                uriBuilder.Query = paramName + "=" + paramValue;
            }

            return uriBuilder.Uri;
        }
    }
}
