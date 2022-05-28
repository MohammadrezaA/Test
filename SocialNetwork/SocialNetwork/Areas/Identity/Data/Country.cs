using System;
using System.Collections.Generic;

namespace SocialNetwork.Data
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<City> City { get; set; }
    }
}
