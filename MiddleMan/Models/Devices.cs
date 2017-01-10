using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MiddleMan.Models
{
    [DataContract]
    public class Devices
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public string FriendlyName { get; set; }


       
    }
}