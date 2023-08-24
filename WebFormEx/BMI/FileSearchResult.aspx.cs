using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMI
{
    public partial class FileSearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 이전 페이지가 있을 경우
            if (PreviousPage != null)
            {
                // 이전 페이지의 컨트롤 구하기
                TextBox txtKeyWord;
                txtKeyWord = (TextBox)PreviousPage.FindControl("txtKeyWord");

                DropDownList ddlFileType;
                ddlFileType = (DropDownList)PreviousPage.FindControl("ddlFileType");

                // 이전 페이지의 입력 정보 처리
                string url = "http://www.google.co.ke/search?q=";
                url += Server.UrlEncode(txtKeyWord.Text + " ");

                string fileType = "";

                switch (ddlFileType.SelectedIndex)
                {
                    case 0:
                        fileType = "filetype:doc";
                        break;
                    case 1:
                        url += "filetype:ppt";
                        break;
                    case 2:
                        fileType = "filetype:hwp";
                        break;
                    case 3:
                        fileType = "filetype:pdf";
                        break;
                }
                url += fileType;

                // 링크 url 설정
                lnkSearchString.NavigateUrl = url;
                //페이지에 표시할 텍스트 설정
                lnkSearchString.Text = txtKeyWord.Text + " " + fileType;
            }

        }
    }
}