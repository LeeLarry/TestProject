using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;

namespace static_exercise
{
    public class Number
    {
        public static int i = 123;
        public virtual void ShowInfo()
        {
            Console.WriteLine("BaseClassShowInfo;");
        }
        public virtual void ShowNumber()
        {
            Console.WriteLine(i.ToString());
        }
    }
    public class IntNumber : Number
    {
        new public static int i = 456;
        public new virtual void ShowInfo()
        {
            Console.WriteLine("DerivedClassShowInfo!");
        }
        public override void ShowNumber()
        {
            Console.WriteLine("Base Number is {0}",Number.i.ToString());
            Console.WriteLine("New number is {0}",i.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.ShowNumber();//调用Number的ShowNumber()

            IntNumber intNum = new IntNumber();
            intNum.ShowNumber();//调用IntNumber的ShowNumber
            intNum.ShowInfo();//调用IntNumber的ShowInfo

            Number num2 = new IntNumber();
            num2.ShowInfo();//调用Number的ShowInfo
            num2.ShowNumber();//调用IntNumber的ShowNumber
           
        }
    }
}

