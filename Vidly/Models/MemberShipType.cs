using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public short SingupFee { get; set; }
        public byte DurationInMonth  { get; set; }

        public byte DiscoutRate { get; set; }

        public string MembershipType { get; set; }

    }
}