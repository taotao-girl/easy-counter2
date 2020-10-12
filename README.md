# easy-counter2
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个数A为：");
            int A = int.Parse(Console.ReadLine());            
            Console.WriteLine("输入第二个数B为：");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("判断A与B是否相等：{0}",A.Equals(B));
            Console.WriteLine("操作对应：1--加，2--减，3--乘，4--除");
            Console.WriteLine("输入想要完成的操作C为：");
            int C = int.Parse(Console.ReadLine());
            switch (C)
            {
                case 1:
                    Console.WriteLine("结果={0}", (A + B));
                    break;
                case 2:
                    Console.WriteLine("结果={0}", (A - B));
                    break;
                case 3:
                    Console.WriteLine("结果={0}", (A * B));
                    break;
                case 4:
                    try{
                        Console.WriteLine("结果={0}", (A / B));
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine("除法算数中出现异常：{0}",ex.GetType());
                        Console.WriteLine("除数不能为0");
                    }
                    break;
            }
        }
        public override bool  Equals(object obj)   //重载Equals
        {
            if (obj == null)
                return false;
            Program comObj = obj as Program;
            if (comObj == null)
                return false;
            else
                return Equals(comObj); 
        }
        
    }    
