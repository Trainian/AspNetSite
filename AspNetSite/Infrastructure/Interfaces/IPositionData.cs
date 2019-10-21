using AspNetSite.Domain.Entities;
using System.Collections.Generic;

namespace AspNetSite.Infrastructure.Interfaces
{
    public interface IPositionData
    {
        /// <summary>
        /// Список должностей
        /// </summary>
        /// <returns></returns>
        IEnumerable<Position> GetPositions();
    }
}
