using AspNetSite.Domain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetSite.Domain.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public int id { get; set; }
    }
}
