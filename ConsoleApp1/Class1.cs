using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class PublicPhone
        {
            public string PublicPhone1 { get; set; }
        }

        public class WorkingHour
        {
            public string WorkHours { get; set; }
            public string DayWeek { get; set; }
        }

        public class ChiefPhone
        {
            public string ChiefPhone1 { get; set; }
        }

        public class OrgInfo
        {
            public string OGRN { get; set; }
            public string ChiefPosition { get; set; }
            public string INN { get; set; }
            public string KPP { get; set; }
            public string LegalAddress { get; set; }
            public string FullName { get; set; }
            public string ChiefName { get; set; }
            public List<ChiefPhone> ChiefPhone { get; set; }
        }

        public class Availability
        {
            public List<object> available_element { get; set; }
            public string available_o { get; set; }
            public string available_z { get; set; }
            public string available_s { get; set; }
            public string available_k { get; set; }
        }

        public class ObjectAddress
        {
            public List<string> SocialServices { get; set; }
            public string District { get; set; }
            public string Address { get; set; }
            public List<Availability> Availability { get; set; }
            public string PostalCode { get; set; }
            public string AdmArea { get; set; }
        }

        public class GeoData
        {
            public string type { get; set; }
            public List<List<double>> coordinates { get; set; }
        }

        public class Root
        {
            public int global_id { get; set; }
            public string ChiefPosition { get; set; }
            public string ChiefName { get; set; }
            public List<PublicPhone> PublicPhone { get; set; }
            public List<WorkingHour> WorkingHours { get; set; }
            public string ClarificationWorkingHours { get; set; }
            public List<OrgInfo> OrgInfo { get; set; }
            public List<ObjectAddress> ObjectAddress { get; set; }
            public string WebSite { get; set; }
            public string ShortName { get; set; }
            public string FullName { get; set; }
            public string CommonName { get; set; }
            public GeoData geoData { get; set; }
        }

    }
}
