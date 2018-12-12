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
using Newtonsoft.Json.Linq;

namespace ReFreshAir1.Controllers
{
    public class EarthController : Controller
    {
        string apiKey = "7dc47976bbffdd76";
        //  public string baseURL = "http://api.earth911.com/";
        // public string apiKey = "7dc47976bbffdd76";
        // GET: Earth
        public ActionResult Index()
        {

            return View();
        }

        public string GetGeoInfo(string zipCode)
        {
            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getPostalData?api_key=" + apiKey + "&country=" + "US" + "&postal_code=" + zipCode) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    GeoResult info = JsonConvert.DeserializeObject<GeoResult>(apiResponse);
                    var lat = info.result.latitude;
                    var lon = info.result.longitude;
                    return lat + ":" + lon;
                }
            }
            catch
            {
                return "The information you requested is unavailable.";
            }
        }

        [HttpPost]
        public ActionResult FindLocations(IEnumerable<ResultSet> ResultSet, string zipCode)
        {
            string temp = GetGeoInfo(zipCode);
            string[] tempo = temp.Split(':');
            double lat = Convert.ToDouble(tempo[0]);
            double lon = Convert.ToDouble(tempo[1]);
            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.searchLocations?api_key=" + apiKey + "&latitude=" + lat + "&longitude=" + lon) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    var info = JsonConvert.DeserializeObject<ResultSet>(apiResponse);
                    List<Location> locations = info.result;
                    ViewData["locations"] = locations;
                    return View("FindLocations", locations.ToList());
                }
            }
            catch
            {
                return View();
            }
        }

        //             [HttpPost]
        public ActionResult LocationDetails(IEnumerable<RootObject> RootObject, string location_id)
        {
            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getLocationDetails?api_key=" + apiKey + "&location_id=" + location_id) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    var jObject = JObject.Parse(apiResponse);
                    var rawData = jObject["result"][location_id];
                    var info = JsonConvert.DeserializeObject<LocationDetail>(rawData.ToString());
                    return View("LocationDetails", info);
                }
            }
             catch
            {
                return View();
            }
        }

        //  [HttpPost]
        public ActionResult FindMaterials(IEnumerable<MaterialResult> MaterialResult)
        {
            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getMaterials?api_key=" + apiKey) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    var info = JsonConvert.DeserializeObject<MaterialResult>(apiResponse);
                    List<MaterialDescription> materials = info.result;
                    ViewData["materials"] = materials;
                    System.Diagnostics.Debug.WriteLine("LIst - " + materials);
                    return View("FindMaterials", materials.ToList());
                }
            }
            catch
            {
                return View();
            }
        }
    }
}


