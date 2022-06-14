using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SanTsgBootcamp.Application.Interfaces;
using SanTsgBootcamp.Application.Models;
using SanTsgBootcamp.Data;
using SanTsgBootcamp.Data.UnitOfWork;
using SanTsgBootcamp.Domain.Users;

namespace SanTsgBootcamp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailServices _emailServices;


        public UsersController(UserDbContext context, IUnitOfWork unitOfWork, IEmailServices emailServices)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _emailServices = emailServices;
        }

        // GET: Users
        public IActionResult Index()
        {
            var values = _unitOfWork.Users.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
           
          
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            EmailRequest email = new EmailRequest()
            {
                Body = "Kaydiniz basariyla alinmistir",
                Subject = "SanTsgProject Kayit Onayi",
                ToEmail = user.Email
                

            };
            _unitOfWork.Users.Add(user);
            _unitOfWork.Save();
            await _emailServices.SendMailAsync(email);


            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var valeus = _unitOfWork.Users.Find(x => x.Id == id);
            _unitOfWork.Users.Remove(valeus);
            _unitOfWork.Save();
           
            
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var valeus = _unitOfWork.Users.Find(x => x.Id == id);
            
            return View(valeus);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _unitOfWork.Users.Update(user);
            _unitOfWork.Save();
           
            return RedirectToAction("Index");
        }


    }
}
