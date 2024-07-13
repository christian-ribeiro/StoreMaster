using StockEase.API.Controllers.Base;
using StockEase.Arguments.Arguments;
using StockEase.Domain.Interface.Service;

namespace StockEase.API.Controllers
{
    public class LanguageController(ILanguageService service, IUserService userService) : BaseController_3<ILanguageService, OutputLanguage, InputIdentifierLanguage>(service, userService) { }
}