using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Bobles_Coin.Lib;
using Bobles_Coin.Models;
using Bobles_Coin.Services;


namespace Bobles_Coin.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private IMemoryCache memoryCache;

        protected IMemoryCache _memoryCache => memoryCache ?? (memoryCache = HttpContext?.RequestServices.GetService<IMemoryCache>());


        public override void OnActionExecuting(ActionExecutingContext context)
        {
           
          
            base.OnActionExecuting(context);
        }
    }
}
