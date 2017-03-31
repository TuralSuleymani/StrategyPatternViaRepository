using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternViaRepository.Providers.Common
{
   internal abstract class Provider:IProvider
    {
        

        protected IReCheck _reCheck;
        protected IRePay _rePay;
        protected IDataRepository _datarepo;
        public IDataRepository DataRepository
        {
            get
            {
                return _datarepo;
            }
        }

        //Setting dynamicly behaviour from contructor...
        //not suitable for extension...
        //use setterns for extend
        public Provider(IDataRepository repository,IReCheck reCheck,IRePay rePay):this(repository)
        {
            this._reCheck = reCheck;
            this._rePay = rePay;
        }

        //allow setting behaviour via properties..
        public Provider(IDataRepository repository)
        {
            this._datarepo = repository;
        }

        public void SetReCheckBehaviour(IReCheck recheck)
        {
            this._reCheck = recheck;
        }

        public void SetRePayBehaviour(IRePay repay)
        {
            this._rePay = repay;
        }

        public void SetDataRepository(IDataRepository repository)
        {
            this._datarepo = repository;
        }


        /// <summary>
        /// Register subscriber
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Register(Subscriber s)
        {
            _datarepo.AddSubscriber(s);
            return true;
        }

        /// <summary>
        /// UnRegister Subscriber
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool UnRegister(Subscriber s)
        {
            _datarepo.RemoveSubscriber(s);
            return true;
        }

        /// <summary>
        /// Recheck after payment
        /// </summary>
        public void ReCheck(SubscriberParam sp)
        {
            this._reCheck.ReCheck(sp,this);
        }

        /// <summary>
        /// RePay if payment is not successfull
        /// </summary>
        public void RePay(SubscriberParam sp,decimal amount)
        {
            this._rePay.RePay(sp,this, amount);
        }

        /// <summary>
        /// Pay to provider
        /// </summary>
        public abstract bool Pay(SubscriberParam sp,decimal amount);
       

        /// <summary>
        /// Check subsciber existance
        /// </summary>
        public virtual Subscriber Check(SubscriberParam sp)
        {
           return _datarepo.GetSubscriber(sp);
        }
       

    }
}
