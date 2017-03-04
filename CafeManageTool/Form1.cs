using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Collections;
using mshtml;

namespace CafeManageTool
{

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        private bool logining = false;
        private bool testing = false;
        private bool rightCafe = false;
        private int checkedBoardCount = 0;
        private int checkingBoardReceiveCount = 0;
        private bool checkingBoard = false;
        private string checkingBoardName = "";
        private Hashtable cafeList = new Hashtable();
        private Hashtable newPostList = new Hashtable();
        public Form1()
        {
            InitializeComponent();
            webBrowser.ObjectForScripting = this;
            webBrowser.Navigate("https://nid.naver.com/nidlogin.login");
        }

        public void log(string message)
        {
            message = "[" + System.DateTime.Now.ToString("HH:mm:ss") + "] " + message;
            if (console.Text.Length == 0)
                console.Text = message;
            else
                console.AppendText("\r\n" + message);
        }

        private void login_LoginButton_Click(object sender, EventArgs e)
        {
            login_StatusLabel.Text = "로그인 중...";
            webBrowser.Navigate("javascript:document.getElementById('id').value = '" + login_IdTextBox.Text + "';document.getElementById('pw').value = '" + login_PasswordTextBox.Text + "';document.getElementById('frmNIDLogin').submit();");
            log("로그인 요청(ID: " + login_IdTextBox.Text + ")");
            logining = true;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (logining)
            {
                if (webBrowser.Url.AbsoluteUri.StartsWith("http://www.naver.com"))
                {
                    logining = false;
                    login_LoginButton.Enabled = false;
                    login_StatusLabel.Text = "로그인 성공!";
                    log("로그인 성공.");
                }
                else if (webBrowser.Url.AbsoluteUri.StartsWith("https://nid.naver.com/nidlogin.login"))
                {
                    HtmlElement title = webBrowser.Document.GetElementById("captchaimg");
                    if (title != null)
                    {
                        login_StatusLabel.Text = "자동입력 방지문자를 입력해 주세요.";
                        log("로그인 실패. 사유: 자동입력 방지문자");
                    }
                    else
                    {
                        HtmlElement i = webBrowser.Document.GetElementById("err_common");
                        if (i == null || i.InnerText.StartsWith("아이디 또는 비밀번호를 다시 확인하세요"))
                        {
                            login_StatusLabel.Text = "로그인 실패.";
                            log("로그인 실패. 사유: 아이디 또는 비밀번호가 틀림");
                        }
                    }
                    logining = false;
                }
            }
            else if (testing)
            {
                foreach (HtmlElement i in webBrowser.Document.GetElementsByTagName("img"))
                {
                    if (i.GetAttribute("src").Equals("http://cafeimgs.naver.net/img/notice/btn_cafehome.gif"))
                    {
                        log("잘못된 카페 주소: " + webBrowser.Url.AbsoluteUri);
                        selectCafe_SelectStatusLabel.Text = "잘못된 카페 주소입니다.";
                        rightCafe = false;
                        webBrowser.GoBack();
                        testing = false;
                        return;
                    }
                }
                log("올바른 카페 주소: " + webBrowser.Url.AbsoluteUri);
                selectCafe_SelectStatusLabel.Text = "올바른 카페 주소입니다!";
                rightCafe = true;
                testing = false;
            }
            else if (checkingBoard)
            {
                //log("checkingBoard 수신");
                checkingBoardReceiveCount++;
                if (checkingBoardReceiveCount == 4)
                {
                    if (newPostList.ContainsKey(checkingBoardName))
                    {
                        HtmlElement headElement = webBrowser.Document.GetElementsByTagName("head")[0];
                        HtmlElement scriptElement = webBrowser.Document.CreateElement("script");
                        IHTMLScriptElement element = (IHTMLScriptElement)scriptElement.DomElement;
                        element.text = "function findNewPost() { var nums = [];var titles = [];for (var k = document.getElementById('cafe_main').contentWindow.document.getElementsByClassName('m-tcol-c list-count').length - 1; k >= 0; k--) {var element = document.getElementById('cafe_main').contentWindow.document.getElementsByClassName('m-tcol-c list-count')[k];if (element === undefined) break;var childs = element.parentElement.parentElement.children;for (var i in childs) {if (childs[i].className === 'board-list') {for (var j in childs[i].children[0].children) {if (childs[i].children[0].children[j].className === 'aaa') {if (parseInt(element.innerText) > " + newPostList[checkingBoardName] + ") {/*nums.push(element.innerText);titles.push(childs[i].children[0].children[j].children[0].innerText);*/window.external.CafeNewPost(element.innerText, childs[i].children[0].children[j].children[0].innerText)}}}}}}/*window.external.CafeNewPost(nums.join('\n'), titles.join('\n'));*/ }";
                        headElement.AppendChild(scriptElement);
                        webBrowser.Document.InvokeScript("findNewPost");
                        //webBrowser.Navigate("javascript:var element;for (var k = 14 ; (element=document.getElementById('cafe_main').contentWindow.document.getElementsByClassName('m-tcol-c list-count')[k]) !== undefined ; k--){childs=element.parentElement.parentElement.children;for(var i in childs)if('board-list'===childs[i].className)for(var j in childs[i].children[0].children)'aaa'===childs[i].children[0].children[j].className&&window.external.CafeNewPost(element.innerText,childs[i].children[0].children[j].children[0].innerText);}");
                    }
                    else webBrowser.Navigate("javascript:var element=document.getElementById('cafe_main').contentWindow.document.getElementsByClassName('m-tcol-c list-count')[0],childs=element.parentElement.parentElement.children;for(var i in childs)if('board-list'===childs[i].className)for(var j in childs[i].children[0].children)'aaa'===childs[i].children[0].children[j].className&&window.external.CafeNewPost(element.innerText,childs[i].children[0].children[j].children[0].innerText);");
                    checkingBoardReceiveCount = 0;
                }
            }
        }

        private void login_PasswordShowButton_MouseDown(object sender, MouseEventArgs e)
        {
            login_PasswordTextBox.PasswordChar = '\0';
        }

        private void login_PasswordShowButton_MouseUp(object sender, MouseEventArgs e)
        {
            login_PasswordTextBox.PasswordChar = '*';
        }

        public void CafeList(string answer)
        {
            if (answer.Equals(""))
            {
                log("카페 목록 로딩 실패. 1초 후 재시도합니다.");
                selectCafe_LoadStatusLabel.Text = "실패. 재시도중...";
                selectCafe_loadCafeListTimer.Start();
                return;
            }
            cafeList.Clear();
            foreach (string i in answer.Split('#'))
            {
                cafeList.Add(i.Split('@')[0], i.Split('@')[1]);
                selectCafe_ComboBox.Items.Add(i.Split('@')[0]);
            }
            selectCafe_ComboBox.SelectedIndex = 0;
            log("카페 목록 수신.");
            selectCafe_LoadStatusLabel.Text = "성공!";
        }

        public void CafeBoardList(string answer)
        {
            int leng = 0;
            foreach(string i in answer.Split(','))
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Text = i;
                checkbox.Location = new Point(0, leng * 25);
                checkbox.Width = 100;
                checkbox.Height = 25;
                checkbox.Show();
                commentOnNewPost_BoardListPanel.Controls.Add(checkbox);
                leng++;
            }
            log("카페 게시판 목록 수신.");
        }

        public void CafeNewPost(string number, string title)
        {
            log("새 글: [" + number + "] " + title);
            if (newPostList.ContainsKey(checkingBoardName))
            {
                newPostList[checkingBoardName] = number;
            }
            else
            {
                newPostList.Add(checkingBoardName, number);
            }

        }

        private void selectCafe_LoadButton_Click(object sender, EventArgs e)
        {
            log("카페 목록 불러오기 시도.");
            webBrowser.Navigate("javascript:try{document.getElementById('minime').contentWindow.document.getElementsByClassName('tab_cafe')[0].click();var unread = document.getElementById('minime').contentWindow.document.getElementsByClassName('unread');if (unread.length !== 0){var ans = [];for (var i in unread){if (unread[i].children !== undefined){ans.push(unread[i].children[0].title + '@' + unread[i].children[0].href);}}window.external.CafeList(ans.join('#'));}else{window.external.CafeList('');}}catch(e){window.external.CafeList('');}");
        }

        private void selectCafe_loadCafeListTimer_Tick(object sender, EventArgs e)
        {
            log("카페 목록 불러오기 재시도.");
            webBrowser.Navigate("javascript:try{var unread = document.getElementById('minime').contentWindow.document.getElementsByClassName('unread');if (unread.length !== 0){var ans = [];for (var i in unread){if (unread[i].children !== undefined){ans.push(unread[i].children[0].title + '@' + unread[i].children[0].href);}}window.external.CafeList(ans.join('#'));}else{window.external.CafeList('');}}catch(e){window.external.CafeList('');}");
            selectCafe_loadCafeListTimer.Stop();
        }

        private void selectCafe_SelectButton_Click(object sender, EventArgs e)
        {
            if (cafeList.ContainsKey(selectCafe_ComboBox.Text))
            {
                webBrowser.Navigate((string)cafeList[selectCafe_ComboBox.Text]);
            }
            else
            {
                webBrowser.Navigate("http://cafe.naver.com/" + selectCafe_ComboBox.Text);
            }
            testing = true;
        }

        private void commentOnNewPost_LoadPostListButton_Click(object sender, EventArgs e)
        {
            log("카페 게시판 목록 불러오기 시도.");
            webBrowser.Navigate("javascript:var string = []; var gmtcolc = document.getElementsByClassName('gm-tcol-c'); for (var i=0, leng=gmtcolc.length ; i < leng ; i++) if (gmtcolc[i].outerHTML.indexOf('cafe_main') !== -1 && gmtcolc[i].outerHTML.indexOf('ArticleList.nhn?search.clubid=') !== -1 && gmtcolc[i].outerHTML.indexOf('Favorite') === -1) string.push(gmtcolc[i].innerHTML); window.external.CafeBoardList(string.join(','));");
        }

        private void commentOnNewPost_StartButton_Click(object sender, EventArgs e)
        {
            if (commentOnNewPost_loadPostTimer.Enabled)
            {
                log("게시글 검사 중지!");
                commentOnNewPost_loadPostTimer.Enabled = false;
                commentOnNewPost_StartButton.Text = "시작";
            }
            else
            {
                log("5초마다 최신 게시글을 불러옵니다.");
                commentOnNewPost_loadPostTimer.Enabled = true;
                commentOnNewPost_StartButton.Text = "중지";
            }
        }

        private void commentOnNewPost_loadPostTimer_Tick(object sender, EventArgs e)
        {
            foreach (CheckBox checkbox in commentOnNewPost_BoardListPanel.Controls)
            {
                if (checkbox.Checked)
                {
                    checkingBoard = true;
                    checkingBoardName = checkbox.Text;
                    //log(checkingBoardName + " 검사 시작");
                    webBrowser.Navigate("javascript:var gmtcolc = document.getElementsByClassName('gm-tcol-c');for (var i = 0, leng = gmtcolc.length; i < leng; i++) if (gmtcolc[i].outerHTML.indexOf('cafe_main') !== -1 && gmtcolc[i].outerHTML.indexOf('ArticleList.nhn?search.clubid=') !== -1 && gmtcolc[i].outerHTML.indexOf('Favorite') === -1 && gmtcolc[i].innerHTML === '" + checkingBoardName + "') gmtcolc[i].click();");
                }
            }
        }
    }
}
