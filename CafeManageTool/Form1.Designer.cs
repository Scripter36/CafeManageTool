namespace CafeManageTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.login_LoginLabel = new System.Windows.Forms.Label();
            this.login_IdTextBox = new System.Windows.Forms.TextBox();
            this.login_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.login_IdLabel = new System.Windows.Forms.Label();
            this.login_PasswordLabel = new System.Windows.Forms.Label();
            this.login_LoginButton = new System.Windows.Forms.Button();
            this.login_StatusLabel = new System.Windows.Forms.Label();
            this.login_Panel = new System.Windows.Forms.Panel();
            this.login_PasswordShowButton = new System.Windows.Forms.Button();
            this.commentOnNewPost_Panel = new System.Windows.Forms.Panel();
            this.commentOnNewPost_BoardListLoadStatusLabel = new System.Windows.Forms.Label();
            this.commentOnNewPost_LoadBoardListButton = new System.Windows.Forms.Button();
            this.commentOnNewPost_StartButton = new System.Windows.Forms.Button();
            this.commentOnNewPost_TitleFilterTextBox = new System.Windows.Forms.TextBox();
            this.commentOnNewPost_TitleFilterLabel = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.commentOnNewPost_boardListLabel = new System.Windows.Forms.Label();
            this.commentOnNewPost_BoardListPanel = new System.Windows.Forms.Panel();
            this.commentOnNewPostLabel = new System.Windows.Forms.Label();
            this.console_Panel = new System.Windows.Forms.Panel();
            this.console = new System.Windows.Forms.TextBox();
            this.console_ConsoleLabel = new System.Windows.Forms.Label();
            this.selectCafe_Panel = new System.Windows.Forms.Panel();
            this.selectCafe_SelectStatusLabel = new System.Windows.Forms.Label();
            this.selectCafe_LoadStatusLabel = new System.Windows.Forms.Label();
            this.selectCafe_SelectButton = new System.Windows.Forms.Button();
            this.selectCafe_LoadButton = new System.Windows.Forms.Button();
            this.selectCafe_ComboBox = new System.Windows.Forms.ComboBox();
            this.selectCafe_Label = new System.Windows.Forms.Label();
            this.selectCafe_loadCafeListTimer = new System.Windows.Forms.Timer(this.components);
            this.commentOnNewPost_loadPostTimer = new System.Windows.Forms.Timer(this.components);
            this.commentOnNewPost_CommentTimer = new System.Windows.Forms.Timer(this.components);
            this.commentOnNewPost_CommentLabel = new System.Windows.Forms.Label();
            this.commentOnNewPost_CommentTextBox = new System.Windows.Forms.TextBox();
            this.login_Panel.SuspendLayout();
            this.commentOnNewPost_Panel.SuspendLayout();
            this.console_Panel.SuspendLayout();
            this.selectCafe_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.webBrowser.Location = new System.Drawing.Point(538, 150);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(270, 265);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // login_LoginLabel
            // 
            this.login_LoginLabel.AutoSize = true;
            this.login_LoginLabel.Location = new System.Drawing.Point(7, 5);
            this.login_LoginLabel.Name = "login_LoginLabel";
            this.login_LoginLabel.Size = new System.Drawing.Size(102, 15);
            this.login_LoginLabel.TabIndex = 1;
            this.login_LoginLabel.Text = "네이버 로그인";
            // 
            // login_IdTextBox
            // 
            this.login_IdTextBox.Location = new System.Drawing.Point(80, 23);
            this.login_IdTextBox.Name = "login_IdTextBox";
            this.login_IdTextBox.Size = new System.Drawing.Size(100, 25);
            this.login_IdTextBox.TabIndex = 2;
            // 
            // login_PasswordTextBox
            // 
            this.login_PasswordTextBox.Location = new System.Drawing.Point(80, 54);
            this.login_PasswordTextBox.Name = "login_PasswordTextBox";
            this.login_PasswordTextBox.PasswordChar = '*';
            this.login_PasswordTextBox.Size = new System.Drawing.Size(75, 25);
            this.login_PasswordTextBox.TabIndex = 3;
            // 
            // login_IdLabel
            // 
            this.login_IdLabel.AutoSize = true;
            this.login_IdLabel.Location = new System.Drawing.Point(7, 26);
            this.login_IdLabel.Name = "login_IdLabel";
            this.login_IdLabel.Size = new System.Drawing.Size(52, 15);
            this.login_IdLabel.TabIndex = 4;
            this.login_IdLabel.Text = "아이디";
            // 
            // login_PasswordLabel
            // 
            this.login_PasswordLabel.AutoSize = true;
            this.login_PasswordLabel.Location = new System.Drawing.Point(7, 57);
            this.login_PasswordLabel.Name = "login_PasswordLabel";
            this.login_PasswordLabel.Size = new System.Drawing.Size(67, 15);
            this.login_PasswordLabel.TabIndex = 5;
            this.login_PasswordLabel.Text = "비밀번호";
            // 
            // login_LoginButton
            // 
            this.login_LoginButton.Location = new System.Drawing.Point(186, 23);
            this.login_LoginButton.Name = "login_LoginButton";
            this.login_LoginButton.Size = new System.Drawing.Size(70, 56);
            this.login_LoginButton.TabIndex = 6;
            this.login_LoginButton.Text = "로그인";
            this.login_LoginButton.UseVisualStyleBackColor = true;
            this.login_LoginButton.Click += new System.EventHandler(this.login_LoginButton_Click);
            // 
            // login_StatusLabel
            // 
            this.login_StatusLabel.AutoSize = true;
            this.login_StatusLabel.Location = new System.Drawing.Point(7, 86);
            this.login_StatusLabel.Name = "login_StatusLabel";
            this.login_StatusLabel.Size = new System.Drawing.Size(127, 15);
            this.login_StatusLabel.TabIndex = 7;
            this.login_StatusLabel.Text = "로그인 해 주세요.";
            // 
            // login_Panel
            // 
            this.login_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_Panel.Controls.Add(this.login_PasswordShowButton);
            this.login_Panel.Controls.Add(this.login_IdTextBox);
            this.login_Panel.Controls.Add(this.login_StatusLabel);
            this.login_Panel.Controls.Add(this.login_LoginLabel);
            this.login_Panel.Controls.Add(this.login_LoginButton);
            this.login_Panel.Controls.Add(this.login_PasswordTextBox);
            this.login_Panel.Controls.Add(this.login_PasswordLabel);
            this.login_Panel.Controls.Add(this.login_IdLabel);
            this.login_Panel.Location = new System.Drawing.Point(12, 12);
            this.login_Panel.Name = "login_Panel";
            this.login_Panel.Size = new System.Drawing.Size(270, 131);
            this.login_Panel.TabIndex = 8;
            // 
            // login_PasswordShowButton
            // 
            this.login_PasswordShowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_PasswordShowButton.BackgroundImage")));
            this.login_PasswordShowButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_PasswordShowButton.Location = new System.Drawing.Point(155, 54);
            this.login_PasswordShowButton.Name = "login_PasswordShowButton";
            this.login_PasswordShowButton.Size = new System.Drawing.Size(25, 25);
            this.login_PasswordShowButton.TabIndex = 8;
            this.login_PasswordShowButton.UseVisualStyleBackColor = true;
            this.login_PasswordShowButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_PasswordShowButton_MouseDown);
            this.login_PasswordShowButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.login_PasswordShowButton_MouseUp);
            // 
            // commentOnNewPost_Panel
            // 
            this.commentOnNewPost_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_CommentTextBox);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_CommentLabel);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_BoardListLoadStatusLabel);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_LoadBoardListButton);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_StartButton);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_TitleFilterTextBox);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_TitleFilterLabel);
            this.commentOnNewPost_Panel.Controls.Add(this.separator1);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_boardListLabel);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPost_BoardListPanel);
            this.commentOnNewPost_Panel.Controls.Add(this.commentOnNewPostLabel);
            this.commentOnNewPost_Panel.Location = new System.Drawing.Point(287, 150);
            this.commentOnNewPost_Panel.Name = "commentOnNewPost_Panel";
            this.commentOnNewPost_Panel.Size = new System.Drawing.Size(245, 262);
            this.commentOnNewPost_Panel.TabIndex = 9;
            // 
            // commentOnNewPost_BoardListLoadStatusLabel
            // 
            this.commentOnNewPost_BoardListLoadStatusLabel.AutoSize = true;
            this.commentOnNewPost_BoardListLoadStatusLabel.Location = new System.Drawing.Point(4, 243);
            this.commentOnNewPost_BoardListLoadStatusLabel.Name = "commentOnNewPost_BoardListLoadStatusLabel";
            this.commentOnNewPost_BoardListLoadStatusLabel.Size = new System.Drawing.Size(107, 15);
            this.commentOnNewPost_BoardListLoadStatusLabel.TabIndex = 10;
            this.commentOnNewPost_BoardListLoadStatusLabel.Text = "불러와 주세요!";
            // 
            // commentOnNewPost_LoadBoardListButton
            // 
            this.commentOnNewPost_LoadBoardListButton.Location = new System.Drawing.Point(7, 215);
            this.commentOnNewPost_LoadBoardListButton.Name = "commentOnNewPost_LoadBoardListButton";
            this.commentOnNewPost_LoadBoardListButton.Size = new System.Drawing.Size(124, 25);
            this.commentOnNewPost_LoadBoardListButton.TabIndex = 9;
            this.commentOnNewPost_LoadBoardListButton.Text = "불러오기";
            this.commentOnNewPost_LoadBoardListButton.UseVisualStyleBackColor = true;
            this.commentOnNewPost_LoadBoardListButton.Click += new System.EventHandler(this.commentOnNewPost_LoadPostListButton_Click);
            // 
            // commentOnNewPost_StartButton
            // 
            this.commentOnNewPost_StartButton.Location = new System.Drawing.Point(137, 215);
            this.commentOnNewPost_StartButton.Name = "commentOnNewPost_StartButton";
            this.commentOnNewPost_StartButton.Size = new System.Drawing.Size(75, 25);
            this.commentOnNewPost_StartButton.TabIndex = 8;
            this.commentOnNewPost_StartButton.Text = "시작";
            this.commentOnNewPost_StartButton.UseVisualStyleBackColor = true;
            this.commentOnNewPost_StartButton.Click += new System.EventHandler(this.commentOnNewPost_StartButton_Click);
            // 
            // commentOnNewPost_TitleFilterTextBox
            // 
            this.commentOnNewPost_TitleFilterTextBox.Location = new System.Drawing.Point(137, 50);
            this.commentOnNewPost_TitleFilterTextBox.Name = "commentOnNewPost_TitleFilterTextBox";
            this.commentOnNewPost_TitleFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.commentOnNewPost_TitleFilterTextBox.TabIndex = 5;
            // 
            // commentOnNewPost_TitleFilterLabel
            // 
            this.commentOnNewPost_TitleFilterLabel.AutoSize = true;
            this.commentOnNewPost_TitleFilterLabel.Location = new System.Drawing.Point(137, 32);
            this.commentOnNewPost_TitleFilterLabel.Name = "commentOnNewPost_TitleFilterLabel";
            this.commentOnNewPost_TitleFilterLabel.Size = new System.Drawing.Size(87, 15);
            this.commentOnNewPost_TitleFilterLabel.TabIndex = 4;
            this.commentOnNewPost_TitleFilterLabel.Text = "제목 필터링";
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(7, 22);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(232, 2);
            this.separator1.TabIndex = 3;
            // 
            // commentOnNewPost_boardListLabel
            // 
            this.commentOnNewPost_boardListLabel.AutoSize = true;
            this.commentOnNewPost_boardListLabel.Location = new System.Drawing.Point(3, 32);
            this.commentOnNewPost_boardListLabel.Name = "commentOnNewPost_boardListLabel";
            this.commentOnNewPost_boardListLabel.Size = new System.Drawing.Size(87, 15);
            this.commentOnNewPost_boardListLabel.TabIndex = 2;
            this.commentOnNewPost_boardListLabel.Text = "게시판 선택";
            // 
            // commentOnNewPost_BoardListPanel
            // 
            this.commentOnNewPost_BoardListPanel.AutoScroll = true;
            this.commentOnNewPost_BoardListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentOnNewPost_BoardListPanel.Location = new System.Drawing.Point(7, 50);
            this.commentOnNewPost_BoardListPanel.Name = "commentOnNewPost_BoardListPanel";
            this.commentOnNewPost_BoardListPanel.Size = new System.Drawing.Size(124, 159);
            this.commentOnNewPost_BoardListPanel.TabIndex = 1;
            // 
            // commentOnNewPostLabel
            // 
            this.commentOnNewPostLabel.AutoSize = true;
            this.commentOnNewPostLabel.Location = new System.Drawing.Point(4, 4);
            this.commentOnNewPostLabel.Name = "commentOnNewPostLabel";
            this.commentOnNewPostLabel.Size = new System.Drawing.Size(127, 15);
            this.commentOnNewPostLabel.TabIndex = 0;
            this.commentOnNewPostLabel.Text = "새 글에 댓글 달기";
            // 
            // console_Panel
            // 
            this.console_Panel.Controls.Add(this.console);
            this.console_Panel.Controls.Add(this.console_ConsoleLabel);
            this.console_Panel.Location = new System.Drawing.Point(12, 150);
            this.console_Panel.Name = "console_Panel";
            this.console_Panel.Size = new System.Drawing.Size(269, 264);
            this.console_Panel.TabIndex = 10;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(0, 22);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(268, 240);
            this.console.TabIndex = 1;
            // 
            // console_ConsoleLabel
            // 
            this.console_ConsoleLabel.AutoSize = true;
            this.console_ConsoleLabel.Location = new System.Drawing.Point(6, 4);
            this.console_ConsoleLabel.Name = "console_ConsoleLabel";
            this.console_ConsoleLabel.Size = new System.Drawing.Size(37, 15);
            this.console_ConsoleLabel.TabIndex = 0;
            this.console_ConsoleLabel.Text = "콘솔";
            // 
            // selectCafe_Panel
            // 
            this.selectCafe_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectCafe_Panel.Controls.Add(this.selectCafe_SelectStatusLabel);
            this.selectCafe_Panel.Controls.Add(this.selectCafe_LoadStatusLabel);
            this.selectCafe_Panel.Controls.Add(this.selectCafe_SelectButton);
            this.selectCafe_Panel.Controls.Add(this.selectCafe_LoadButton);
            this.selectCafe_Panel.Controls.Add(this.selectCafe_ComboBox);
            this.selectCafe_Panel.Controls.Add(this.selectCafe_Label);
            this.selectCafe_Panel.Location = new System.Drawing.Point(287, 12);
            this.selectCafe_Panel.Name = "selectCafe_Panel";
            this.selectCafe_Panel.Size = new System.Drawing.Size(245, 131);
            this.selectCafe_Panel.TabIndex = 11;
            // 
            // selectCafe_SelectStatusLabel
            // 
            this.selectCafe_SelectStatusLabel.AutoSize = true;
            this.selectCafe_SelectStatusLabel.Location = new System.Drawing.Point(84, 88);
            this.selectCafe_SelectStatusLabel.Name = "selectCafe_SelectStatusLabel";
            this.selectCafe_SelectStatusLabel.Size = new System.Drawing.Size(107, 15);
            this.selectCafe_SelectStatusLabel.TabIndex = 5;
            this.selectCafe_SelectStatusLabel.Text = "확인해 주세요!";
            // 
            // selectCafe_LoadStatusLabel
            // 
            this.selectCafe_LoadStatusLabel.AutoSize = true;
            this.selectCafe_LoadStatusLabel.Location = new System.Drawing.Point(84, 57);
            this.selectCafe_LoadStatusLabel.Name = "selectCafe_LoadStatusLabel";
            this.selectCafe_LoadStatusLabel.Size = new System.Drawing.Size(107, 15);
            this.selectCafe_LoadStatusLabel.TabIndex = 4;
            this.selectCafe_LoadStatusLabel.Text = "불러와 주세요!";
            // 
            // selectCafe_SelectButton
            // 
            this.selectCafe_SelectButton.Location = new System.Drawing.Point(3, 83);
            this.selectCafe_SelectButton.Name = "selectCafe_SelectButton";
            this.selectCafe_SelectButton.Size = new System.Drawing.Size(75, 25);
            this.selectCafe_SelectButton.TabIndex = 3;
            this.selectCafe_SelectButton.Text = "확인";
            this.selectCafe_SelectButton.UseVisualStyleBackColor = true;
            this.selectCafe_SelectButton.Click += new System.EventHandler(this.selectCafe_SelectButton_Click);
            // 
            // selectCafe_LoadButton
            // 
            this.selectCafe_LoadButton.Location = new System.Drawing.Point(3, 52);
            this.selectCafe_LoadButton.Name = "selectCafe_LoadButton";
            this.selectCafe_LoadButton.Size = new System.Drawing.Size(75, 25);
            this.selectCafe_LoadButton.TabIndex = 2;
            this.selectCafe_LoadButton.Text = "불러오기";
            this.selectCafe_LoadButton.UseVisualStyleBackColor = true;
            this.selectCafe_LoadButton.Click += new System.EventHandler(this.selectCafe_LoadButton_Click);
            // 
            // selectCafe_ComboBox
            // 
            this.selectCafe_ComboBox.FormattingEnabled = true;
            this.selectCafe_ComboBox.Location = new System.Drawing.Point(3, 23);
            this.selectCafe_ComboBox.Name = "selectCafe_ComboBox";
            this.selectCafe_ComboBox.Size = new System.Drawing.Size(234, 23);
            this.selectCafe_ComboBox.TabIndex = 1;
            // 
            // selectCafe_Label
            // 
            this.selectCafe_Label.AutoSize = true;
            this.selectCafe_Label.Location = new System.Drawing.Point(4, 5);
            this.selectCafe_Label.Name = "selectCafe_Label";
            this.selectCafe_Label.Size = new System.Drawing.Size(72, 15);
            this.selectCafe_Label.TabIndex = 0;
            this.selectCafe_Label.Text = "카페 선택";
            // 
            // selectCafe_loadCafeListTimer
            // 
            this.selectCafe_loadCafeListTimer.Interval = 1000;
            this.selectCafe_loadCafeListTimer.Tick += new System.EventHandler(this.selectCafe_loadCafeListTimer_Tick);
            // 
            // commentOnNewPost_loadPostTimer
            // 
            this.commentOnNewPost_loadPostTimer.Interval = 60000;
            this.commentOnNewPost_loadPostTimer.Tick += new System.EventHandler(this.commentOnNewPost_loadPostTimer_Tick);
            // 
            // commentOnNewPost_CommentTimer
            // 
            this.commentOnNewPost_CommentTimer.Interval = 1000;
            this.commentOnNewPost_CommentTimer.Tick += new System.EventHandler(this.commentOnNewPost_CommentTimer_Tick);
            // 
            // commentOnNewPost_CommentLabel
            // 
            this.commentOnNewPost_CommentLabel.AutoSize = true;
            this.commentOnNewPost_CommentLabel.Location = new System.Drawing.Point(137, 78);
            this.commentOnNewPost_CommentLabel.Name = "commentOnNewPost_CommentLabel";
            this.commentOnNewPost_CommentLabel.Size = new System.Drawing.Size(72, 15);
            this.commentOnNewPost_CommentLabel.TabIndex = 11;
            this.commentOnNewPost_CommentLabel.Text = "댓글 내용";
            // 
            // commentOnNewPost_CommentTextBox
            // 
            this.commentOnNewPost_CommentTextBox.Location = new System.Drawing.Point(137, 97);
            this.commentOnNewPost_CommentTextBox.Multiline = true;
            this.commentOnNewPost_CommentTextBox.Name = "commentOnNewPost_CommentTextBox";
            this.commentOnNewPost_CommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentOnNewPost_CommentTextBox.Size = new System.Drawing.Size(100, 112);
            this.commentOnNewPost_CommentTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 426);
            this.Controls.Add(this.selectCafe_Panel);
            this.Controls.Add(this.console_Panel);
            this.Controls.Add(this.commentOnNewPost_Panel);
            this.Controls.Add(this.login_Panel);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.login_Panel.ResumeLayout(false);
            this.login_Panel.PerformLayout();
            this.commentOnNewPost_Panel.ResumeLayout(false);
            this.commentOnNewPost_Panel.PerformLayout();
            this.console_Panel.ResumeLayout(false);
            this.console_Panel.PerformLayout();
            this.selectCafe_Panel.ResumeLayout(false);
            this.selectCafe_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label login_LoginLabel;
        private System.Windows.Forms.TextBox login_IdTextBox;
        private System.Windows.Forms.TextBox login_PasswordTextBox;
        private System.Windows.Forms.Label login_IdLabel;
        private System.Windows.Forms.Label login_PasswordLabel;
        private System.Windows.Forms.Button login_LoginButton;
        private System.Windows.Forms.Label login_StatusLabel;
        private System.Windows.Forms.Panel login_Panel;
        private System.Windows.Forms.Panel commentOnNewPost_Panel;
        private System.Windows.Forms.Label commentOnNewPostLabel;
        private System.Windows.Forms.Label commentOnNewPost_boardListLabel;
        private System.Windows.Forms.Panel commentOnNewPost_BoardListPanel;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Button commentOnNewPost_StartButton;
        private System.Windows.Forms.TextBox commentOnNewPost_TitleFilterTextBox;
        private System.Windows.Forms.Label commentOnNewPost_TitleFilterLabel;
        private System.Windows.Forms.Panel console_Panel;
        private System.Windows.Forms.Label console_ConsoleLabel;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button login_PasswordShowButton;
        private System.Windows.Forms.Panel selectCafe_Panel;
        private System.Windows.Forms.Label selectCafe_Label;
        private System.Windows.Forms.ComboBox selectCafe_ComboBox;
        private System.Windows.Forms.Button selectCafe_LoadButton;
        private System.Windows.Forms.Timer selectCafe_loadCafeListTimer;
        private System.Windows.Forms.Label selectCafe_SelectStatusLabel;
        private System.Windows.Forms.Label selectCafe_LoadStatusLabel;
        private System.Windows.Forms.Button selectCafe_SelectButton;
        private System.Windows.Forms.Button commentOnNewPost_LoadBoardListButton;
        private System.Windows.Forms.Label commentOnNewPost_BoardListLoadStatusLabel;
        private System.Windows.Forms.Timer commentOnNewPost_loadPostTimer;
        private System.Windows.Forms.Timer commentOnNewPost_CommentTimer;
        private System.Windows.Forms.TextBox commentOnNewPost_CommentTextBox;
        private System.Windows.Forms.Label commentOnNewPost_CommentLabel;
    }
}

