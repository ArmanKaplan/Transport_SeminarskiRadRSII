using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transport.MobileAplication;
using Transport.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Transport.MobileApplication
{
  
    public class APIService
    {
        private string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }
      

        public static Model.Klijenti LogovaniKlijent { get; set; }
        public static Model.Vozaci LogovaniVozac { get; set; }

#if DEBUG
        public static string ApiUrl = "http://localhost:5000/api";
#endif
#if RELEASE
        public static string ApiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search, string action = null, bool ignoreErrors = false)
        {
            var url = $"{APIService.ApiUrl}/{_route}";
            if(action != null)
            {
                url += $"/{action}";
            }
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();


            }
            catch(FlurlHttpException ex)
            {
                if (ignoreErrors)
                    return default(T);

                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }

                throw;
            }
            
        }
     

        //public async Task<T> Insert<T>(object request)
        //{
        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //    try
        //    {
        //        return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

        //        var stringBuilder = new StringBuilder();
        //        foreach (var error in errors)
        //        {
        //            stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
        //        }


        //        return default(T);
        //    }

        //}
        public async Task<T> Insert<T>(object request, string actionName = null)
        {
            var url = $"{APIService.ApiUrl}/{_route}";
            if (actionName != null)
                url += $"/{actionName}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default(T);
                }

                var response = await ex.GetResponseJsonAsync<ValidationProblemDetails>();

                var stringBuilder = new StringBuilder();
                foreach (var error in response.Errors)
                {
                    stringBuilder.AppendLine(string.Join(",", error.Value));
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{APIService.ApiUrl}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default(T);
                }

                var response = await ex.GetResponseJsonAsync<ValidationProblemDetails>();

                var stringBuilder = new StringBuilder();
                foreach (var error in response.Errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{APIService.ApiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default(T);
                }

                var response = await ex.GetResponseJsonAsync<ValidationProblemDetails>();

                var stringBuilder = new StringBuilder();
                foreach (var error in response.Errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

    }
}
