using AspNetSite.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetSite.Domain.Entities
{
    public class Worker : OrderedEntity
    {
        /// <summary>
        /// Должность
        /// </summary>
        public Position position { get; set; }
        /// <summary>
        /// Ссылка на Фото
        /// </summary>
        public string imgUrl { get; set; }
    }
}
