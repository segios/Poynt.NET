using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET.Model
{
    public class Hook
    {
        public string ApplicationId { get; set; }

        public List<string> EventTypes { get; set; }

        public string DeliveryUrl { get; set; }

        public string Secret { get; set; }

        public string BusinessId { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Id { get; set; }
        public bool Active { get; set; }
        public List<Link> Links { get; set; }
    }
}
