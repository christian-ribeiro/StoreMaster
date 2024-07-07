using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreMaster.Arguments.Arguments.Base;
using StoreMaster.Domain.Interface.Service.Base;

namespace StoreMaster.API.Controllers.Base
{
    [ApiController]
    [Route("/api/[controller]")]
    [Authorize]
    public class BaseController<TService, TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>(TService service) : Controller
        where TService : IBaseService<TOutput, TInputIdentifier, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
        where TOutput : BaseOutput<TOutput>
        where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
        where TInputCreate : BaseInputCreate<TInputCreate>
        where TInputUpdate : BaseInputUpdate<TInputUpdate>
        where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
        where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    {
        private readonly TService _service = service;

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<BaseResponseApi<TOutput>>> Get(long id)
        {
            try
            {
                return await ResponseAsync(_service.Get(id));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPost("GetByIdentifier")]
        public virtual async Task<ActionResult<BaseResponseApi<TOutput>>> GetByIdentifier(TInputIdentifier inputIdentifier)
        {
            try
            {
                return await ResponseAsync(_service.GetByIdentifier(inputIdentifier));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpGet]
        public virtual async Task<ActionResult<BaseResponseApi<List<TOutput>>>> GetAll()
        {
            try
            {
                return await ResponseAsync(_service.GetAll());
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPost("GetListByListIdentifier")]
        public virtual async Task<ActionResult<BaseResponseApi<TOutput>>> GetListByListIdentifier(List<TInputIdentifier> listInputIdentifier)
        {
            try
            {
                return await ResponseAsync(_service.GetListByListIdentifier(listInputIdentifier));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPost("GetListByListId")]
        public virtual async Task<ActionResult<BaseResponseApi<TOutput>>> GetListByListId(List<long> listId)
        {
            try
            {
                return await ResponseAsync(_service.GetListByListId(listId));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPost("Create")]
        public virtual async Task<ActionResult<BaseResponseApi<long>>> Create(TInputCreate inputCreate)
        {
            try
            {
                return await ResponseAsync(_service?.Create(inputCreate), 201);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPost("Create/Multiple")]
        public virtual async Task<ActionResult<BaseResponseApi<List<long>>>> Create(List<TInputCreate> listInputCreate)
        {
            try
            {
                return await ResponseAsync(_service?.Create(listInputCreate), 201);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPut("Update")]
        public virtual async Task<ActionResult<BaseResponseApi<long>>> Update(TInputIdentityUpdate inputIdentityUpdate)
        {
            try
            {
                return await ResponseAsync(_service.Update(inputIdentityUpdate));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpPut("Update/Multiple")]
        public virtual async Task<ActionResult<BaseResponseApi<List<long>>>> Update(List<TInputIdentityUpdate> listInputIdentityUpdate)
        {
            try
            {
                return await ResponseAsync(_service.Update(listInputIdentityUpdate));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpDelete("Delete")]
        public virtual async Task<ActionResult<BaseResponseApi<bool>>> Delete(TInputIdentityDelete inputIdentityDelete)
        {
            try
            {
                return await ResponseAsync(_service?.Delete(inputIdentityDelete));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [HttpDelete("Delete/Multiple")]
        public virtual async Task<ActionResult<BaseResponseApi<bool>>> Delete(List<TInputIdentityDelete> listInputIdentityDelete)
        {
            try
            {
                return await ResponseAsync(_service?.Delete(listInputIdentityDelete));
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [NonAction]
        public async Task<ActionResult> ResponseAsync<ResponseType>(ResponseType result, int statusCode = 0)
        {
            try
            {
                return await Task.FromResult(StatusCode(statusCode == 0 ? 200 : statusCode, new BaseResponseApi<ResponseType> { Result = result }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(BadRequest(new BaseResponseApi<string> { ErrorMessage = $"Houve um problema interno com o servidor. Entre em contato com o Administrador do sistema caso o problema persista. Erro interno: {ex.Message}" }));
            }
        }

        [NonAction]
        public async Task<ActionResult> ResponseExceptionAsync(Exception ex)
        {
            return await Task.FromResult(BadRequest(new BaseResponseApi<string> { ErrorMessage = ex.Message }));
        }
    }

    public class BaseController_1<TService, TOutput, TInputIdentifier, TInputCreate>(TService service) : BaseController<TService, TOutput, TInputIdentifier, TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0>(service)
    where TService : IBaseService_1<TOutput, TInputIdentifier, TInputCreate>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    where TInputCreate : BaseInputCreate<TInputCreate>
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<long>>> Update(BaseInputIdentityUpdate_0 inputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<List<long>>>> Update(List<BaseInputIdentityUpdate_0> listInputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<bool>>> Delete(BaseInputIdentityDelete_0 inputIdentityDelete)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<bool>>> Delete(List<BaseInputIdentityDelete_0> listInputIdentityDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseController_2<TService, TOutput, TInputIdentifier>(TService service) : BaseController<TService, TOutput, TInputIdentifier, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0>(service)
    where TService : IBaseService_2<TOutput, TInputIdentifier>
    where TOutput : BaseOutput<TOutput>
    where TInputIdentifier : BaseInputIdentifier<TInputIdentifier>, new()
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<long>>> Create(BaseInputCreate_0 inputCreate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<List<long>>>> Create(List<BaseInputCreate_0> listInputCreate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<long>>> Update(BaseInputIdentityUpdate_0 inputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<List<long>>>> Update(List<BaseInputIdentityUpdate_0> listInputIdentityUpdate)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<bool>>> Delete(BaseInputIdentityDelete_0 inputIdentityDelete)
        {
            throw new NotImplementedException();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<ActionResult<BaseResponseApi<bool>>> Delete(List<BaseInputIdentityDelete_0> listInputIdentityDelete)
        {
            throw new NotImplementedException();
        }
    }
}