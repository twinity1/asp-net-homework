using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPHomework.Persistence.Entities
{
    public class Destination
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; }
        
        public int Capacity { get; set; }
        
        public virtual ICollection<DestinationTerm> DestinationTerms { get; set; }
    }
}