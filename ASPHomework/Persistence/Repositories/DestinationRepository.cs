using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ASPHomework.Persistence.Entities;
using ASPHomework.Persistence.Repositories.Interfaces;

namespace ASPHomework.Persistence.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private ApplicationDbContext _applicationDbContext;
        
        public DestinationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public List<Destination> FindAll()
        {
            return _applicationDbContext.Destinations.ToList();
        }

        public List<Destination> FindAllByDate(DateTime date)
        {
            return _applicationDbContext.Destinations
                .Where(destination => destination.DestinationTerms.Count(dt => dt.From == date) != 0)
                .ToList();
        }

        public Destination? FindOneById(int id)
        {
            return _applicationDbContext.Destinations.FirstOrDefault(destination => destination.Id == id);
        }
    }
}