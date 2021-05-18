using System;
using System.Collections.Generic;
using System.Text;

namespace property09
{/*
    9.7 추상 클래스와 프로퍼티
    프레임

    abstract class 추상 클래스 이름
    {
        abstract 데이터형식 프로퍼티이름
        {
            get;
            set;
        }
    }

    abstract class Product
    {
        private static int serial = 0;
        public string SerialID //추상 클래스는 구현을 가진 프로퍼티와
        {
            get { return String.Format("{0:d5}", serial++ }
        }

        abstract public DateTime ProductDate //구현이 없는 추상 클래스 모두를 가질 수 있습니다.
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate //파생 클래스는 부모 추상 클래스의 모든 추상 메소드 뿐 아니라 추상 프로퍼티를 재정의해야 합니다.
        }
            get;
            set;
        }
    }
   */
}
