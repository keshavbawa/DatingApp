using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BaseApiController : Controller
    {
        private readonly DataContext _context;
        public BaseApiController(DataContext context)
        {
            _context = context;
        }
    }
}

