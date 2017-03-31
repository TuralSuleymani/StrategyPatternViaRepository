using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Providers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Providers.Spesific
{
   internal class BakcellProvider : Provider
    {
        public BakcellProvider(IDataRepository repository) : base(repository) { }

        public override bool Pay(SubscriberParam sp,decimal amount)
        {
            if (_datarepo.IfSubscriberExist(sp))
            {
                _datarepo.GetSubscriber(sp).SubscriberParam.Balance += amount;
                return true;
            }
            else
                return false;
        }
    }

}
