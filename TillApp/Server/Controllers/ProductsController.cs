using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApp.Server.Data;
using TillApp.Shared.Models;

namespace TillApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> Get()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
