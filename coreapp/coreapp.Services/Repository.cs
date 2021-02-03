using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using coreapp.Services;

namespace coreapp.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(string apiName);
        T GetUser(string apiName, int id);
        T UpdateUser(string apiName, T updatedobj);
    }
    public class Repository<T> : IRepository<T>
    {
        //private List<Applicant> applcants;
        private IAPIRepository APIRepository;
        public Repository(IAPIRepository aPIRepository)
        {
            this.APIRepository = aPIRepository;
        }
        IEnumerable<T> IRepository<T>.GetAll(string apiName)
        {
            IEnumerable<T> obj = null;
            using (var client = new HttpClient())
            {
                HttpResponseMessage responsePostMethod = APIRepository.GetRequest("api/" + apiName, new object());
                if (responsePostMethod.IsSuccessStatusCode)
                {
                    var result = responsePostMethod.Content.ReadAsAsync<IList<T>>().Result;
                    obj = result;
                }
                else //web api sent error response 
                {
                    obj = Enumerable.Empty<T>();
                }
            }

            return obj.ToList();
        }


        T IRepository<T>.GetUser(string apiName, int id)
        {
            T obj;
            using (var client = new HttpClient())
            {
                HttpResponseMessage responsePostMethod = APIRepository.GetRequest("api/" + apiName + "/" + id, new object());
                if (responsePostMethod.IsSuccessStatusCode)
                {
                    var result = responsePostMethod.Content.ReadAsAsync<T>().Result;
                    obj = result;
                }
                else //web api sent error response 
                {
                    obj = default(T);
                }
            }
            return obj;
        }

        T IRepository<T>.UpdateUser(string apiName, T updatedUser)
        {
            HttpResponseMessage responsePostMethod = null;
            T obj;
            using (var client = new HttpClient())
            {
                if ((int)Utility.GetPropertyValue(updatedUser, "Id") == 0)
                {
                    responsePostMethod = APIRepository.PostRequest("api/" + apiName, updatedUser);
                }
                else
                {
                    responsePostMethod = APIRepository.PutRequest("api/" + apiName, updatedUser);
                }

                if (responsePostMethod.IsSuccessStatusCode)
                {
                    var result = responsePostMethod.Content.ReadAsAsync<T>().Result;
                    obj = result;
                }
                else //web api sent error response 
                {
                    obj = default(T);
                }
            }
            return obj;
            //return apiRepository.UpdateApplicantList(updatedApplicant);
        }
    }
}
