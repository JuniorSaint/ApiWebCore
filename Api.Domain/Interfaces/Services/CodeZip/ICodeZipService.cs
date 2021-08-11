using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.CodeZip;

namespace Api.Domain.Interfaces.Services.CodeZip
{
    public interface ICodeZipService
    {
        Task<CodeZipDto> Get(Guid id);
        Task<CodeZipDto> Get(string cep);
        Task<CodeZipDtoCreateResult> Post(CodeZipDtoCreate cep);
        Task<CodeZipDtoUpdateResult> Put(CodeZipDtoUpdate cep);
        Task<bool> Delete(Guid id);
    }
}

