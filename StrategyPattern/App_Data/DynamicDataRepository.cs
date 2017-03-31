using StrategyPatternViaRepository.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.App_Data
{
    /// <summary>
    /// DataRepository...simplified
    /// Using as Database for Providers
    /// </summary>
   public sealed class DynamicDataRepository:IDataRepository
    {
        private DynamicDataRepository() { }

        private static DynamicDataRepository _dataRepo;

        private List<Subscriber> subscribers;

        public static DynamicDataRepository GetRepository()
        {
            if (_dataRepo == null)
            {
                _dataRepo = new App_Data.DynamicDataRepository();
                _dataRepo.subscribers = new List<Subscriber>();
            }
            return _dataRepo;
        }

        public void AddSubscriber(Subscriber sb)
        {
            if(!subscribers.Contains(sb))
            subscribers.Add(sb);
        }

        public void RemoveSubscriber(Subscriber sb)
        {
            if(subscribers.Contains(sb))
            subscribers.Remove(sb);
        }

        public List<Subscriber> GetSubscribers()
        {
            return this.subscribers;
        }

        public Subscriber GetSubscriber(SubscriberParam sp)
        {
            return this.subscribers.Where(x => x.SubscriberParam == sp).FirstOrDefault();
        }

        public bool IfSubscriberExist(SubscriberParam sp)
        {
            return (this.GetSubscriber(sp) != null);
        }
    }
}
