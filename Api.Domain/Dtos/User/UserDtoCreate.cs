using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "Nome é Campo obrigatório")]
        [StringLength(80, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatorio")]
        [EmailAddress(ErrorMessage = "Email esta em formato invalido")]
        [StringLength(120, ErrorMessage = "Email deve ter no maxímo {1} caracteres")]
        public string Email { get; set; }
    }
}
