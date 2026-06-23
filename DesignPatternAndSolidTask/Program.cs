using DesignPatternAndSolidTask.AbstractFactory;
using DesignPatternAndSolidTask.AdapterPattern;
using DesignPatternAndSolidTask.BuilderPattern;
using DesignPatternAndSolidTask.ChainOfResponsibility;
using DesignPatternAndSolidTask.Decorator;
using DesignPatternAndSolidTask.Enums;
using DesignPatternAndSolidTask.FacadePattern;
using DesignPatternAndSolidTask.FactoryPattern;
using DesignPatternAndSolidTask.Interfaces;
using DesignPatternAndSolidTask.MediatorPattern;
using DesignPatternAndSolidTask.Models;
using DesignPatternAndSolidTask.ObserverPattern;
using DesignPatternAndSolidTask.ProxyPattern;
using DesignPatternAndSolidTask.SingletonPattern;
using DesignPatternAndSolidTask.StrategyPattern;

namespace DesignPatternAndSolidTask
{
    public class Program
    {
        static async Task Main()
        {

            var latte = new Latte();
            var tea = new Tea();
            var espresso=new Espresso();
            var order = new Order();
            order.AddItemToOrder(latte);
            order.AddItemToOrder(tea);
            order.AddItemToOrder(espresso);
            Console.WriteLine($"customer balance {order.Customer.Balance}");
            Console.WriteLine($"order total price {order.TotalPrice}");

            //Creational patterns 

            //Builder
            Console.WriteLine();
            Console.WriteLine("Builder------------------------------------------");
            var coffeeBuilder = new CoffeeBuilder();
            var coffee=new Coffee();
            coffeeBuilder.Build(coffee).WithSize(CoffeeSize.Small).WithMilkType(MilkType.AmericanMilk).WithTemperature(TemperatureType.Hot)
                .AddShot().WithSyrup("syrupFlavor").WithCream(WhippedCreamType.Vanilla);
            
            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine(coffee.Size);
            Console.WriteLine(coffee.WhippedCream);

            var coffee2=new Coffee();
            coffeeBuilder.Build(coffee2).WithSize(CoffeeSize.Large).WithMilkType(MilkType.EuropeanMilk)
                .WithTemperature(TemperatureType.Iced).AddShot().WithSyrup("syrupFlavor").WithCream(WhippedCreamType.Chocolate);
            
            Console.WriteLine(coffee2.Size);
            Console.WriteLine(coffee2.SyrupFlavor);

            //Factory
            Console.WriteLine();
            Console.WriteLine("Factory-----------------------------------------");
            var espressoDrink= new LatteDrink();
            var factoryService = new DrinkServiceFactory();
            factoryService.CreateDrinkFactory(espressoDrink);

            //Abstract factory
            Console.WriteLine();
            Console.WriteLine("Abstract factory--------------------------------");
            var AmericanIngredient=new AmericanIngredientFactory();
            var barista = new Barista(AmericanIngredient);
            barista.Prepare();

            //Singleton
            Console.WriteLine();
            Console.WriteLine("Singleton---------------------------------------");
            Console.WriteLine(ShopConfiguration.GetInstance().Currency);
            Console.WriteLine(ShopConfiguration.GetInstance().TaxRate);
            Console.WriteLine(ShopConfiguration.GetInstance().OpeningHours);
            
            //Structural


            //Decorator
            Console.WriteLine();
            Console.WriteLine("Decorator---------------------------------------");
            var creamDecorator = new CreamDecorator(espresso);
            Console.WriteLine(creamDecorator.GetCost(order,20m));
            Console.WriteLine(creamDecorator.GetDescription("vanillia"));
            Console.WriteLine($"customer balance {order.Customer.Balance}");
            Console.WriteLine($"order total price {order.TotalPrice}");

            //Proxy
            Console.WriteLine();
            Console.WriteLine("Proxy------------------------------------------");
            var proxyImage = new ProxyImage();
            proxyImage.Display();

            //Adapter
            Console.WriteLine();
            Console.WriteLine("Adapter-----------------------------------------");
            var paymentService = new PaymentProcessorService();
            var paymentAdaptor = new PaymentProcessorAdapterForLegacyPayment(paymentService);
            Console.WriteLine(paymentService.MakePayment((double)order.TotalPrice,"12345"));

            //Facade
            Console.WriteLine();
            Console.WriteLine("Facade------------------------------------------");
            var notificationServiceFacade = new NotificationService();
            var paymentServiceFroOrder = new PaymentServiceFacade(paymentAdaptor);
            var inventoryCheck = new InventoryService();
            var newPricingService = new PricingService();
            var orderServiceFacade = new OrderServiceFacade(inventoryCheck, paymentServiceFroOrder, notificationServiceFacade, newPricingService);
            await orderServiceFacade.PlaceOrder(order);
            
            //Behavioral 

            //Observer 
            Console.WriteLine();
            Console.WriteLine("Observer--------------------------------------");
            var customerApp = new CustomerAppObserver();
            var kitchenApp=new KitchenAppObserver();
            var smsService=new SmsServiceObserver();
            var orderSubject = new OrderSubject(order);
            orderSubject.Attach(customerApp);
            orderSubject.SetOrderStatus(OrderStatus.Ready);
            orderSubject.Detach(customerApp);
            orderSubject.Attach(kitchenApp);
            orderSubject.SetOrderStatus(OrderStatus.Preparing);
            orderSubject.Detach(kitchenApp);
            orderSubject.Attach(smsService);
            orderSubject.SetOrderStatus(OrderStatus.Received);

            //Mediator
            Console.WriteLine();
            Console.WriteLine("Mediator---------------------------------------");
            var concreteMediator = new ConcreteMediator();
            var cashierStation = new CashierStation(concreteMediator);
            var pickupCounter=new PickupCounterStation(concreteMediator);
            var baristaStation =new BaristaStation(concreteMediator);
            cashierStation.Send("coffee is ready");
            pickupCounter.Send("coffee is good");

            //Strategy 
            Console.WriteLine();
            Console.WriteLine("Strategy----------------------------------------");
            var pricingService = new PricingService();
            pricingService.DiscountType = DiscountType.None;
            pricingService.ApplyPayment(order);
            Console.WriteLine($"customer balance {order.Customer.Balance}");
            Console.WriteLine($"order total price {order.TotalPrice}");

            //Chain of responsibility
            Console.WriteLine();
            Console.WriteLine("chain of responsibility-----------------------------");
            var orderStockValidator = new OrderStockValidator();
            var ageRestrictValidator=new AgeRestrictedValidator();
            var customerPaymentValidator= new CustomerPaymentValidator();
            ageRestrictValidator.SetNext(customerPaymentValidator).SetNext(orderStockValidator);
            ageRestrictValidator.HandleOrder(order);
            Console.WriteLine($"customer balance {order.Customer.Balance}");
            Console.WriteLine($"order total price {order.TotalPrice}");

        }
    }
}