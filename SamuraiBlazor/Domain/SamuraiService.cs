using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

using System.Threading.Tasks;


namespace SamuraiBlazor.Domain
{
    public class SamuraiService: ISamuraiService
    {
        private readonly HttpClient httpClient;

        public SamuraiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Samurai>> GetSamrai()
        {
            return await httpClient.GetFromJsonAsync<Samurai[]>("api/samurai");
        }
        public async Task<Samurai> GetSamraiById(int id)
        {
            return await httpClient.GetFromJsonAsync<Samurai>("api/samurai/"+ id);
        }
    }
}
