using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Providers;
using StrategyPatternViaRepository.Providers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Infrastructure.Interfaces
{
   public interface IRePay
    {
        bool RePay(SubscriberParam sb, IProvider provider,decimal amount);
    }
}
