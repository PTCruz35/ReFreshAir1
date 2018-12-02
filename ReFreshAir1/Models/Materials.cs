using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class Material
    {
        public bool dropoff { get; set; }
        public string description { get; set; }
        public bool business { get; set; }
        public string url { get; set; }
        public bool residential { get; set; }
        public string notes { get; set; }
        public string residential_method { get; set; }
        public string business_method { get; set; }
        public int material_id { get; set; }
        public bool pickup { get; set; }
        public string pending { get; set; }

    }

    public class RootObject
    {
        public string search_time { get; set; }
        public int num_results { get; set; }
        public Result result { get; set; }
    }


    public class Result

    {
        //[JsonProperty("location_id")]
        //  public  Dictionary<string, ResultsModel> location_id{ get; set; }
        public ResultsModel resultModel { get; set; }

    }

    public class ResultsModel
    {
        public bool national { get; set; }
        public DateTime updated { get; set; }
        public string postal_code { get; set; }
        public int location_type_id { get; set; }
        public bool municipal { get; set; }
        public string city { get; set; }
        public bool event_only { get; set; }
        public double latitude { get; set; }
        public string province { get; set; }
        public string fax { get; set; }
        public string description { get; set; }
        public bool curbside { get; set; }
        public string hours { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string notes_public { get; set; }
        public DateTime created { get; set; }
        public string url { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public double longitude { get; set; }
        public bool geocoded { get; set; }
        public List<Material> materials { get; set; }
        public string notes { get; set; }
    }

}
