using System;
namespace Api.Domain.Models
{
    public class UfModel : BaseModel
    {
        private string _sigla;
        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }

        private string _ufName;
        public String UfName
        {
            get { return _ufName; }
            set { _ufName = value; }
        }
    }
}
