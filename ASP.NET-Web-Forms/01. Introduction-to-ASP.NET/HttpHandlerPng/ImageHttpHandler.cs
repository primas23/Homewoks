using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlerPng
{
    public class ImageHttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            response.ContentType = "text/plain";
            response.Write("This is a image with name: " + context.Request.Url.AbsolutePath.Replace(".img", ".png").Substring(1));
        }

        public bool IsReusable { get; }
    }
}