﻿using System;
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

            myOtherCar.Model = "98"; // 这一步将Model改为98       
            Console.WriteLine("修改后: " + "{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color); // 输出后Model发生了变化，是因为两个变量指向相同的值，无论修改哪一个，值也会改变
            
            Console.ReadLine();
            // 上几步操作证明了同一个内存对象可以有两个引用，类似一个气球有两条线，牵任何一条都可以找到气球
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
