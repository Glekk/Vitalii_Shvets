namespace WebAPI.Support
{
    internal class Settings
    {
        public static readonly string BaseUrl = "http://localhost:8080";
        public static readonly string Token = "sl.Beoi91G87jnBEb695TWcG_fBW2lBDT6L9Z2AuHfotLK4v3V7brjePg1g-ak-M6Em1-FwUo4w7Fh72XCY-bLKEry6vpcltMa-GjUXfUhVOvX-ldiSLKEJCKHG0ZpKfMaqNjVJZ6au";
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
