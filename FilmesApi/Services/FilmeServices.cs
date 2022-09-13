using AutoMapper;
using FilmesApi.Data;

namespace FilmesApi.Services
{
    public class FilmeServices
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public FilmeServices(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
