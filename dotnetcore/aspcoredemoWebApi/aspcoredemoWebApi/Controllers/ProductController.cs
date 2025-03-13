using Microsoft.AspNetCore.Mvc;

using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using aspcoredemoWebApi;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspcoredemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        static List<Products> products = new List<Products>()
        {


            new Products(){productCode=1001,productName="ThinkPad T16 Gen 3",productDescription="Intel® Core™ Ultra 5 125U Processor (E-cores up to 3.60 GHz P-cores up to 4.30 GHz)", productPrice=95489.99m},
            new Products(){productCode=1002,productName="HP Laptop",productDescription="HP 15, 12th Gen Intel Core i5-1235U, 16GB DDR4, 512GB SSD, (Win 11, Office 21, Silver, 1.69kg), Anti-Glare, 15.6-inch(39.6cm) FHD Laptop, Intel Iris Xe Graphics, HD Camera, Backlit Keyboard, fy5009tu", productPrice=52990.99m},
            new Products(){productCode=1003,productName="Dell XPS 13 2-in-1 Laptop",productDescription="Processor: i5-1230U,OS & Office: Win 11 + Office H&S 2021 RAM: 16GB LP DDR4,Storage: 1TB SSD,Graphics: INTEGRATED Display: 13.0″ 3K AR+AS Gorilla Glass 500 nits Touch, XPS Stylus Keyboard: Backlit Keyboard + Fingerprint Reader", productPrice=106500.00m}
        };

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Products? product = products.FirstOrDefault(p => p.productCode == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Products product)
        {
            var maxProductCode = products.Select(p => p.productCode).DefaultIfEmpty(0).Max();
            if (maxProductCode == 0)
            {
                product.productCode = 1001;
            }
            else
            {

                product.productCode = maxProductCode + 1;
            }
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.productCode, product });

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products updateProduct)
        {
            Products? product = products.FirstOrDefault(p => p.productCode == id);
            if (updateProduct == null)
            {
                return BadRequest();

            }
            if (product == null)
            {
                return NotFound();
            }
            else
            {

                product.productName = updateProduct.productName;
                product.productDescription = updateProduct.productDescription;
                product.productPrice = updateProduct.productPrice;

                return NoContent();

            }
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Products? product = products.FirstOrDefault(p => p.productCode == id);
            if (product == null)
            {
                return NotFound();

            }
            else
            {
                products.Remove(product);
                return NoContent();
            }
        }
    }
}
