using Realty.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realty.Domain.Model
{
    public class ContactDetails
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ContactType Type { get; set; }
        public string Value { get; set; }
    }
}
