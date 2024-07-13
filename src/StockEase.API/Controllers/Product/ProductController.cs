using Microsoft.AspNetCore.Mvc;
using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class ProductController(IProductService service, IUserService userService) : BaseController_1<IProductService, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>(service, userService)
    {
        [HttpGet("GetListProductBalance/{productCategoryId}")]
        public async Task<ActionResult<List<OutputProductBalance>>> GetListProductBalance([FromRoute] long productCategoryId)
        {
            try
            {
                return await ResponseAsync(_service.GetListProductBalance(productCategoryId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}