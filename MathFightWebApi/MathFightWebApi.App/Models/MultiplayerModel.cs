using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MathFightWebApi.App.Models
{
    [DataContract]
    public class MultiplayerModel
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "rating")]
        public int Rating { get; set; }

        [DataMember(Name = "multiplayer")]
        public bool IsInMultiplayer { get; set; }
    }
}