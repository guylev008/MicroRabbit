using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Models.DTO;
using MicroRabbit.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransferService _transferService;

        public HomeController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel model)
        {
            var transferDto = new TransferDto
            {
                FromAccount = model.FromAccount,
                ToAccount = model.ToAccount,
                TransferAmount = model.TransferAmount
            };

            await _transferService.Transfer(transferDto);

            return View("Index");
        }
    }
}
