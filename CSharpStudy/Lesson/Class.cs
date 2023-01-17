using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    // class 키워드는 Reference Type을 정의하는데 사용된다.
    // 클래스는 메서드(Method). 속성(Property), 필드(Field), 이벤트(Event) 등을 멤버로 포함하는 
    // 소프트웨어 단위로서 보통 이 클래스 정의로부터 객체(Object) 를 생성해서 사용하게 된다.

    // 메서드(Method) - 클래스에서 실제 행동을 일으키는 코드 블럭. 대개 동사 혹은 동사 + 명사 식으로 메서드명을 정함. ex. Calculate(), DeleteData()
    // 속성(Property) - 클래스 내부 데이타를 외부에서 사용할 수 있게 하거나, 외부에서 클래스 내부 데이타를 간단하게 설정할 때 사용한다.
    // 필드(Field) - 클래스 내부 데이타는 필드에 저장하게 되며, 필드들은 클래스 객체의 상태를 유지하는데 이용된다. 클래스는 동일하더라도 클래스로부터 생성된 여러 객체들은 다른 필드값을 가진다.
    // 이벤트(Event) - 이벤트는 객체 내부의 특정 상태를, 혹은 어떤 일이 있어났다는 이벤트를 외부로 전달하는데 이용된다.

    partial class MyCustomer
    {
        // 필드
        private string name;
        private int age;

        // 이벤트
        public event EventHandler NameChanged;

        // 생성자 Constructor
        public MyCustomer()
        {
            name = string.Empty;
            age = -1;
            middleName = string.Empty;
        }

        // 속성
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string GetCustomerData()
        {
            string data = string.Format("Name : {0} Age: {1}", this.name, this.age);
            return data;
        }
    }
}
