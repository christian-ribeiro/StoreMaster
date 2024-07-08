using StoreMaster.API.Controllers.Base;
using StoreMaster.Arguments.Arguments;
using StoreMaster.Domain.Interface.Service;

namespace StoreMaster.API.Controllers
{
    public class LanguageController(ILanguageService service) : BaseController_2<ILanguageService, OutputLanguage, InputIdentifierLanguage>(service) { }
}