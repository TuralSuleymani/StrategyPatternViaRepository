using StrategyPatternViaRepository.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Providers.Common
{
   public interface IProvider
    {
        IDataRepository DataRepository { get; }
        bool Register(Subscriber s);
       bool UnRegister(Subscriber s);
        Subscriber Check(SubscriberParam sb);
        bool Pay(SubscriberParam sb,decimal amount);
       
    }
}
