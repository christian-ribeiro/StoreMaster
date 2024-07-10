using Microsoft.AspNetCore.Mvc;
using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
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