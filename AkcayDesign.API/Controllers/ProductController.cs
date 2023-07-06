using AkcayDesign.API.DTOs.Product;
using AkcayDesign.API.ResponseMessages;
using BusinessLogicLayer.DTOs.Product;
using BusinessLogicLayer.Repositories.Abstract;
using BusinessLogicLayer.Repositories.Concrete;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkcayDesign.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("Get-All-Product")]
        public async Task<IActionResult> GetAllProduct()
        {
            List<Product> products = await _productRepository.GetAllAsync(true);
            if (products is null)
                return BadRequest(new Messages() { message = "Process Unsuccesfully", isSuccess = false });
            return Ok(products);
        }

        [HttpGet]
        [Route("Get-Product-By-Guid")]
        public async Task<IActionResult> GetProductByGuid([FromHeader] Guid id)
        {
            Product product = await _productRepository.GetByGuidAsync(id);
            if (product is null)
                return BadRequest(new Messages() { message = "Process Unsuccesfully", isSuccess = false });
            return Ok(product);
        }

        [HttpPost]
        [Route("Add-Product")]
        public async Task<IActionResult> AddProduct([FromBody] AddProductDto addProductDto)
        {
            Product product = new() { Name = addProductDto.Name };
            bool result = await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
            if (result)
                return Ok(new Messages() { isSuccess = true, message = "Product Added is Successfully", Time = DateTime.Now });
            return BadRequest(new Messages() { isSuccess = false, message = "Product Added is Unsuccessfully", Time = DateTime.Now });
        }

        [HttpDelete]
        [Route("Delete-Product")]
        public async Task<IActionResult> DeleteProduct([FromHeader] Guid id)
        {
            bool result = await _productRepository.DeleteAsync(id);
            await _productRepository.SaveChangesAsync();
            if (result)
                return Ok(new Messages() { isSuccess = true, message = "Product Deleted is Successfully", Time = DateTime.Now });
            return BadRequest(new Messages() { isSuccess = false, message = "Product Deleted is Unuccessfully", Time = DateTime.Now });
        }

        [HttpPut]
        [Route("Updated-Product")]
        public async Task<IActionResult> UpdatedProduct([FromBody] UpdateProduct updateProduct)
        {
            Product product = new() { Name = updateProduct.Name, Id = updateProduct.Id };
            bool result = _productRepository.Update(product);
            if (result)
                return Ok(new Messages() { isSuccess = true, message = "Product Updated is Successfully", Time = DateTime.Now });
            return BadRequest(new Messages() { isSuccess = false, message = "Product Updated is Unuccessfully", Time = DateTime.Now });
        }
    }
}
