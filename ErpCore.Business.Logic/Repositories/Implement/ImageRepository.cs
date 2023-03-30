using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public partial class ImageRepository : Repository<ImageProduct, ImageModel>, IImageRepository
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        public ImageRepository(ErpDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
