using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Api.Domain.Repository;

namespace Api.Data.Implementations
{
    public class CityImplementation : BaseRepository<CityEntity>, ICityRepository
    {
        private DbSet<CityEntity> _dataset;

        public CityImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CityEntity>();
        }

        public async Task<CityEntity> GetCompleteById(Guid id)
        {
            return await _dataset.Include(m => m.Uf).FirstOrDefaultAsync(m => m.Id.Equals(id));
        }
        public async Task<CityEntity> GetCompleteByIBGE(int codeIBGE)
        {
            return await _dataset.Include(m => m.Uf).FirstOrDefaultAsync(m => m.CodeIBGE.Equals(codeIBGE));
        }

    }

}
