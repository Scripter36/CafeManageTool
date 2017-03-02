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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_PasswordShowButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.commentOnNewPost_StartButton = new System.Windows.Forms.Button();
            this.commentOnNewPost_TitleFilterTextBox = new System.Windows.Forms.TextBox();
            this.commentOnNewPost_TitleFilterLabel = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.commentOnNewPost_boardListLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.commentOnNewPostLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.console = new System.Windows.Forms.TextBox();
            this.console_ConsoleLabel = new System.Windows.Forms.Label();
            this.selectCafe = new System.Windows.Forms.Panel();
            this.selectCafe_LoadButton = new System.Windows.Forms.Button();
            this.selectCafe_ComboBox = new System.Windows.Forms.ComboBox();
            this.selectCafe_Label = new System.Windows.Forms.Label();
            this.selectCafe_loadCafeListTimer = new System.Windows.Forms.Timer(this.components);
            this.selectCafe_SelectButton = new System.Windows.Forms.Button();
            this.selectCafe_LoadStatusLabel = new System.Windows.Forms.Label();
            this.selectCafe_SelectStatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.selectCafe.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.login_PasswordShowButton);
            this.panel1.Controls.Add(this.login_IdTextBox);
            this.panel1.Controls.Add(this.login_StatusLabel);
            this.panel1.Controls.Add(this.login_LoginLabel);
            this.panel1.Controls.Add(this.login_LoginButton);
            this.panel1.Controls.Add(this.login_PasswordTextBox);
            this.panel1.Controls.Add(this.login_PasswordLabel);
            this.panel1.Controls.Add(this.login_IdLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 131);
            this.panel1.TabIndex = 8;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.commentOnNewPost_StartButton);
            this.panel2.Controls.Add(this.commentOnNewPost_TitleFilterTextBox);
            this.panel2.Controls.Add(this.commentOnNewPost_TitleFilterLabel);
            this.panel2.Controls.Add(this.separator1);
            this.panel2.Controls.Add(this.commentOnNewPost_boardListLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.commentOnNewPostLabel);
            this.panel2.Location = new System.Drawing.Point(287, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 131);
            this.panel2.TabIndex = 9;
            // 
            // commentOnNewPost_StartButton
            // 
            this.commentOnNewPost_StartButton.Location = new System.Drawing.Point(137, 81);
            this.commentOnNewPost_StartButton.Name = "commentOnNewPost_StartButton";
            this.commentOnNewPost_StartButton.Size = new System.Drawing.Size(75, 25);
            this.commentOnNewPost_StartButton.TabIndex = 8;
            this.commentOnNewPost_StartButton.Text = "시작";
            this.commentOnNewPost_StartButton.UseVisualStyleBackColor = true;
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
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(7, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 56);
            this.panel3.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.console);
            this.panel4.Controls.Add(this.console_ConsoleLabel);
            this.panel4.Location = new System.Drawing.Point(12, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 264);
            this.panel4.TabIndex = 10;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(0, 22);
            this.console.Multiline = true;
            this.console.Name = "console";
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
            // selectCafe
            // 
            this.selectCafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectCafe.Controls.Add(this.selectCafe_SelectStatusLabel);
            this.selectCafe.Controls.Add(this.selectCafe_LoadStatusLabel);
            this.selectCafe.Controls.Add(this.selectCafe_SelectButton);
            this.selectCafe.Controls.Add(this.selectCafe_LoadButton);
            this.selectCafe.Controls.Add(this.selectCafe_ComboBox);
            this.selectCafe.Controls.Add(this.selectCafe_Label);
            this.selectCafe.Location = new System.Drawing.Point(287, 12);
            this.selectCafe.Name = "selectCafe";
            this.selectCafe.Size = new System.Drawing.Size(245, 131);
            this.selectCafe.TabIndex = 11;
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
            // selectCafe_LoadStatusLabel
            // 
            this.selectCafe_LoadStatusLabel.AutoSize = true;
            this.selectCafe_LoadStatusLabel.Location = new System.Drawing.Point(84, 57);
            this.selectCafe_LoadStatusLabel.Name = "selectCafe_LoadStatusLabel";
            this.selectCafe_LoadStatusLabel.Size = new System.Drawing.Size(107, 15);
            this.selectCafe_LoadStatusLabel.TabIndex = 4;
            this.selectCafe_LoadStatusLabel.Text = "불러와 주세요!";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 426);
            this.Controls.Add(this.selectCafe);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.selectCafe.ResumeLayout(false);
            this.selectCafe.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label commentOnNewPostLabel;
        private System.Windows.Forms.Label commentOnNewPost_boardListLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Button commentOnNewPost_StartButton;
        private System.Windows.Forms.TextBox commentOnNewPost_TitleFilterTextBox;
        private System.Windows.Forms.Label commentOnNewPost_TitleFilterLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label console_ConsoleLabel;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button login_PasswordShowButton;
        private System.Windows.Forms.Panel selectCafe;
        private System.Windows.Forms.Label selectCafe_Label;
        private System.Windows.Forms.ComboBox selectCafe_ComboBox;
        private System.Windows.Forms.Button selectCafe_LoadButton;
        private System.Windows.Forms.Timer selectCafe_loadCafeListTimer;
        private System.Windows.Forms.Label selectCafe_SelectStatusLabel;
        private System.Windows.Forms.Label selectCafe_LoadStatusLabel;
        private System.Windows.Forms.Button selectCafe_SelectButton;
    }
}

