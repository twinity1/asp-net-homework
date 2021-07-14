using System;
using System.Collections.Generic;
using ASPHomework.Persistence.Entities;

namespace ASPHomework.Persistence.Repositories.Interfaces
{
    public interface IDestinationRepository
    {
        public List<Destination> FindAll();

        public List<Destination> FindAllByDate(DateTime date);
        
        public Destination? FindOneById(int id);
    }
}