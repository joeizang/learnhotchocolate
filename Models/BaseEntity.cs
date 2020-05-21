using System;
using System.ComponentModel.DataAnnotations;

namespace learnhotchocolate.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTimeOffset.Now.LocalDateTime;
            Id = $"{CreatedAt.Ticks}-{Guid.NewGuid().ToString()}";
        }

        [Key]
        [DataType(DataType.Text)]
        public string Id { get; protected set; }
        public DateTimeOffset CreatedAt { get; protected set; }
        public DateTimeOffset UpdatedAt { get; protected set; }
    }
}