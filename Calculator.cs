using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Adder
    {
        private double a;
        private double b;

        public Adder(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            return this.a + this.b;
        }
    }

    class Subtractor
    {
        private double a;
        private double b;

        public Subtractor(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            return this.a - this.b;
        }
    }

    class Multiplier
    {
        private double a;
        private double b;

        public Multiplier(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            return this.a * this.b;
        }
    }

    class Divider
    {
        private double a;
        private double b;

        public Divider(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            return this.a / this.b;
        }
    }

    class Calculator
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ctrl + C키를 누르면 종료됩니다\n");
            while (true)
            {
                // 변수 초기화

                double a = 0, b = 0;
                char oper = '+';

                // 숫자 입력 1
                try
                {
                    Console.Write("첫번째 숫자를 입력하시오 : ");
                    a = double.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("잘못된 문자입니다");
                }

                // 연산자 입력
                try
                {
                    Console.Write("연산자를 입력하시오(+,-,*,/) : ");
                    oper = char.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 문자입니다");
                }

                // 숫자 입력 2
                try
                {
                    Console.Write("두번째 숫자를 입력하시오 : ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 문자입니다");
                }

                // 연산자 판별 후 결과 출력
                if (oper.Equals('+'))
                {
                    Adder adder = new Adder(a, b);
                    Console.WriteLine("결과 : " + adder.Calculate());
                }
                else if (oper.Equals('-'))
                {
                    Subtractor subtractor = new Subtractor(a, b);
                    Console.WriteLine("결과 : " + subtractor.Calculate());
                }
                else if (oper.Equals('*'))
                {
                    Multiplier multiplier = new Multiplier(a, b);
                    Console.WriteLine("결과 : " + multiplier.Calculate());
                }
                else if (oper.Equals('/'))
                {
                    Divider divider = new Divider(a, b);
                    Console.WriteLine("결과 : " + divider.Calculate());
                }
                else
                {
                    Console.WriteLine("인식할 수 없는 연산자입니다");
                }
                Console.WriteLine();
            }
        }
    }
}
