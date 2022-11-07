using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstatePlace.Data;
using RealEstatePlace.ViewModels;
using VotingPoint.Data;
using VotingPoint.Services;

namespace RealEstatePlace.Controllers
{
    public class AppController : Controller
    {
        private readonly IDummyMailService _mailService;
        private readonly IRealEstateRepository _repository;

        public AppController(IDummyMailService mailService, IRealEstateRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                _mailService.SendMesaage("sa6ko9201@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent!";
                ModelState.Clear();
            }

            return View(); 
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        [Authorize]
        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();

            return View(results.ToList());
        }
    }
}
