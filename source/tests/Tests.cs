namespace CarRent.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarRent.Car.Domain;

    public class Tests
    {
        [Fact]
        public void CarDomain()
        {
            var car1 = new Car();
            var car2 = new Car();
        }

        private void G_MyEvent()
        {
            Console.WriteLine("Hallo");
        }
    }

    public class MyGraph
    {
        public event Action MyEvent;

        public void Foo()
        {
            MyEvent();

            var list = MyEvent.GetInvocationList();
            foreach (Delegate? item in list)
            {
                item.DynamicInvoke();
            }
        }
    }


    public class Register
    {
        private Sale _currentSale;

        public void Pay()
        {
            _currentSale.Pay();
        }
    }


    public class Sale
    {
        private readonly List<SaleLineItem> _saleLineItems;

        public IReadOnlyList<SaleLineItem> SaleLineItems => _saleLineItems;

        public Payment Payment { get; private set; }

        public void CreateSaleLineItem(int quatity, ProductSpec spec)
        {
            _saleLineItems.Add(new SaleLineItem(/* 7, xxx */));
        }

        public void Pay()
        {
            Payment = new Payment();
        }
        
    }
}
