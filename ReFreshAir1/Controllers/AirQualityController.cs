
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using JsonConvert = Newtonsoft.Json.JsonConvert;
using System.Collections;
using ReFreshAir1.Models;

namespace ReFreshAir1.Controllers
{
    public class AirQualityController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }

       

 public ActionResult GetPollution(string city)
  {
      string AirAPIKey = "ayhJ37YRgvW73vHgo";





      HttpWebRequest apiRequest =
        WebRequest.Create("http://api.airvisual.com/v2/city?" + "city=" + city + "&state=Michigan" + "&country=USA&" + "key=" + AirAPIKey) as HttpWebRequest;


      string apiResponse = "";
      using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
      {

          StreamReader reader = new StreamReader(response.GetResponseStream());
          apiResponse = reader.ReadToEnd();

          // Result info = JsonConvert.DeserializeObject<Result>(apiResponse);
          AQIFullResult info = JsonConvert.DeserializeObject<AQIFullResult>(apiResponse);

          int AQI = info.Data.Current.Pollution.Aqius;




          return View(info.Data.Current.Pollution);

      }
  }

}

}