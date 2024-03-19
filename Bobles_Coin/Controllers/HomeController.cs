using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Bobles_Coin.Lib;
using Bobles_Coin.Models;
using Bobles_Coin.Services;

namespace Bobles_Coin.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        private readonly IS_Crypto _s_crypto;

        public HomeController(IS_Crypto crypto)
        {
            _s_crypto = crypto;
        }

        public async Task<ActionResult> Index()
        {
            await GetListCryptoCoin();
            return View();
        }
        public async Task<ActionResult> GetListCryptoCoin()
        {
            var res = await _s_crypto.getListCryptoCoin(CommonConstants.ID_ACCOUNT);
            ViewBag.CryptoCoin = res.data;
           
            return View();
        }
    }   
}
