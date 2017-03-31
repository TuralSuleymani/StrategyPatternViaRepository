using StrategyPatternViaRepository.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.App_Data
{
   public interface IDataRepository
    {
       void AddSubscriber(Subscriber sb);
       void RemoveSubscriber(Subscriber sb);
        List<Subscriber> GetSubscribers();
        Subscriber GetSubscriber(SubscriberParam sp);
        bool IfSubscriberExist(SubscriberParam sp);


    }
}
