using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace c13_1Delegate
{
    /*
      delegate int MyDelegate(int a, int b);

      class Calculator
      {
          public int Plus(int a, int b)
          {
              return a + b;
          }

          public static int Minus(int a, int b)
          {
              return a - b;
          }
      }

      class MainApp
      {
          static void Main(string[] args)
          {
              Calculator Calc = new Calculator();
              MyDelegate Callback;

              Callback = new MyDelegate(Calc.Plus);//델리게이트를 메소드를 호출하듯 사용하면 참조하고 있는 메소드가 실행됩니다.
              Console.WriteLine(Callback(3, 4));

              Callback = new MyDelegate(Calculator.Minus);
              Console.WriteLine(Callback(7, 5));
          }
      }*/
}
