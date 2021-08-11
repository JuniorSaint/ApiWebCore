using System;
using Api.Domain.Dtos.City;

namespace Api.Domain.Dtos.CodeZip
{
    public class CodeZipDto
    {
        public Guid Id { get; set; }
        public string ZipCode { get; set; }  
        public string Street { get; set; }       
        public String Number { get; set; }     
        public Guid CityId { get; set; }
        public CityDtoComplete City { get; set; }
       
    }
}
