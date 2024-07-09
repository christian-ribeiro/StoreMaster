using Microsoft.AspNetCore.Mvc;
using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class ProductController(IProductService service, IUserService userService) : BaseController_1<IProductService, OutputProduct, InputIdentifierProduct, InputCreateProduct, InputUpdateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>(service, userService)
    {
        [HttpPost("GetListProductStockByProductCategoryId/{productCategoryId}")]
        public ActionResult<OutputAuthentication> GetListProductStockByProductCategoryId([FromRoute] long productCategoryId)
        {
            try
            {
                return Ok(_service.GetListProductStockByProductCategoryId(productCategoryId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}