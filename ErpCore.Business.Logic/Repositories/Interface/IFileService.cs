using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IFileService
    {
        public string SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
        public string GetFullImageUrl(string imageUrl);
    }
}
