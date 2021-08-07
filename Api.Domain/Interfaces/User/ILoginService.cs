using System;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(UserEntity user);
    }
}
