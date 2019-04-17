using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly FakeProductRepository _productRepository;

        public ProductController(FakeProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _productRepository.FakeSource;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return _productRepository.FakeSource.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Product value)
        {
            _productRepository.FakeSource.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product value)
        {
            var obj = _productRepository.FakeSource.FirstOrDefault(x => x.Id == id);
            if (obj != null)
                _productRepository.FakeSource[_productRepository.FakeSource.IndexOf(obj)] = value;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var obj = _productRepository.FakeSource.FirstOrDefault(x => x.Id == id);
            if (obj != null)
                _productRepository.FakeSource.Remove(obj);
        }
    }
}
