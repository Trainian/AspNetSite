using AspNetSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSite.Models
{
    public class WorkerViewModel : Worker
    {
        /// <summary>
        /// Начальник
        /// </summary>
        public Worker Chief { get; set; }
    }
}
