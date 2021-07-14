using System;
using System.Collections.Generic;
using ASPHomework.Persistence.Entities;
using ASPNetCoreHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPHomework.Persistence
{
    public class TestDataGenerator
    {
        public void Generate(ModelBuilder modelBuilder)
        {
            var destinations = GetDestinations();

            var id = 1;

            var terms = new List<DestinationTerm>();

            foreach (var destination in destinations)
            {
                foreach (DestinationTerm destinationTerm in GenerateAllTerms())
                {
                    destinationTerm.Id = id;
                    destinationTerm.DestinationId = destination.Id;
                    id += 1;
                    terms.Add(destinationTerm);
                }
            }

            modelBuilder.Entity<Destination>().HasData(destinations);
            modelBuilder.Entity<DestinationTerm>().HasData(terms);
        }

        public static List<Destination> GetDestinations()
        {
            var greece = new Destination()
            {
                Id = 1,
                Title = "Řecko",
                Capacity = 14,
                Description =
                    "V období před řeckým osídlením zde žili Pelasgové (kontinentální Řecko) a Minóané (Kréta a některé ostrovy). Někdy ve 4.–3. tisíciletí před Kristem do Řecka",
            };

            var italy = new Destination()
            {
                Id = 2,
                Title = "Itálie",
                Capacity = 20,
                Description =
                    "Itálie, celým názvem Italská republika (italsky Italia a Repubblica Italiana) je stát ležící v ... K Itálii patří dva velké ostrovy ve Středozemním moři: Sardinie a Sicílie"
            };

            var china =
                new Destination()
                {
                    Id = 3,
                    Title = "Čína",
                    Capacity = 5,
                    Description =
                        "S 1,4 miliardy obyvatel je Čína nejlidnatější zemí světa, rozloha 9,6 milionu km² ji činí čtvrtým největším státem. Díky své rychle rostoucí ekonomice a vojenské síle",
                    
                };
            
            return new List<Destination>() {greece, italy, china};
        }
        
        public List<DestinationTerm> GenerateAllTerms()
        {
            var result = new List<DestinationTerm>();

            var now = DateTime.Now;

            var startMonth = 6;
            var endMoth = 8;
            
            var start = new DateTime(now.Year, startMonth, 1);
            var end = new DateTime(now.Year, endMoth, DateTime.DaysInMonth(now.Year, endMoth));

            var interval = TimeSpan.FromDays(8);
            
            while (start.Add(interval) < end)
            {
                result.Add(new DestinationTerm
                {
                    From = start,
                    To = start.Add(interval)
                }
                );
                start = start.Add(interval);
            }
            
            return result;
        }
    }
}