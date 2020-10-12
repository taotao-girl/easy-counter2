using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_8_计算器重构
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console .WriteLine ("请输入你想要实现的功能：");
            Console .WriteLine ("1--数字相加；2--字符串相加；3--数字相减；4--字符串相减；5--数字相乘；6--数字相除");
            int n=int.Parse(Console .ReadLine ());            
            switch (n)
            {
                case 1:
                    Jian_Jia1 jia1 = new Jian_Jia1();
                    Console.WriteLine("输入第一个数A1为：");
                    jia1.A1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("输入第二个数B1为：");
                    jia1.B1 = int.Parse(Console.ReadLine());
                    jia1.Count1();
                    break;
                case 2:
                    Jia_Jian2 jia2 = new Jia_Jian2();
                    Console.WriteLine("输入第一个数A1为：");
                    jia2.A1 =Console.ReadLine();
                    Console.WriteLine("输入第二个数B1为：");
                    jia2.B1 =Console.ReadLine();
                    jia2.Count1();
                    break;
                case 3:
                    Jian_Jia1 jian1 = new Jian_Jia1();
                    Console.WriteLine("输入第一个数A1为：");
                    jian1.A1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("输入第二个数B1为：");
                    jian1.B1 = int.Parse(Console.ReadLine());
                    jian1.Count2();
                    break;
                case 4:
                    Jia_Jian2 jian2 = new Jia_Jian2();
                    Console.WriteLine("输入第一个数A1为：");
                    jian2.A1 =Console.ReadLine();
                    Console.WriteLine("输入第二个数B1为：");
                    jian2.B1 =Console.ReadLine();
                    jian2.Count2();
                    break;
                case 5:
                    Console.WriteLine("输入第一个数W为：");
                    int W = int.Parse(Console.ReadLine());     
                    Console.WriteLine("输入第二个数Y为：");
                    int Y = int.Parse(Console.ReadLine());
                    Console.WriteLine((W * Y));
                    break;
                case 6:
                    try{
                        Console.WriteLine("输入第一个数X为：");
                        int X = int.Parse(Console.ReadLine());  
                        Console.WriteLine("输入第二个数Z为：");
                        int Z = int.Parse(Console.ReadLine());
                        Console.WriteLine((X / Z));
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine("除法算数中出现异常：{0}",ex.GetType());
                        Console.WriteLine("除数不能为0");
                    }
                    break;
            }
        }       
    }
    class Jian_Jia1
    {
        protected int A, B;

        public int B1
        {
            get { return B; }
            set { B = value; }
        }

        public int A1
        {
            get { return A; }
            set { A = value; }
        }
        public virtual void Count1()
        {
            Console.WriteLine("结果={0}",A + B);
        }
        public void Count2()
        {
            Console.WriteLine("结果={0}", A - B);
        }
    }
    class Jia_Jian2 
    {   
        protected String  A, B;
        public String B1
        {
            get { return B; }
            set { B = value; }
        }
        public String A1
        {
            get { return A; }
            set { A = value; }
        }
        public void Count1()
        {
            string result=A+B;
            Console.WriteLine("结果={0}", result);
        }
        public void Count2()
        {  
            string result;
            result =A.Replace (B," ");
            Console.WriteLine("结果={0}", result);
        }
    }
}
