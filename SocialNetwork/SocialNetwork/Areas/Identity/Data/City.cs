using System;
using System.Collections.Generic;

namespace SocialNetwork.Data
{
    public partial class City
    {
        public City()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }

        public Country Country { get; set; }
        public ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
