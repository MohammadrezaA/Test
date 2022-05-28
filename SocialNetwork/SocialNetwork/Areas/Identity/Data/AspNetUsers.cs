using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SocialNetwork.Data;

namespace SocialNetwork.Data
{
    // Add profile data for application users by adding properties to the SocialNetworkUser class
    public class AspNetUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? ActiveAccount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? GenderId { get; set; }
        public byte[] ProfileImage { get; set; }
        public int? CityId { get; set; }
        public string About { get; set; }

        public City City { get; set; }
        public Gender Gender { get; set; }
    }
}
