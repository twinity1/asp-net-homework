using System;
using System.Collections.Generic;
using System.Linq;
using ASPHomework.Helpers;
using ASPHomework.Persistence.Entities;

namespace ASPHomework.Persistence.Repositories
{
    public class DestinationTermRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DestinationTermRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public DestinationTerm? FindOneById(int id)
        {
            return _applicationDbContext.DestinationTerms.FirstOrDefault(e => e.Id == id);
        }

        public List<DestinationTerm> FindAvailableTerms(Destination destination, int numberOfPersons, DateTime from, DateTime to)
        {
            if (destination.Capacity < numberOfPersons)
            {
                return new List<DestinationTerm>();
            }
            
            return _applicationDbContext.DestinationTerms
                .Where(q => 
                    q.Destination == destination
                    &&
                    q.From >= from
                    &&
                    q.To <= to
                    && 
                    (q.Orders.Sum(o => o.NumberOfPersons) + numberOfPersons <= destination.Capacity || q.Orders.Any() == false)
                )
                .ToList();
        }

        public bool IsAvailable(DestinationTerm destinationTerm, int numberOfPersons)
        {
            var currentCapacity = destinationTerm.Orders.Where(o => o.DestinationTerm == destinationTerm).Sum(o => o.NumberOfPersons);
            var futureCapacity = currentCapacity + numberOfPersons;
            var maxCapacity = destinationTerm.Destination.Capacity;

            return futureCapacity <= maxCapacity;
        }
    }
}