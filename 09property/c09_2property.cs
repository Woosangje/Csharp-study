using System;

namespace property09
{
    /*
프로퍼티 선언 문법에서 get{~~~}과 set {~~~}을 일컬어 접근자(accessor)라고 합니다.
get 접근자는 필드로부터 값을 읽어오고
set 접근자는 필드에 값을 할당합니다.*/
   /* class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                BirthdayInfo birth = new BirthdayInfo();
                birth.Name = "서현";
                birth.Birthday = new DateTime(1991, 6, 28);

                Console.WriteLine("Name :{0}", birth.Name);
                Console.WriteLine("Birthday: {0}", birth.Birthday.ToShortDateString());
                Console.WriteLine("Age : {0}", birth.Age);
            }
        }
    }*/
}
