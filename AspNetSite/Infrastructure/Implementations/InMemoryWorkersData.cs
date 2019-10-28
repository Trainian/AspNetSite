using AspNetSite.Domain.Entities;
using AspNetSite.Domain.Filters;
using AspNetSite.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSite.Infrastructure.Implementations
{
    public class InMemoryWorkersData : IWorkersData
    {
        private readonly IEnumerable<Worker> _workers;
        public InMemoryWorkersData()
        {
            var NewPositionMemory = new InMemoryPositionData();
            var DBPositions = NewPositionMemory.GetPositions();
            _workers = new List<Worker>()
            {
                new Worker()
                {
                    id = 1,
                    Name = "Журавский Никита",
                    position = DBPositions.FirstOrDefault(x => x.id == 1),
                    imgUrl = @"~\img\team-1-1.png",
                    Order = 1,
                    chiefId = null
                },
                new Worker()
                {
                    id = 2,
                    Name = "Горовский Дмитрий",
                    position = DBPositions.FirstOrDefault(x => x.id == 2),
                    imgUrl = @"~\img\team-1-2.png",
                    Order = 2,
                    chiefId = 1
                },
                new Worker()
                {
                    id = 3,
                    Name = "Куртвапов Руслан",
                    position = DBPositions.FirstOrDefault(x => x.id == 2),
                    imgUrl = @"~\img\team-1-3.png",
                    Order = 3,
                    chiefId = 1
                },
                new Worker()
                {
                    id = 4,
                    Name = "Чехирникова Анастасия",
                    position = DBPositions.FirstOrDefault(x => x.id == 2),
                    imgUrl = @"~\img\team-1-4.png",
                    Order = 4,
                    chiefId = 1
                }
            };
        }

        public IEnumerable<Worker> GetWorkers(WorkerFilter filter)
        {
            var workers = _workers;
            if(filter.IdPosition.HasValue)
            {
                workers = workers.Where(p => p.position.id.Equals(filter.IdPosition)).ToList();
            }
            return workers;
        }
    }
}
