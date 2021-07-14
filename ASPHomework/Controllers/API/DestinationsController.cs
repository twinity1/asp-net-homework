using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ASPHomework.Persistence.Repositories;
using ASPHomework.Persistence.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASPHomework.Controllers.API
{
    
    [Route("api/destinations")]
    public class DestinationsController : Controller
    {
        public class DestinationDto
        {
            public int Id { get; set; }
        
            public string Title { get; set; }
        
            public string Description { get; set; }
        
            public int Capacity { get; set; }
            
            public List<DestinationTermDto> DestinationTerms { get; set; }
        }

        public class DestinationTermDto
        {
            public int Id { get; set; }
        
            public DateTime From { get; set; }
        
            public DateTime To { get; set; }
        }
        
        private readonly IDestinationRepository _destinationRepository;
        private readonly IMapper _mapper;

        public DestinationsController(IDestinationRepository destinationRepository, IMapper mapper)
        {
            _destinationRepository = destinationRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(string date)
        {
            if (date == null)
            {
                return BadRequest(new {ErrorMessage = "Date parameter is required." });
            }

            var format = "dd.MM.yyyy";

            try
            {
                var parsedDate = DateTime.ParseExact(date, format, new DateTimeFormatInfo());
                
                var destinations = _destinationRepository.FindAllByDate(parsedDate).Select(destination =>
                {
                        //není optimální, ale funguje to (:
                        destination.DestinationTerms = destination.DestinationTerms.Where(dt => dt.From == parsedDate).ToList();
                        
                        return _mapper.Map<DestinationDto>(destination);
                });

                var result = destinations;
            
                return Ok(result);
            }
            catch (FormatException e)
            {
                return BadRequest(new {ErrorMessage = $"Format of the date must be '{format}'" });
            }
        }
        
        
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var destination = _destinationRepository.FindOneById(id);

            if (destination == null)
            {
                return NotFound();
            }
            
            var result = _mapper.Map<DestinationDto>(destination);
            
            return Ok(result);
        }
    }
}