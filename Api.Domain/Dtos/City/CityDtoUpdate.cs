using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.City
{
    public class CityDtoUpdate
    {
        [Required(ErrorMessage = "ID é campo obrigatorio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do Município é campo obrigatorio")]
        [StringLength(80, ErrorMessage = "Tamanho máximo de caracteres {1}")]
        public string CityName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "código do IBGE é inválido")]
        public int CodeIBGE { get; set; }

        [Required(ErrorMessage = "Nome de UF é campo obrigatorio")]
        public Guid UfId { get; set;  }
    }
}