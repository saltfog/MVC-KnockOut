using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnockOutSelectors.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            loadHomes();
        }

        public List<HomeForRent> AllItems = new List<HomeForRent>();

        //public HomeForRent Home 
        //{ get; set; }

        private void loadHomes()
        {
            AllItems = new List<HomeForRent>
            {
                new HomeForRent{State = "CT", City = "New Haven", Zip = "06510", Address = "1045 Porch Street", HomeType = "House", BRs = 4},
                new HomeForRent{State = "DE", City = "Wilmington", Zip = "19801", Address = "2301 Kerry Road", HomeType = "House", BRs = 3},
                new HomeForRent{State = "PA", City = "Philadelphia", Zip = "19103", Address = "1040 Porch Street", HomeType = "House", BRs = 3},
                new HomeForRent{State = "NY", City = "New York", Zip = "10016", Address = "9900 Park Avenue Apt. 210", HomeType = "Apartment", BRs = 2},
                new HomeForRent{State = "NY", City = "New York", Zip = "10021", Address = "8403 E. 72nd Street Apt. 106", HomeType = "Apartment", BRs = 2},
                new HomeForRent{State = "NY", City = "New York", Zip = "10028", Address = "7555 Dyslexington Avenue", HomeType = "Condo", BRs = 3},
                new HomeForRent{State = "PA", City = "Philadelphia", Zip = "19119", Address = "10402 Chewout Avenue Apt. 65", HomeType = "Apartment", BRs = 3},
                new HomeForRent{State = "PA", City = "Philadelphia", Zip = "19116", Address = "564 Hustletowne Street", HomeType = "House", BRs = 4},
                new HomeForRent{State = "PA", City = "Reading", Zip = "19609", Address = "42 Pennsy Avenue", HomeType = "Apartment", BRs = 3},
                new HomeForRent{State = "PA", City = "West Chester", Zip = "19381", Address = "2343 Railroad Drive", HomeType = "House", BRs = 3},
                new HomeForRent{State = "PA", City = "West Chester", Zip = "19381", Address = "3828 Winson Street Apt. 113", HomeType = "Apartment", BRs = 2},
                new HomeForRent{State = "CT", City = "New Haven", Zip = "06519", Address = "1112 Boston Post Road", HomeType = "Condo", BRs = 3},
            };
        }
    }

    public class HomeForRent
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int BRs { get; set; }
        public string Address { get; set; }
        public string HomeType { get; set; }
    }
}
