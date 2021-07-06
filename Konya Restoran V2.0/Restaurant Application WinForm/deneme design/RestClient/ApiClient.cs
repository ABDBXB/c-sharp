using deneme_design.Context;
using deneme_design.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace deneme_design
{
    public enum LoginStatus
    {
        SUCCESS,
        FAIL,
        UP_ERROR   
    }
    class ApiClient

    {
        public static readonly string BASE_URL = "http://localhost:7080/api/v1/";
        public static Employee employeeProfile;
        public Employee employee { get; set; }

        public ApiClient(Employee employee)
        {
            this.employee = employee;
        }
        public ApiClient() { }

        public string PostMethodTable(string url, TableContext tableContext)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(tableContext));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                //connection error
                return "-1";
            }
            return result;
        }

        public string PostMethodFoodItemPortionContext(string url, List<FoodItem_PortionContext> context)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(context));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                //connection error
                return "-1";
            }
            return result;
        }

        public LoginStatus login()
        {          
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + "login/");
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(this.employee));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                // connection error
                return LoginStatus.FAIL;
            }
            this.employee = JsonConvert.DeserializeObject<Employee>(result);
            if (this.employee != null)
            {
                employeeProfile = this.employee;
                return LoginStatus.SUCCESS;
            }
            return LoginStatus.UP_ERROR;
        }

        public async Task<long> UploadImage(Image image, string imageName)
        {
            string result = string.Empty;
            var http = new HttpClient();
            byte[] bytefile = ConvertImageToBinary(image);
            var content = new MultipartFormDataContent();
            var imageContent = new StreamContent(new MemoryStream(bytefile));
            content.Add(imageContent, "file", imageName);
            var response = http.PostAsync("http://localhost:7080/api/v1/image/", content);
            result = await response.Result.Content.ReadAsStringAsync();

            return long.Parse(result);
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public string GetRequest(string url)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Get.ToString();
            try
            {
                // body kısmına yazdır
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            catch (Exception)
            {
                // connection error
                return "Connection Error";
            }

            if (result != null)
                return result; 
            return null;
        }

        public string PutRequestFoodItem(string url, ItemContext foodOrderContext)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Put.ToString();
            request.ContentType = "application/json";

            try
            {
                if (foodOrderContext != null)
                {
                    StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                    swJson.Write(JsonConvert.SerializeObject(foodOrderContext));
                    swJson.Close();
                }
                // body kısmına yazdır
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            catch (Exception)
            {
                // connection error
                return "Connection Error";
            }

            if (result != null)
                return result;
            return null;
        }

        public string PutRequest(string url, FoodOrderContext foodOrderContext)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Put.ToString();
            request.ContentType = "application/json";

            try
            {
                if (foodOrderContext != null)
                {
                    StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                    swJson.Write(JsonConvert.SerializeObject(foodOrderContext));
                    swJson.Close();
                }
                // body kısmına yazdır
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            catch (Exception)
            {
                // connection error
                return "Connection Error";
            }
            if (result != null)
                return result;

            return null;
        }

        public string PutRequestEmployee(string url, Employee employee)
        {
            string result = string.Empty;

            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Put.ToString();
            request.ContentType = "application/json";

            try
            {
                if (employee != null)
                {
                    StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                    swJson.Write(JsonConvert.SerializeObject(employee));
                    swJson.Close();
                }
                // body kısmına yazdır
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            catch (Exception)
            {
                // connection error
                return "Connection Error";
            }
            if (result != null)
                return result;

            return null;
        }

        public string PostMethod(string url, FoodOrderContext foodOrderContext)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";

            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(foodOrderContext));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                 //connection error
                return "-1";
            }
            return result;
        }

        public string PostMethodEmployee(string url, Employee employee)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(employee));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                //connection error
                return "-1";
            }
            return result;
        }

        public string PostMethodfood(string url, FoodItemContext foodOrderContext)
        {
            string result = string.Empty;
            // httpreq oluştur
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            try
            {
                // body kısmına yazdır
                StreamWriter swJson = new StreamWriter(request.GetRequestStream());
                swJson.Write(JsonConvert.SerializeObject(foodOrderContext));
                swJson.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                //connection error
                return "-1";
            }
            return result;
        }
        public string DeleteRequest(string url)
        {
            string result = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + url);
            request.Method = HttpMethod.Delete.ToString();
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                return "-1";
            }
            if (result != null)
                return result;
            return null;
        }
    }
}
