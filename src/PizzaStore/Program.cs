using System;
using PizzaStore.Helper;
using PizzaStore.Store;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var pigsCannotFly = true;

            do
            {
                var answerToStore = GetAnswerForStore();
                if (!answerToStore.IsValidAnswer())
                {
                    break;
                }

                var answerToOrder = GetAnswerForOrder();
                if (!answerToOrder.IsValidAnswer())
                {
                    break;
                }
                
                var store = CallStore(answerToStore, answerToOrder);

                Console.WriteLine("placing order...");

                var order = store.OrderPizza(answerToOrder);

                Console.WriteLine(String.Empty);
                Console.WriteLine($"You just ordered : {order.GetDescription()}");
                Console.WriteLine(string.Empty);
                

            } while (pigsCannotFly);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static Store.PizzaStore CallStore(SupportedStoreEnum storeToUse, string order)
        {
            Console.WriteLine("Calling Store....");
            switch (storeToUse)
            {
                case SupportedStoreEnum.NewYork:
                    return new NewYorkPizzaStore();
                case SupportedStoreEnum.Chicago:
                    return new ChicagoPizzaStroe();
                default:
                    throw new NotSupportedException();
            }
        }

        private static string GetAnswerForOrder()
        {
            Console.WriteLine("What do you want to order? 1)Cheese 2)Greek 3) Pepperoni");
            var rawAnswer = Console.ReadLine();

            switch (rawAnswer)
            {
                case "1":
                    return "Cheese";
                case "2":
                    return "Greek";
                case "3":
                    return "Pepperoni";
                default:
                    return rawAnswer;
            }
        }

        private static SupportedStoreEnum GetAnswerForStore()
        {
            Console.WriteLine("What store do you want to order from? 1)NewYork 2)Chicago");
            var rawAnswer = Console.ReadLine();

            switch (rawAnswer)
            {
                case "1":
                    return SupportedStoreEnum.NewYork;
                case "2":
                    return SupportedStoreEnum.Chicago;
                default:
                    return SupportedStoreEnum.UnKnown;
            }
        }
    }
}
