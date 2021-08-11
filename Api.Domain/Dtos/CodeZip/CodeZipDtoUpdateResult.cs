using System;
namespace Api.Domain.Dtos.CodeZip
{
    public class CodeZipDtoUpdateResult
    {
       
        public Guid Id { get; set; }
        
        public string ZipCode { get; set; }
        
        public string Street { get; set; }

        public String Number { get; set; }
        
        public Guid CityId { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
