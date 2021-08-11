using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.CodeZip
{
    public class CodeZipDtoCreateResult
    {

        public Guid Id { get; set; }

        public string ZipCode { get; set; }


        public string Street { get; set; }


        public String Number { get; set; }


        public Guid CityId { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
