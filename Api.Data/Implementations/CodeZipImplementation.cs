using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class CodeZipImplementation : BaseRepository<CodeZipEntity>, ICodeZipRepository
    {

        private DbSet<CodeZipEntity> _dataset;

   
        public CodeZipImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CodeZipEntity>();
        }

        public async Task<CodeZipEntity> SelectAsync(string zipCode)
        {
            return await _dataset.Include(c => c.City)
                                 .ThenInclude(m => m.Uf)
                                 .SingleOrDefaultAsync(u => u.ZipCode.Equals(zipCode));   
        }
    }
}
