using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Domain.Entities.EntityBase
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreateTime = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
