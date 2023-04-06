using ErpCore.Business.Logic.Repositories.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _environment;

        public FileService(IWebHostEnvironment env)
        {
            _environment = env;
        }

        public string SaveImage(IFormFile imageFile)
        {
            try
            {
                if (imageFile == null || imageFile.Length == 0 || string.IsNullOrEmpty(imageFile.FileName))
                {
                    return "";
                }
                var path = Path.Combine(this._environment.WebRootPath, "images");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                // Check the allowed extensions
                var ext = Path.GetExtension(imageFile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg" };
                if (!allowedExtensions.Contains(ext))
                    return "";
                string uniqueString = Guid.NewGuid().ToString();
                // we are trying to create a unique filename here
                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(path, newFileName);
                using var stream = new FileStream(fileWithPath, FileMode.Create);
                imageFile.CopyTo(stream);
                return "/images/" + newFileName;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public bool DeleteImage(string imageFileName)
        {
            try
            {
                var wwwPath = this._environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads\\", imageFileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetFilePath(string ProductCode)
        {
            return this._environment.WebRootPath + "\\Uploads\\Product\\" + ProductCode;
        }
       
        public string GetFullImageUrl(string? imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
                return "";
            string hostUrl = "https://localhost:7277/";
            return string.Concat(hostUrl, imageUrl);
        }
    }

}

