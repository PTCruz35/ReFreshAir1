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
    public class EarthController : Controller
    {
        //  public string baseURL = "http://api.earth911.com/";
        // public string apiKey = "7dc47976bbffdd76";
        // GET: Earth
        public ActionResult Index()
        {

            return View();
        }

        public string GetGeoInfo(string zipCode)
        {
            string apiKey = "7dc47976bbffdd76";

            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getPostalData?api_key=" + apiKey + "&country=" + "US" + "&postal_code=" + zipCode) as HttpWebRequest;

                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {

                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();

                    // Result info = JsonConvert.DeserializeObject<Result>(apiResponse);
                    GeoResult info = JsonConvert.DeserializeObject<GeoResult>(apiResponse);

                    var lat = info.result.latitude;
                    var lon = info.result.longitude;

                    return lat + ":" + lon;

                }
            }
            catch
            {
                return "Sorry";
            }
        }

        [HttpPost]
        public ActionResult FindLocations(IEnumerable<ResultSet> ResultSet, string zipCode)
        {
            string temp = GetGeoInfo(zipCode);

            System.Diagnostics.Debug.WriteLine("Temp - " + temp);

            string[] tempo = temp.Split(':');
            double lat = Convert.ToDouble(tempo[0]);
            double lon = Convert.ToDouble(tempo[1]);

            string apiKey = "7dc47976bbffdd76";

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
                    //  ViewBag.info = apiResponse;
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

            System.Diagnostics.Debug.WriteLine("Temp - " + location_id);
            string apiKey = "7dc47976bbffdd76";

            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getLocationDetails?api_key=" + apiKey + "&location_id=" + location_id) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();

                    System.Diagnostics.Debug.WriteLine("Result - " + apiResponse);

                    var info = JsonConvert.DeserializeObject<RootObject>(apiResponse);
                    ViewBag.info = info.result.resultModel;

                    //Dim ThisToken as Token = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Token)(JsonString);

                    // List<ResultsModel> teams = new List<ResultsModel>();
                    ///  foreach (var g in teams.results.something)
                    //  {
                    //  }

                    // List<Material> materials = info.result.location_id.materials;
                    // var test = info.result.location_id.;
                    var test = info.result.resultModel;

                    //   ViewData["materials"] = materials;
                    System.Diagnostics.Debug.WriteLine("Test Result - " + test);
                    ViewBag.test = test;
                    return View("LocationDetails");

                }
            }
            /* List<Result> locations = info.result;

             System.Diagnostics.Debug.WriteLine("Materials List - " + locations);

             foreach (var temp2 in locations)
             {
                 System.Diagnostics.Debug.WriteLine("Desc - " + temp2.description);
             }
             ViewData["locations"] = locations;
             return View("FindLocations", locations.ToList());
         }   
       }
       */
            catch
            {
                return View();
            }



        }


        //  [HttpPost]
        public ActionResult FindMaterials(IEnumerable<MaterialResult> MaterialResult)
        {
            string apiKey = "7dc47976bbffdd76";
            try
            {
                HttpWebRequest apiRequest =
                    WebRequest.Create("http://api.earth911.com/earth911.getMaterials?api_key=" + apiKey) as HttpWebRequest;
                string apiResponse = "";
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();

                    System.Diagnostics.Debug.WriteLine("Result - " + apiResponse);

                    var info = JsonConvert.DeserializeObject<MaterialResult>(apiResponse);


                    System.Diagnostics.Debug.WriteLine("API Response - " + apiResponse);
                    System.Diagnostics.Debug.WriteLine("Result set - " + info);
                    System.Diagnostics.Debug.WriteLine("Result set - " + info.search_time);

                    //  ViewBag.materials = material.result;
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



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReFreshAir1.Controllers
{
    public class EarthController : Controller
    {
        // GET: Earth
        public ActionResult Index()
        {
            return View();
        }
    }
}*/
