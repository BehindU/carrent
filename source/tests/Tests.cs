namespace CarRent.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tests
    {
        [Fact]
        public void Foo()
        {
            var g = new MyGraph();
            g.MyEvent += G_MyEvent;
            g.MyEvent += G_MyEvent;
            g.Foo();
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
}
