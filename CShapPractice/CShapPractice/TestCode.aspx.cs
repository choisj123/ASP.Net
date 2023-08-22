using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CShapPractice
{
    public partial class TestCode : System.Web.UI.Page
    {
        // 열거형(enum)
        enum UserType
        {
            Admin, 
            Master,
            Guest = 5,
            Invalid
        }

        // 구조체(struct)
        public struct Dog
        {
            public string Name;
            public string Breed;

            public Dog(string name, string breed)
            {
                Name = name;
                Breed = breed;
            }

            public string Introduce()
            {
                return "이름: " + Name + "(" + Breed + ")";
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            // 열거형
            UserType siteUserType = UserType.Guest;
            ShowResult(siteUserType + " = " + (int)siteUserType);

            // 구조체
            Dog bob = new Dog("몽실이", "말티즈");
            Dog tom;
            tom.Name = "유하";
            tom.Breed = "폼피츠";

            ShowResult(bob.Introduce());
            ShowResult(tom.Introduce());

            // 묵시적 형변환
            bool myBool = true;
            int myInt = 45;
            float myFloat = 7.8F;

            myFloat = myInt + myFloat;
            ShowResult("합은 " + myFloat + "입니다. (" + myBool + ")");

            // 명시적 형변환
            int divident = 7;
            int divisor = 5;

            int quotient = divident / divisor;

            float quotientFloat = (float)divident / (float)divisor;
            ShowResult(quotient + " vs " + quotientFloat);

            // 형 변환 메서드
            ShowResult(myBool.ToString() + " " + myInt.ToString());
            string a = "7";
            string b = "7.8";
            ShowResult(int.Parse(a) + " " + float.Parse(b));

            // 단항 연산자
            int result;
            result = +myInt; ShowResult(result.ToString());
            result = -myInt; ShowResult(result.ToString());
            result = ~myInt; ShowResult(result.ToString());

            // 시프트 연산자
            ShowResult((6 << 1).ToString());

            // 비트 연산자
            int first = 2;
            int second = 3;
            int result2;
            result2 = first & second; ShowResult(result2.ToString());
            result2 = first | second; ShowResult(result2.ToString());
            result2 = first ^ second; ShowResult(result2.ToString());
        }

        void ShowResult(string result)
        {
            Label lblResult = new Label();
            Page.Controls.Add(lblResult);
            lblResult.Text = result + "<br/>";
        }
    }
}