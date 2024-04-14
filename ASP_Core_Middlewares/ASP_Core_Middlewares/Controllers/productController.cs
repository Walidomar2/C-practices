using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Middlewares.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class productController : ControllerBase
    {
        private readonly IProduct _iproduct;

        public productController(IProduct iproduct)
        {
            _iproduct = iproduct;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _iproduct.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var product = await _iproduct.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productModel = await _iproduct.Create(product);
            return CreatedAtAction(nameof(GetById), new { id = productModel.Id });
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productModel = await _iproduct.Update(id, product);

            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel);

        }

        [HttpDelete]
        [Route("{id:int}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productModel = await _iproduct.Delete(id);

            if(productModel == null)
                return NotFound();

            return Ok(productModel);
        }
    }
}
