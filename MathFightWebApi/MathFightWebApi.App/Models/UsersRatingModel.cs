using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MathFightWebApi.App.Models
{
    [DataContract]
    public class UsersRatingModel
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "rating")]
        public int Rating { get; set; }
    }
}