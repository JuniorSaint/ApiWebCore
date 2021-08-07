using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? UpdateAt { get; set; }
        private DateTime? _createAt;

        public DateTime? CreatedAt{

            get { return _createAt; }

            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime CreateAt { get; set; }
    }
}
