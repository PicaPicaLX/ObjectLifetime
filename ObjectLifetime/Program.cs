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
            Car myCar = new Car(); // 在Car类中创建新的对象myCar

            myCar.Make = "OldMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986; //
            myCar.Color = "Silver";


            Car myOtherCar; // 在Car类中创建新对象myOtherCar
            myOtherCar = myCar; // 这一步将内存中对myCar对象的引用复制到了myOtherCar的新变量中
            // 注释里的的等效于上面的
            //Car myOtherCar = myCar;
            Console.WriteLine("修改前: "+"{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color); // 因为两个变量指向同一个值，因此无论输出哪一个，得到的是相同的

            myOtherCar = null; // 现在句柄不再指向任何内存中的实例,则下一步设置Model时会出错

            myOtherCar.Model = "98"; // 这一步将Model改为98       
            Console.WriteLine("修改后: " + "{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color); // 输出后Model发生了变化，是因为两个变量指向相同的值，无论修改哪一个，值也会改变
            
            myCar = null; // 现在句柄不再指向任何内存中的实例
            Console.ReadLine();
            /* 如何失去引用？(就是无法访问这些值)下面有几种方法
             * 1------------------------------------------------------------------------------------------------
             * 当线程不再访问这个数值(即汽车的相关属性),即没有任何引用指向这些值时，这个值就会被清零(就是当执行完SVM时清零)
             * 就是当我创建了自定义帮助器方法时，我在SVM里定义的myCar和myOtherCar就无法被新创建的方法访问
             * 2------------------------------------------------------------------------------------------------
             * 将引用设置为空值即null
             * -------------------------------------------------------------------------------------------------
             * 有些情况下，将变量设置为null可能会导致.net执行不定时垃圾回收时错误地清除内存中的实例因此需要手动设置垃圾回收
             */

        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
