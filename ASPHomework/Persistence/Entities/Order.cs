using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPHomework.Persistence.Entities
{
    public class Order
    {
        public int Id { get; set; }
        
        public virtual DestinationTerm DestinationTerm { get; set; }
        
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        [Required]
        public int NumberOfPersons { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Note { get; set; }
    }
}