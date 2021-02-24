using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ICartDetailsRepository _cartRepository;

        // GET: api/<ShoppingCartController>

        public ShoppingCartController(ICartDetailsRepository cartRepository)
        {
            _cartRepository = cartRepository;//why doing this inside a constructor ? the dependency provided inside startup.cs file sends instance of class that needs to be implented which gets assigned to interface reference.
        }

        [HttpGet]
        public IEnumerable<CartDetail> Get()
        {
            return  _cartRepository.GetCartDetails();
        }

        // GET api/<ShoppingCartController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShoppingCartController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShoppingCartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoppingCartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
