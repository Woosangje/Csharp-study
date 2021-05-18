using System;
using System.Collections.Generic;
using System.Text;

namespace property09_7
{
    /*9.7추상 클래스와 프로퍼티*/
    /*추상 클래스는 클래스처럼 구현된 프로퍼티를 가질 수도 있는 한편, 
     * 인터페이스처럼 구현되지 않은 프로퍼티고 가질 수 있습니다.
     추상 메소드가 그랬던 것처럼, 추상 프로퍼티 역시 인터페이스의 프로퍼티와 다를 것이없습니다.
    파생 클래스가 해당 프로퍼티를 구현하도록 강제하는 것일 뿐이지요.

    추상 클래스의 추상프로퍼티는 인터페이스처럼 구현을 비워놓은 것만으로는 추상 프로퍼티를 만들 수 없습니다.
    C# 컴파일러가 자동 구현 프로퍼티로 간주하고 구현을 자동으로 채워넣을 테니까요.
    추상 프로퍼티는 다음과 같이 abstract 한정자를 이용해서 선정합니다.
     */

   /* abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }
        class MyProduct : Product
        {
            public override DateTime ProductDate
            {
                get;
                set;
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                Product product_1 = new MyProduct()
                { ProductDate = new DateTime(2014, 1, 10) };

                Console.WriteLine("Product : {0}, Product Date : {1}",
                        product_1.SerialID,
                        product_1.ProductDate);

                Product product_2 = new MyProduct()
                {
                    ProductDate = new DateTime(2014, 2, 3)
                };

                Console.WriteLine("Product :{0}, Product Date : {1}",
                    product_2.SerialID,
                    product_2.ProductDate);
            }
        }

    */
}
