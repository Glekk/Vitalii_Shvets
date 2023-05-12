using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System.Net.Http.Headers;
using System.Text;

namespace WebAPI.Drivers
{
    class WebApiDriver
    {
        private readonly HttpClient _httpClient;

        public WebApiDriver()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.Token);
        }

        public HttpResponseMessage Upload(string filePath, string dropBoxPath)
        {
            HttpRequestMessage request = new(HttpMethod.Post, Settings.UploadUrl);
            request.Headers.Add("Dropbox-API-Arg", $"{{\"autorename\":false,\"mode\":\"overwrite\",\"mute\":false,\"path\":\"{dropBoxPath}\",\"strict_conflict\":false}}");
            request.Content = new ByteArrayContent(File.ReadAllBytes(filePath));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public HttpResponseMessage GetMetaData(string dropBoxPath)
        {
            HttpRequestMessage request = new(HttpMethod.Post, Settings.GetFileMetadataUrl);
            request.Content = new StringContent($"{{\"path\":\"{dropBoxPath}\"}}", Encoding.UTF8, "application/json");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public HttpResponseMessage Delete(string dropBoxPath)
        {
            HttpRequestMessage request = new(HttpMethod.Post, Settings.DeleteUrl);
            request.Content = new StringContent($"{{\"path\":\"{dropBoxPath}\"}}", Encoding.UTF8, "application/json");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response;
        }

        public bool IfExist(string dropBoxFolder, string fileName)
        {
            HttpRequestMessage request = new(HttpMethod.Post, Settings.IfExistUrl);
            request.Content = new StringContent($"{{\"path\":\"{dropBoxFolder}\"}}", Encoding.UTF8, "application/json");
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = _httpClient.SendAsync(request).Result;
            return response.Content.ReadAsStringAsync().Result.Contains("file.txt");
        }

        public bool IfExistsLocally(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
