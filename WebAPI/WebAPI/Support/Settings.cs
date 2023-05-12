namespace WebAPI.Support
{
    internal class Settings
    {
        public static readonly string BaseUrl = "http://localhost:8080";
        public static readonly string Token = "sl.BeS9y95ZE9K7YrV9RyzDJHULdZMuy1rCwZpA0C6qpQMgAIWtAvZHnVhNO2koBcphQTs3VUkjQ5DstXbCiaTyGT_ScUb3myWEmNNS6isz7Ip7428UQFqp3aEePyZQJJIWm28H9MVK";
        public static readonly string FilePath = @"C:\Users\Vitaliy\Desktop\3_course\SDT\WebAPI\Vitalii_Shvets\WebAPI\WebAPI\Files\file.txt";
        public static readonly string DropBoxFilePath = "/WebAPI/file.txt";
        public static readonly string DropBoxFolder= "/WebAPI";
        public static readonly string FileName = "file.txt";
        public static readonly string UploadUrl = "https://content.dropboxapi.com/2/files/upload";
        public static readonly string GetFileMetadataUrl = "https://api.dropboxapi.com/2/files/get_metadata";
        public static readonly string DeleteUrl = "https://api.dropboxapi.com/2/files/delete_v2";
        public static readonly string IfExistUrl = "https://api.dropboxapi.com/2/files/list_folder";
    }
}
