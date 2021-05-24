using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace property09
{
    /*class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;
        //컬렉션의 현재 위치를 다루는 변수입니다.최기값은 0이 아닌 -1입니다. 0은 배열의 첫 번째 요소를 가리키는 수이기 때문에 position이 이 값(0)을
        //갖고 있다면 foreach 문이 첫 번째 반복을 수행하면 MoveNext() 메소드를 실행하고, 이때 position이 1이 되어 두 번째 요소를 가져오게 됩니다.

        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        //IEnumerator 멤버
        public object Current //IEnumerator로부터 상속받은 Current 프로퍼티는 현재 위치의 요소를 받환합니다.
        {
            get
            {
                return array[position];
            }
        }


        //IEnumerator 멤버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset()//IEnumerator 로부터 상속받은 Reset()메소드, 요소의 위치를 첫 요소의 "앞"으로 옮깁니다.
        {
            position = -1;
        }
        //IEnumerator 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;
            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
    */
}
