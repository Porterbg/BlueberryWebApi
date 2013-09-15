using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MathFightWebApi.App.Models
{
    [DataContract]
    public class ProblemModel
    {
        [DataMember(Name = "id")]
        public string Username { get; set; }

        [DataMember(Name = "question")]
        public string AuthCode { get; set; }

        [DataMember(Name = "answer")]
        public string Email { get; set; }

        [DataMember(Name = "difficulty")]
        public string Rating { get; set; }
    }
}