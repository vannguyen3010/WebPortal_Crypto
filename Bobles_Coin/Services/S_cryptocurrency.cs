using Bobles_Coin.Lib;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bobles_Coin.Models;

namespace Bobles_Coin.Services

{
    public interface IS_Crypto
    {
        Task<ResponseData<List<M_cryptocurrency>>> getListCryptoCoin(string CMC_PRO_API_KEY);
    }
    public class S_cryptocurrency : IS_Crypto
    {
        private readonly ICallBaseApi _callApi;
        public S_cryptocurrency(ICallBaseApi callApi)
        {
            _callApi = callApi;
        }
        public async Task<ResponseData<List<M_cryptocurrency>>> getListCryptoCoin(string CMC_PRO_API_KEY)
        {
            Dictionary<string, dynamic> dictPars = new Dictionary<string, dynamic>
            {
                  {"CMC_PRO_API_KEY", CMC_PRO_API_KEY},
            };
            return await _callApi.GetResponseDataAsync<List<M_cryptocurrency>>("v1/cryptocurrency/listings/latest", dictPars);
        }
    }
}
