using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using System.Net.Http.Headers;
using System.Text;
using WebAPI.DropBox.Builders;

namespace WebAPI.DropBox.Impl
{
    public class WebApiClientImpl: IWebApiClient
    {
        private readonly HttpClient _httpClient;
        private static WebApiClientImpl? _webApiClient = null;

        private WebApiClientImpl()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.Token);
        }

        public static WebApiClientImpl GetWebApiClient()
        {
            if (_webApiClient == null)
            {
                _webApiClient = new WebApiClientImpl();
            }
            return _webApiClient;
        }

        public HttpResponseMessage Upload(string filePath, string dropBoxPath)
        {
            RequestBuilder requestBuilder = new RequestBuilder();
            requestBuilder.AddUrl(Settings.UploadUrl);
            requestBuilder.AddMethod("POST");
            requestBuilder.AddHeader("Dropbox-API-Arg", $"{{\"autorename\":false,\"mode\":\"overwrite\",\"mute\":false,\"path\":\"{dropBoxPath}\",\"strict_conflict\":false}}");
            requestBuilder.AddContent(File.ReadAllBytes(filePath));
            requestBuilder.AddContentType("application/octet-stream");
            HttpRequestMessage request = requestBuilder.Build();
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public HttpResponseMessage GetMetaData(string dropBoxPath)
        {
            RequestBuilder requestBuilder = new RequestBuilder();
            requestBuilder.AddUrl(Settings.GetFileMetadataUrl);
            requestBuilder.AddMethod("POST");
            requestBuilder.AddContent($"{{\"path\":\"{dropBoxPath}\"}}");
            requestBuilder.AddContentType("application/json");
            HttpRequestMessage request = requestBuilder.Build();
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public HttpResponseMessage Delete(string dropBoxPath)
        {
            RequestBuilder requestBuilder = new RequestBuilder();
            requestBuilder.AddUrl(Settings.DeleteUrl);
            requestBuilder.AddMethod("POST");
            requestBuilder.AddContent($"{{\"path\":\"{dropBoxPath}\"}}");
            requestBuilder.AddContentType("application/json");
            HttpRequestMessage request = requestBuilder.Build();
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public bool IfExist(string dropBoxFolder, string fileName)
        {
            RequestBuilder requestBuilder = new RequestBuilder();
            requestBuilder.AddUrl(Settings.IfExistUrl);
            requestBuilder.AddMethod("POST");
            requestBuilder.AddContent($"{{\"path\":\"{dropBoxFolder}\"}}");
            requestBuilder.AddContentType("application/json");
            HttpRequestMessage request = requestBuilder.Build();
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response.Content.ReadAsStringAsync().Result.Contains("file.txt");
        }
    }
}
