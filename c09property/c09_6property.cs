using System;
using System.Collections.Generic;
using System.Text;

namespace property09
{
    //인터페이스의 프로퍼티
    /*인터페이스는 메소드뿐만 아니라 프로퍼티와 인덱서도 가질 수 있습니다.
     파생 클래스는 부모 인터페이스에 선언된 모든 프로퍼티를 구현해야합니다.
     */
   interface INamedValue
    {
        string Name
        {
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
                Name = "이름",
                Value = "박상현"
            };
            NamedValue height = new NamedValue()
            {
                Name ="키", Value = "177Cm"
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
}
