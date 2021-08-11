using System;
namespace Api.Domain.Models
{
    public class CityModel
    {
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private int _codeIBGE;
        public int CodeIBGE
        {
            get { return _codeIBGE; }
            set { _codeIBGE = value; }
        }

        private Guid _ufId;
        public Guid UfId
        {
            get { return _ufId; }
            set { _ufId = value; }
        }

    }
}