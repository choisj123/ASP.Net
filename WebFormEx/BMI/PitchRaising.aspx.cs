using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMI
{
    public partial class PitchRaising : System.Web.UI.Page
    {

        protected string[] PitchArray = { "도", "레", "미", "파", "솔", "라", "시" };
        protected int Note;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 한 페이지에서 다른 페이지로 이동 하는 것이 아니라 자신의 페이지가 새로고침되는 현상
            if (IsPostBack)
            {
                // ViewState 컬렉션에 Note라는 이름의 항목이 없으면 새로운 항목으로 추가되고,
                // 있으면 기존의 값 Note에 저장
                Note = (int)ViewState["Note"];
            }
            else // 처음 페이지를 여는 경우
            {
               // Note 초기화
                Note = 5;
            }

        }

        // 뷰 상태의 가장 큰 단점은 다시 게시되는 해당 페이지에서만 사용할 수 있다는 것이다.
        // 다른 페이지로 이동하면 뷰 상태 정보는 모두 사라진다.
        // -> 페이지 간 게시(Cross-Page-Posting)
        //      Button형 컨트롤에 있는 PostBackUrl 속성
        //      -> FileSearch.aspx
        // -> 쿼리 스트링

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["Note"] = Note;
        }

        protected void btnPitchDown_Click(object sender, EventArgs e)
        {
            Note = (int)ViewState["Note"] - 1;

            if (Note < 0) Note = 6;
            ShowPitch();
        }

        protected void btnPitchUp_Click(object sender, EventArgs e)
        {
            Note = ((int)ViewState["Note"] + 1) % 7;

            ShowPitch();
        }

        protected void ShowPitch()
        {
            lblPitch.Text = PitchArray[Note];
        }
    }

}
