using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHidding
{
    //메소드 숨기기
   /* class Base//클래스
    {
        public void MyMethod()//전역 메소드
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base//Base를 상속받은 Derived클래스
    {
        public new void MyMethod()  
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();//인스턴스
            baseObj.MyMethod();

            Derived derivedObj = new Derived();//인스턴스
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();//인스턴스
            baseOrDerived.MyMethod();
        }
    }*/
}
