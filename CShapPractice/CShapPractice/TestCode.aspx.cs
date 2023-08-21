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
            UserType siteUserType = UserType.Guest;
            ShowResult(siteUserType + " = " + (int)siteUserType);

            Dog bob = new Dog("몽실이", "말티즈");
            Dog tom;
            tom.Name = "유하";
            tom.Breed = "폼피츠";

            ShowResult(bob.Introduce());
            ShowResult(tom.Introduce());
        }

        void ShowResult(string result)
        {
            Label lblResult = new Label();
            Page.Controls.Add(lblResult);
            lblResult.Text = result + "<br/>";
        }
    }
}