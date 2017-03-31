using StrategyPatternViaRepository.App_Data;
using StrategyPatternViaRepository.Providers.Spesific;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternViaRepository.Infrastructure.Implementations;
using StrategyPatternViaRepository.Providers;
namespace StrategyPatternViaRepository
{
    class Program
    {
        static void Main(string[] args)
        {


            BakcellProvider bakcell = new BakcellProvider(DynamicDataRepository.GetRepository());
            
            bakcell.SetReCheckBehaviour(new NoReCheck());
            bakcell.SetRePayBehaviour(new CommonRePay());

            Subscriber sb = new Providers.Subscriber()
            {
                FIO = "Suleymani Tural Fayyaz",
                PassportNumber = "AZE134532",
                RegisterDate = DateTime.Now,
                SubscriberId = 1,
                SubscriberParam = new Providers.SubscriberParam()
                {
                    Balance = 9
                }

            };
            sb.SubscriberParam.Parameters.Add("privateKey", "@#$EWD#$%$4rfe44");

            bakcell.Register(sb);

            Console.WriteLine(bakcell.Check(sb.SubscriberParam).SubscriberParam.Balance);

            bakcell.Pay(sb.SubscriberParam, 45);

            Console.WriteLine(bakcell.Check(sb.SubscriberParam).SubscriberParam.Balance);

            bakcell.RePay(sb.SubscriberParam, 45);

            Console.WriteLine(bakcell.Check(sb.SubscriberParam).SubscriberParam.Balance);
            Console.ReadLine();
        }
    }


 
}
