using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Providers
{
   public class Subscriber
    {
        public int SubscriberId { get; set; }
        public string FIO { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PassportNumber { get; set; }
        public SubscriberParam SubscriberParam { get; set; }
        

    }
}
