using System.Net.Http.Headers;
using System.Text;

namespace WebAPI.DropBox.Builders
{
    internal class RequestBuilder
    {
        private HttpRequestMessage _request;
        private string _url;
        private string _method;

        public RequestBuilder()
        {
            _request = new HttpRequestMessage();
        }
        public void AddUrl(string url)
        {
            _url = url;
        }
        public void AddMethod(string method)
        {
            _method = method;
        }
        public void AddHeader(string name, string value)
        {
            _request.Headers.Add(name, value);
        }
        public void AddContent(string content)
        {
            _request.Content = new StringContent(content, Encoding.UTF8, "application/json");
        }
        public void AddContent(byte[] content)
        {
            _request.Content = new ByteArrayContent(content);
        }
        public void AddContentType(string contentType)
        {
            _request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
        }
        public HttpRequestMessage Build()
        {
            _request.RequestUri = new Uri(_url);
            _request.Method = new HttpMethod(_method);
            return _request;
        }

    }
}
