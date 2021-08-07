﻿using System;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api.Data.Context;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}






