using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ASPHomework.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASPNetCoreHomework.Models
{
    public class OrderIndexViewModel
    {
        public Destination Destination { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Od")]
        public DateTime From { get; set; } = DateTime.Now;
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Do")]
        public DateTime To { get; set; } = DateTime.Now;
        
        [Required]
        [Range(1, Double.PositiveInfinity)]
        [DisplayName("Počet osob")]
        public int NumberOfPersons { get; set; }
        
        [Required]
        public int ?DestinationTermId { get; set; }
        
        [Required]
        public DestinationTerm DestinationTerm { get; set; }
        
        [BindNever]
        public List<DestinationTerm> Terms { get; set; } = new List<DestinationTerm>();

        public bool IsFull = false;

        public bool ShowTerms = false;

    }
}