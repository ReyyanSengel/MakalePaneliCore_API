using AutoMapper;
using BusinessLayer.Abstract;
using Entity_Layer.DTOs;
using Entity_Layer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakalePaneliCore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var product = _productService.GetAll();
            var productDto = _mapper.Map<List<ProductDTO>>(product.ToList());
            return Ok(productDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product!=null)
            {
                var productDto = _mapper.Map<ProductDTO>(product);
                return Ok(productDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProdutc(ProductDTO productDto)
        {
            var added = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var addedDto = _mapper.Map<ProductDTO>(added);
            return Created("", addedDto);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDTO productDTO)
        {
            _productService.Update(_mapper.Map<Product>(productDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
           var deleted= await _productService.GetByIdAsync(id);
            if (deleted!=null)
            {
                _productService.Delete(deleted);
                return Ok();
            }
            else
            {
                return NotFound();
            }
           
        }
            

    }

}
