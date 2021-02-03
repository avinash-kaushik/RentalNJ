using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using coreapp.Models;

namespace coreapp.Services
{
    // Need to Refactor this call with DI
    public interface IAPIRepository
    {
        HttpResponseMessage GetRequest(string RequestURI, object data);
        HttpResponseMessage PostRequest(string RequestURI, object data);
        HttpResponseMessage PutRequest(string RequestURI, object data);
    }
    public class APIRepository: IAPIRepository
    {
        private static IConfiguration Configuration;
        public static string BaseURL = ConfigHelper.AppSetting("BaseURL");
        HttpResponseMessage IAPIRepository.GetRequest(string RequestURI, object data)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpResponseMessage response = client.GetAsync(RequestURI).Result;
            return response;
        }

        HttpResponseMessage IAPIRepository.PostRequest(string RequestURI, object data)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpResponseMessage response = client.PostAsJsonAsync(RequestURI, data).Result;
            return response;
        }

        HttpResponseMessage IAPIRepository.PutRequest(string RequestURI, object data)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpResponseMessage response = client.PutAsJsonAsync(RequestURI, data).Result;
            return response;
        }
    }
}
