using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange.Domain.Models.Base
{
    public class SimpleEntity: IEntity
    {

        public Guid Id { get; set; }
    }
}
