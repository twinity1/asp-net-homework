using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ASPHomework.Persistence.Entities;

namespace ASPNetCoreHomework.Models
{
    public class OrderFinishViewModel
    {
        public  DestinationTerm DestinationTerm { get; set; }

        [Required(ErrorMessage = "{0} je povinné.")]
        [StringLength(50)]
        [DisplayName("Jméno")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "{0} je povinné.")]
        [StringLength(50)]
        [DisplayName("Příjmení")]
        public string Surname { get; set; }
        
        [Required(ErrorMessage = "{0} je povinný.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "{0} je ve chybném tvaru.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "{0} je povinné.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+([0-9]){3}(\s[0-9]{3}){3}", ErrorMessage = "Zadejte tel. číslo ve tvaru +XXX XXX XXX XXX")]
        [DisplayName("Tel. číslo")]
        public string Phone { get; set; }
        
        [Required]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "{0} musí být minimálně {1}.")]
        [DisplayName("Počet osob")]
        public int NumberOfPersons { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "Maximální délka {0} je {1} znaků.")]
        [DisplayName("Poznámka")]
        public string Note { get; set; }
    }
}