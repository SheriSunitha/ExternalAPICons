using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalAPICons.Models
{

    /*    public class JsonRoot
        {
            public string code { get; set; }
            public MetaCust Metacust { get; set; }
            public List<DataCust> Datacust { get; set; }
        }

        public class MetaCust
        {

            public string UserId { get; set; }

            public string UserName { get; set; }

            public string Gender { get; set; }

            public string Status { get; set; }
        }

        public class PaginationCust
        {
            public string UserId { get; set; }

            public string UserName { get; set; }

            public string Gender { get; set; }

            public string Status { get; set; }
        }

        public class DataCust
        {

            public string UserId { get; set; }

            public string UserName { get; set; }

            public string Gender { get; set; }

            public string Status { get; set; }
        }
        public class UsersModel
        {

            public string UserId { get; set; }

            public string UserName { get; set; }

            public string Gender { get; set; }

            public string Status { get; set; }
        }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
 
 */

        public class Root
        {
            public int code { get; set; }
            public Meta meta { get; set; }
            public List<Datum> data { get; set; }
        }

        public class Pagination
        {
            public int total { get; set; }
            public int pages { get; set; }
            public int page { get; set; }
            public int limit { get; set; }
        }

        public class Meta
        {
            public Pagination pagination { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string status { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

}

