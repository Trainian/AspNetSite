﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetSite.Domain.Entities.Base.Interfaces
{
    public interface IOrderedEntity
    {
        /// <summary>
        /// Порядок
        /// </summary>
        int Order { get; set; }
    }
}