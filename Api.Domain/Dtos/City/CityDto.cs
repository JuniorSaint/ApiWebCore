using System;
namespace Api.Domain.Dtos.City
{
    public class CityDto
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public int CodeIBGE { get; set; }
        public Guid UfId { get; set; }
    }
}
