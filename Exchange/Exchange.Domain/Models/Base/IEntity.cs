using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.Models.Base
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
