using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThirdMethod();
        }

        static void MySecondMethod(MyFirstEnum _myEnum)
        {
            if (_myEnum == MyFirstEnum.A)
            {

            }

            if (_myEnum == 0)
            {

            }
        }

        static void MyThirdMethod()
        {
            switch (MyFirstEnum)
            {
                case MyFirstEnum.A:
                    {

                    }
                    break;
                case MyFirstEnum.B: break;
                case MyFirstEnum.C: break;
                case MyFirstEnum.D: break;
                default: break;
            }
        }

        enum MyFirstEnum : byte //(значения с 0 до 255)
        {
            A = 99, //Можно назначать свои значения
            B,
            C,
            D,
            E,
            F
        }
    }
}