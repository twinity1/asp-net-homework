using System;
using System.Collections.Generic;
using System.Linq;
using ASPHomework.Migrations;

namespace ASPHomework.Persistence.Entities
{
    public class DestinationTerm
    {
        public int Id { get; set; }
        
        public DateTime From { get; set; }
        
        public DateTime To { get; set; }
        
        public virtual Destination Destination { get; set; }
        
        public int DestinationId { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }

        public int CountFreeCapacity()
        {
            return Destination.Capacity - Orders.Sum(o => o.NumberOfPersons);
        }
        
    }
}