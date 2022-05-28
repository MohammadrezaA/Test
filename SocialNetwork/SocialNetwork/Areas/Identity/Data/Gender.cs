using System;
using System.Collections.Generic;

namespace SocialNetwork.Data
{
    public partial class Gender
    {
        public Gender()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
