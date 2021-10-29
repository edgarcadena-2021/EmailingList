using EmailingList.Application.Interfaces;
using EmailingList.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmailingList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailListController : ControllerBase
    {
        private readonly IEmailListService _emailListService;

        public EmailListController(IEmailListService emailListService)
        {
            _emailListService = emailListService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] EmailListViewModel emailList)
        {
            _emailListService.Create(emailList);
            return Ok(emailList);
        }

        [HttpGet]
        public  IEnumerable<EmailListViewModel> GetAll()
        {
            return _emailListService.GetEmailList();
        }
    }
}
