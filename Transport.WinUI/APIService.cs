using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Transport.Model;
using System.Net;
using Transport.WinUI.Properties;
using System.Windows.Forms;

namespace Transport.WinUI
{
    public class APIService
    {
        public static Model.Administratori LogovaniAdministrator { get; set; }
        private readonly string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
           // return await url.GetJsonAsync<T>();
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
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

    }
}
