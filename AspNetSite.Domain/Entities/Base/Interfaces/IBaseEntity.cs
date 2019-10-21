using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetSite.Domain.Entities.Base.Interfaces
{
    public interface IBaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        int id { get; set; }
    }
}
