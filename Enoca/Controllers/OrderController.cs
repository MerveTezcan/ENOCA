using ENOCA.APPLICATION.Repositories;
using ENOCA.APPLICATION.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Enoca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        public OrderController(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        /*[HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_orderReadRepository.GetAll());
        }*/
        [HttpPost]
        public async Task<IActionResult> Post(CreateOrder model)
        {
            await _orderWriteRepository.AddAsync(new()
            {
                OrdersName = model.OrdersName,
                Name = model.Name,
                ProductId = model.ProductId,
                CompanyId = model.CompanyId,

            });
            await _orderWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
