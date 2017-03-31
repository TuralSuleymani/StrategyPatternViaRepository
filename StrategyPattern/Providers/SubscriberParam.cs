using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Providers
{
   public class SubscriberParam
    {
        public decimal Balance { get; set; }
        public Dictionary<string,string> Parameters { get; set; }

        public SubscriberParam()
        {
            Parameters = new Dictionary<string, string>();
        }

        public bool Search(SubscriberParam parameters)
        {
           return Parameters.OrderBy(r => r.Key).
                SequenceEqual(parameters.Parameters.OrderBy(r => r.Key));
        }
    }
}
