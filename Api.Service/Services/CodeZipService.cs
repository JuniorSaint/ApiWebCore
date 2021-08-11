using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.CodeZip;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.CodeZip;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class CodeZipService : ICodeZipService
    {
        private ICodeZipRepository _repository;
        private readonly IMapper _mapper;
        public CodeZipService(ICodeZipRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CodeZipDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CodeZipDto>(entity);
        }

        public async Task<CodeZipDto> Get(string cep)
        {
            var entity = await _repository.SelectAsync(cep);
            return _mapper.Map<CodeZipDto>(entity);
        }

        public async Task<CodeZipDtoCreateResult> Post(CodeZipDtoCreate cep)
        {
            var model = _mapper.Map<CodeZipModel>(cep);
            var entity = _mapper.Map<CodeZipEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<CodeZipDtoCreateResult>(result);
        }

        public async Task<CodeZipDtoUpdateResult> Put(CodeZipDtoUpdate cep)
        {
            var model = _mapper.Map<CodeZipModel>(cep);
            var entity = _mapper.Map<CodeZipEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<CodeZipDtoUpdateResult>(result);
        }
    }
}
