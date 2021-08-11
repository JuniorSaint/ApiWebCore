using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class CodeZipEntity : BaseEntity
    {
        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(80)]
        public string Street { get; set; }

        [MaxLength(10)]
        public String Number { get; set; }

        [Required]
        public Guid CityId { get; set; }

        public CityEntity City { get; set; }
    }
}
