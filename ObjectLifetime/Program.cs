using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); // 在Car类中创建新实例myCar
            
            
            /*
            myCar.Make = "OldMobile"; // 将这些代码注释后，由于在Car类中已经内置了构造函数，因此不需要我们在类之外对myCar再次设置参数
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */
            Car myOtherCar; // 在Car类中创建新应用(句柄)myOtherCar指向myCar,因为Car中已经有myCar，这一句不需要用new
            myOtherCar = myCar;
            // 注释里的的等效于上面的
            //Car myOtherCar = myCar;

            Console.WriteLine("修改前: " + "{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";       
            Console.WriteLine("修改后: " + "{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.ReadLine();
            // 也可以直接在类中写构造函数
        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() // 构造函数
        {
            // 这样做的目的是平衡新实例，提前获取外部信息，当新实例在外部被new出来时，可以立即使用数据
            this.Make = "Nissan";
            Model = "Big";
            Year = 2016;
            Color = "Blue";
        }
    }
}

