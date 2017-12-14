using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEntity()
        {
            this.CreationDate = DateTime.Now;
        }
    }
}
