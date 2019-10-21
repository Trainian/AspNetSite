using AspNetSite.Domain.Entities;
using AspNetSite.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSite.Infrastructure.Implementations
{
    public class InMemoryPositionData : IPositionData
    {
        private readonly List<Position> _position;

        public InMemoryPositionData()
        {
            _position = new List<Position>()
            {
                new Position()
                {
                    id = 1,
                    Name = "Заведующий склада",
                    Order = 1
                },
                new Position()
                {
                    id = 2,
                    Name = "Оператор",
                    Order = 2
                },
                new Position()
                {
                    id = 3,
                    Name = "Кладовщик",
                    Order = 3
                },
                new Position()
                {
                    id = 4,
                    Name = "Сборщик-комплектовщик",
                    Order = 4
                }
            };
        }
        public IEnumerable<Position> GetPositions()
        {
            return _position;
        }
    }
}
