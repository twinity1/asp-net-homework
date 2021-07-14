using System;
using System.Collections.Generic;
using System.Linq;
using ASPHomework.Helpers;
using ASPHomework.Persistence.Entities;
using ASPNetCoreHomework.Models;

namespace ASPHomework.Persistence.Repositories
{
    public class OrderRepository
    {
        public class DestinationLimitExceededException : Exception { }
        
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly DestinationTermRepository _destinationTermRepository;

        public OrderRepository(ApplicationDbContext applicationDbContext, DestinationTermRepository destinationTermRepository)
        {
            _applicationDbContext = applicationDbContext;
            _destinationTermRepository = destinationTermRepository;
        }
        
        public void Create(Order order)
        {
            if (_destinationTermRepository.IsAvailable(order.DestinationTerm, order.NumberOfPersons) == false)
            {
                throw new DestinationLimitExceededException();
            }
            
            _applicationDbContext.Orders.Add(order);

            _applicationDbContext.SaveChanges();
        }
    }
}