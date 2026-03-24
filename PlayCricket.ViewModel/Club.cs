using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class Club
    {
        public int id { get; set; }
        public int clubid { get; set; }
        public string name { get; set; } = string.Empty;
        public string domainname { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
