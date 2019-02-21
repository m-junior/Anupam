using App.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new RestClient($"http://mais.anupam.com.br/api/v1/User/");
            var request = new RestRequest($"?filterList[] % 5B % 5D =internal&select=salutationName%2CfirstName%2ClastName%2Cname%2CuserName%2Ccargo%2CemailAddressIsOptedOut%2CemailAddress%2CemailAddressData%2CaprovaoRH%2CaprovaoGerente%2CdefaultTeamId%2CdefaultTeamName%2CcreatedAt%2CisActive&maxSize=20&offset=0&sortBy=userName&asc=true&where%5B0%5D%5Btype%5D=equals&where%5B0%5D%5Battribute%5D=emailAddress&where%5B0%5D%5Bvalue%5D=nicolas%40enube.me", Method.GET);

            request.AddHeader("authorization", "Basic bmljazoxMjM0NTY=");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var user = GetUserAnupam("nicolas@enube.me");

            var u = JsonConvert.DeserializeObject<ResponseApi>(content);

            var usersToProcess = user;  //u.Result.Where(x => x.avatarId == null).ToList();

            foreach (var item in u.Result)
            {
                if (string.IsNullOrWhiteSpace(item.emailAddress))
                    continue;

                var stream = GetAvatarByUserId(item.emailAddress);

                if (stream.Total > 0 && stream.Result.FirstOrDefault().avatarId != null)
                {
                    //var file = GetFile(stream);
                    //PublishAvatar(stream);
                }

            }

            Console.WriteLine(response.Content);
            
        }


        private static ResponseApi GetUserAnupam(string email)
        {

            var client = new RestClient($"http://mais.anupam.com.br/api/v1/user");
            var request = new RestRequest($"?filterList[]=internal&select=avatarId%2CavatarName%2ClastName%2CfirstName%2Ccargo%2CemailAddressIsOptedOut%2CemailAddress%2CemailAddressData%2CaprovaoGerente%2CaprovaoRH%2CdefaultTeamId%2CdefaultTeamName%2CcreatedAt&maxSize=20&offset=0&sortBy=userName&asc=true&where[0][type]=equals&where[0][attribute]=emailAddress&where[0][value]={email}", Method.GET);
            request.AddHeader("content-type", "application/json");

            request.AddHeader("authorization", "Basic bmljazoxMjM0NTY=");
            request.AddHeader("cache-control", "no-cache");

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<ResponseApi>(response.Content);

        }

        private static ResponseApi GetAvatarByUserId(string email)
            {

                var client = new RestClient($"http://anupam.com.br/rh/api/v1/user");
                var request = new RestRequest($"?filterList[]=internal&select=avatarId%2CavatarName%2ClastName%2CfirstName%2Ccargo%2CemailAddressIsOptedOut%2CemailAddress%2CemailAddressData%2CaprovaoGerente%2CaprovaoRH%2CdefaultTeamId%2CdefaultTeamName%2CcreatedAt&maxSize=20&offset=0&sortBy=userName&asc=true&where[0][type]=equals&where[0][attribute]=emailAddress&where[0][value]={email}", Method.GET);
                request.AddHeader("content-type", "application/json");

                request.AddHeader("authorization", "Basic bmljazoxMjM0NTY=");
                request.AddHeader("cache-control", "no-cache");

                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<ResponseApi>(response.Content);

            }


            private static string PublishAvatar(AttachmentModel stream)
            {
                var json = JsonConvert.SerializeObject(stream);

                var client = new RestClient("http://anupam.com.br/rh/api/v1/Attachment");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", "Basic bmljazEyMzQ1Ng=");
                request.AddHeader("cache-control", "no-cache");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                return response.Content;
            }


        }

    }
