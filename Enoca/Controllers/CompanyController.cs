using ENOCA.APPLICATION.Repositories;
using ENOCA.APPLICATION.ViewModels;
using ENOCA.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Enoca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly private ICompanyReadRepository _companyReadRepository;

        public CompanyController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_companyReadRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCompany model)
        {
            await _companyWriteRepository.AddAsync(new()
            {

                Name = model.Name,
                OrderStatus = model.OrderStatus,
                OrderStartTime = model.OrderStartTime,
                OrderFinishTime = model.OrderFinishTime,


            });
            await _companyWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCompany model)
        {
            Company company = await _companyReadRepository.GetByIdAsync(model.Id);
            company.OrderStatus = model.OrderStatus;
            company.OrderStartTime = model.OrderStartTime;
            company.OrderFinishTime = model.OrderFinishTime;
            await _companyWriteRepository.SaveAsync();
            return Ok();
        }

    }
}
