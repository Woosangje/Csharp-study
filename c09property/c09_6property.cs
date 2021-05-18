using System;
using System.Collections.Generic;
using System.Text;

namespace property09_06
{
    //인터페이스의 프로퍼티
    //인터페이스는 메소드뿐만 아니라 프로퍼티와 인덱서도 가질 수 있습니다.
     //프로퍼티나 인덱서를 가진 인터페이스를 상속하는 클래스는 반드시 해당 프로퍼티와 인덱서를 구현해야 합니다.
     //파생 클래스는 부모 인터페이스에 선언된 모든 프로퍼티를 구현해야합니다.
     
   /*
    interface INamedValue
    {
        string Name
        {
            //자동 구현 프로퍼티처럼 구현이 없지만, C#컴파일러는 인터페이스의 프로퍼티에 대해서는 자동으로 구현해
             //주지 않습니다. 이유는 인터페이스는 어떤 구현도 가지지 않기 때문입니다.
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }

    class NamedValue : INamedValue
    {
        //INamedValue 인터페이스를 상속하는 NamedValue 클래스는 반드시 Name과
        // Value를 구현해야 합니다. 이 때 자동 구현 프로퍼티를 이용하는 것도 가능합니다.
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name ="이름",
                Value = "박상현"
            };
            NamedValue height = new NamedValue()
            {
                Name ="키", Value ="177Cm"
            };

            NamedValue weight = new NamedValue()
            {
                Name = "몸무게",
                Value = "90Kg"
            };

            Console.WriteLine("{0} : {1}", name.Name, name.Value);
            Console.WriteLine("{0} : {1}", height.Name, height.Value);
            Console.WriteLine("{0} : {1}", weight.Name, weight.Value);
        }
    }
   */
}
