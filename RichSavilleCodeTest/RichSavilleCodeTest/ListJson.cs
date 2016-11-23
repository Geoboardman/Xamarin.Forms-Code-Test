using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RichSavilleCodeTest
{
    class ListJson
    {
        private const string ApiBaseAddress = "https://facebook.github.io/react-native/movies.json";

        private HttpClient CreateClient()
        {
            var httpClient = new HttpClient
            {

            };

            return httpClient;
        }

        public async Task<RootObject> GetRootObject()
        {
            RootObject root = new RootObject();

            using (var httpClient = CreateClient())
            {
                var json = await httpClient.GetStringAsync(ApiBaseAddress).ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    root = await Task.Run(() =>
                       JsonConvert.DeserializeObject<RootObject>(json)
                    ).ConfigureAwait(false);
                }
            }
            return root;
        }
    }
}
