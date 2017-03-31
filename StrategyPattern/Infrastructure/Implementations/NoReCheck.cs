using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternViaRepository.Infrastructure.Interfaces;
using StrategyPatternViaRepository.Providers;
using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Providers.Common;

namespace StrategyPatternViaRepository.Infrastructure.Implementations
{
    public sealed class NoReCheck : IReCheck
    {
        public bool ReCheck(SubscriberParam sp, IProvider provider)
        {
            throw new NotImplementedException("Repay functionality temporarily disabled for this provider");
        }
    }
}
