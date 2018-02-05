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
            Car.MyMethod(); // 调用了Car类中自定义方法MyMethod
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White"); 
            
                                                         /*
            
            myCar.Make = "OldMobile"; // 将这些代码注释后，由于在Car类中已经内置了构造函数，因此不需要我们在类之外对myCar再次设置参数
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            
            Car myOtherCar; // 在Car类中创建新引用(句柄)myOtherCar指向myCar,因为Car类中已经有myCar，这一句不需要用new
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

            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);
                                                       */
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

        public Car(string make, string model, int year, string color) // 过载构造函数
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        // 若将构造函数标注，则系统默认调用类中的参数设置方法(48-51行)，同时手动输入参数(18-21)行就可创建新实例
        // 若不手动设置参数，则新实例没有任何内容
        
        public static void MyMethod() // 这是静态方法(静态对象)   ，和动态方法的区别就是关键字里多了static
        {
            Console.WriteLine("This is my method.");
            Console.WriteLine(Make); 

        }
    }
}

