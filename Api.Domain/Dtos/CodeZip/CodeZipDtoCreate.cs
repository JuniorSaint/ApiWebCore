using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.CodeZip
{
    public class CodeZipDtoCreate
    {

        [Required(ErrorMessage = "CEP do Município é campo obrigatorio")]
       
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Rua é campo obrigatorio")]
        public string Street { get; set; }

     
        public String Number { get; set; }

        [Required(ErrorMessage = "Município é campo obrigatorio")]
        public Guid CityId { get; set; }
        
    }
}
