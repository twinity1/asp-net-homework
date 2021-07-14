using System;
using System.Collections.Generic;
using ASPHomework.Persistence.Entities;
using ASPHomework.Persistence.Repositories;
using ASPHomework.Persistence.Repositories.Interfaces;
using ASPNetCoreHomework.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ASPNetCoreHomework.Controllers
{
    public class OrderController : Controller
    {
        private IDestinationRepository _destinationRepository;
        private OrderRepository _orderRepository;
        private DestinationTermRepository _destinationTermRepository;
        private readonly IMapper _mapper;

        public OrderController(IDestinationRepository destinationRepository, OrderRepository orderRepository, DestinationTermRepository destinationTermRepository, IMapper mapper)
        {
            _destinationRepository = destinationRepository;
            _orderRepository = orderRepository;
            _destinationTermRepository = destinationTermRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index(int id, int personNumber = 0, bool full = false)
        {
            var destination = _destinationRepository.FindOneById(id);

            if (destination == null)
            {
                return NotFound();
            }
            
            var order = new OrderIndexViewModel();
            order.NumberOfPersons = personNumber;
            order.IsFull = full;
            order.Destination = destination;
            
            return View(order);
        }
        
        [HttpPost]
        public IActionResult Index(OrderIndexViewModel model, int id)
        {
            var destination = _destinationRepository.FindOneById(id);

            if (destination == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Finish(int destinationTerm, int personNumber)
        {
            var term = _destinationTermRepository.FindOneById(destinationTerm);

            if (term == null || personNumber <= 0)
            {
                return BadRequest();
            }
            
            return View(new OrderFinishViewModel
            {
                DestinationTerm = term,
                NumberOfPersons = personNumber
            });
        }
        
        
        [HttpPost]
        public IActionResult Finish(int destinationTerm, OrderFinishViewModel viewModel)
        {
            var term = _destinationTermRepository.FindOneById(destinationTerm);

            if (term == null)
            {
                return BadRequest();
            }

            viewModel.DestinationTerm = term;
            
            if (ModelState.IsValid)
            {
                try
                {
                    var order = _mapper.Map<Order>(viewModel);

                    _orderRepository.Create(order);

                    return View("Success");
                }
                catch (OrderRepository.DestinationLimitExceededException e)
                {
                    return RedirectToAction("Index", new { id = term.Destination.Id, personNumber = viewModel.NumberOfPersons, full = true});
                }
            }
            
            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult Form(OrderIndexViewModel viewModel, int id)
        {
            var destination = _destinationRepository.FindOneById(id);

            if (destination == null)
            {
                return NotFound();
            }
            
            viewModel.Destination = destination;

            //dynamicky se generuje, takže není třeba jej validovat zatím
            ModelState.Remove(nameof(OrderIndexViewModel.DestinationTermId));
            ModelState.Remove(nameof(OrderIndexViewModel.DestinationTerm));

            if (ModelState.IsValid)
            {
                viewModel.ShowTerms = true;
                viewModel.Terms = _destinationTermRepository.FindAvailableTerms(destination, viewModel.NumberOfPersons, viewModel.From, viewModel.To);
            }
            
            ModelState.Clear();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult NextConfirm(OrderIndexViewModel viewModel, int id)
        {
            var destination = _destinationRepository.FindOneById(id);

            if (destination == null || viewModel.DestinationTermId == null)
            {
                return BadRequest();
            }

            var destinationTerm = _destinationTermRepository.FindOneById((int) viewModel.DestinationTermId);

            if (destinationTerm == null)
            {
                return BadRequest();
            }

            viewModel.DestinationTerm = destinationTerm;
            viewModel.Destination = destination;
            
            ModelState.Clear();
            TryValidateModel(viewModel);
            
            if (ModelState.IsValid)
            {
                return RedirectToAction("Finish", new {destinationTerm = viewModel.DestinationTerm.Id, personNumber = viewModel.NumberOfPersons});
            }

            return View("Index", viewModel);
        }
    }
}