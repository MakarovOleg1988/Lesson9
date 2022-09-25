using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThirdMethod();
        }

        static void MyThirdMethod()
        {
            var _myEnum = new MyFirstEnum();

            switch (_myEnum)
            {
                case MyFirstEnum.A:
                        Console.WriteLine (MyFirstEnum.A);
                    break;
                case MyFirstEnum.B: Console.WriteLine(MyFirstEnum.B); break;
                case MyFirstEnum.C: Console.WriteLine(MyFirstEnum.C); break;
                case MyFirstEnum.D: Console.WriteLine(MyFirstEnum.D); break;
                default: break;
            }
        }
        enum MyFirstEnum : byte //(значения с 0 до 255)
        {
            A = 99, //Можно назначать свои значения
            B = 20,
            C,
            D,
            E,
            F
        }

    }
}