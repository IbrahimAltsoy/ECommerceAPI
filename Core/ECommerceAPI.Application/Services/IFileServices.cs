using Microsoft.AspNetCore.Http;

namespace ECommerceAPI.Application.Services
{
    public interface IFileServices
    {
        Task<List<(string fileName, string path)>> UploadAsync(string filePath, IFormFileCollection files);
   
        Task<bool> CopyFileAsync(string path, IFormFile file);
    }
}
