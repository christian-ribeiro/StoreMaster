using Microsoft.AspNetCore.Mvc;
using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class ProductController(IProductService service, IUserService userService) : BaseController<IProductService, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>(service, userService)
    {
        [HttpPost("GetListProductBalance/{productCategoryId}")]
        public ActionResult<OutputAuthentication> GetListProductBalance([FromRoute] long productCategoryId)
        {
            try
            {
                return Ok(_service.GetListProductBalance(productCategoryId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}