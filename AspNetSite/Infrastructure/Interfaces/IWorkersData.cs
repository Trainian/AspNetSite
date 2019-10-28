using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSite.Domain.Entities;
using AspNetSite.Domain.Filters;

namespace AspNetSite.Infrastructure.Interfaces
{
    public interface IWorkersData
    {
        /// <summary>
        /// Список сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<Worker> GetWorkers(WorkerFilter filter);
    }
}
