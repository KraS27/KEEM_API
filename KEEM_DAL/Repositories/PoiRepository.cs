using KEEM_DAL.Interfaces;
using KEEM_Models.Tables;

namespace KEEM_DAL.Repositories
{
    public class PoiRepository : IBaseRepository<Poi>
    {
        private readonly AppDbContext _appDbContext;

        public PoiRepository(AppDbContext db)
        {
            _appDbContext = db;
        }

        public Task Create(Poi entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Poi entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Poi> GetAll()
        {
            return _appDbContext.Pois;
        }

        public Task<Poi> Update(Poi entity)
        {
            throw new NotImplementedException();
        }
    }
}
