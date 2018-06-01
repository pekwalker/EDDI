using Newtonsoft.Json;
using System;
using System.Linq;

namespace EddiDataDefinitions
{
    public class HaulageAmount
    {
        public long id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        [JsonIgnore]
        public bool legal => name.Split('_').ElementAtOrDefault(2)
            .ToLowerInvariant()
            .Contains("illegal") ? false : true;

        public int amount { get; set; }

        public DateTime expiry { get; set; }

        public HaulageAmount() { }

        public HaulageAmount(HaulageAmount HaulageAmount)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.amount = amount;
            this.expiry = expiry;
        }

        public HaulageAmount(long Id, string Name, int Amount, DateTime Expiry)
        {
            this.id = Id;
            this.name = Name;
            this.status = "Active";
            this.amount = Amount;
            this.expiry = Expiry;
        }
    }
}