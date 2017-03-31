using StrategyPatternViaRepository.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternViaRepository.Providers;
using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Providers.Common;

namespace StrategyPatternViaRepository.Infrastructure.Implementations
{
    public sealed class CommonReCheck : IReCheck
    {
        public bool ReCheck(SubscriberParam sp, IProvider provider)
        {
           return provider.DataRepository.IfSubscriberExist(sp);
        }
    }
}
