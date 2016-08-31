using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LaudaMusicam.Models
{
    public class Address
    {
        public virtual string Name { get; set; }
        public virtual string StreetAddressLine1 { get; set; }
        public virtual string StreetAddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvince { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string Country { get; set; }

        public string GetOneLineUsaAddressString()
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(Name))
            {
                sb.Append(Name);
                sb.Append(", ");
            }

            sb.Append(StreetAddressLine1);
            sb.Append(", ");

            if (!string.IsNullOrEmpty(StreetAddressLine2))
            {
                sb.Append(StreetAddressLine2);
                sb.Append(", ");
            }

            sb.Append(City);
            sb.Append(", ");
            sb.Append(StateProvince);
            sb.Append(" ");
            sb.Append(ZipCode);

            return sb.ToString();
        }
    }
}