using Microsoft.AspNetCore.Mvc;
using System;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using System.Collections.Generic;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IMapper mapper;
        public OrdersController(IOrdersRepository ordersRepository, IMapper mapper)
        {
            this.ordersRepository = ordersRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var orders = ordersRepository.GetAll();
            return View(mapper.Map<List<OrderViewModel>>(orders));
        }
        public IActionResult Order(int orderNumber, Guid orderId)
        {
            ViewBag.Number = orderNumber;
            var order = ordersRepository.TryGetById(orderId);
            return View(mapper.Map<OrderViewModel>(order));
        }
        [HttpPost]
        public IActionResult OrderEditStatus(Guid orderId, OrderStatusesViewModel orderStatus)
        {
            ordersRepository.EditStatus(orderId, (OrderStatuses)orderStatus);
            return RedirectToAction("Index");
        }
    }
}
