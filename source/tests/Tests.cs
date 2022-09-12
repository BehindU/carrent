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
}
