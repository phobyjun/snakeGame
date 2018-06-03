namespace snakeProject
{
    partial class snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snake));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.explPanel = new System.Windows.Forms.Panel();
            this.escPic = new System.Windows.Forms.PictureBox();
            this.expl3 = new System.Windows.Forms.Label();
            this.spacePic = new System.Windows.Forms.PictureBox();
            this.expl2 = new System.Windows.Forms.Label();
            this.arrowPic = new System.Windows.Forms.PictureBox();
            this.expl1 = new System.Windows.Forms.Label();
            this.UIpanel = new System.Windows.Forms.Panel();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.TextBox();
            this.explPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).BeginInit();
            this.UIpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(576, 576);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // explPanel
            // 
            this.explPanel.BackColor = System.Drawing.Color.Beige;
            this.explPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.explPanel.Controls.Add(this.escPic);
            this.explPanel.Controls.Add(this.expl3);
            this.explPanel.Controls.Add(this.spacePic);
            this.explPanel.Controls.Add(this.expl2);
            this.explPanel.Controls.Add(this.arrowPic);
            this.explPanel.Controls.Add(this.expl1);
            this.explPanel.Location = new System.Drawing.Point(606, 12);
            this.explPanel.Name = "explPanel";
            this.explPanel.Size = new System.Drawing.Size(221, 450);
            this.explPanel.TabIndex = 0;
            this.explPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // escPic
            // 
            this.escPic.Image = ((System.Drawing.Image)(resources.GetObject("escPic.Image")));
            this.escPic.Location = new System.Drawing.Point(56, 364);
            this.escPic.Name = "escPic";
            this.escPic.Size = new System.Drawing.Size(98, 78);
            this.escPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.escPic.TabIndex = 5;
            this.escPic.TabStop = false;
            // 
            // expl3
            // 
            this.expl3.AutoSize = true;
            this.expl3.Font = new System.Drawing.Font("나눔바른고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expl3.Location = new System.Drawing.Point(46, 302);
            this.expl3.Name = "expl3";
            this.expl3.Size = new System.Drawing.Size(125, 55);
            this.expl3.TabIndex = 4;
            this.expl3.Text = "Stop";
            // 
            // spacePic
            // 
            this.spacePic.Image = ((System.Drawing.Image)(resources.GetObject("spacePic.Image")));
            this.spacePic.Location = new System.Drawing.Point(33, 239);
            this.spacePic.Name = "spacePic";
            this.spacePic.Size = new System.Drawing.Size(153, 71);
            this.spacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spacePic.TabIndex = 3;
            this.spacePic.TabStop = false;
            // 
            // expl2
            // 
            this.expl2.AutoSize = true;
            this.expl2.Font = new System.Drawing.Font("나눔바른고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expl2.Location = new System.Drawing.Point(43, 181);
            this.expl2.Name = "expl2";
            this.expl2.Size = new System.Drawing.Size(132, 55);
            this.expl2.TabIndex = 2;
            this.expl2.Text = "Start";
            // 
            // arrowPic
            // 
            this.arrowPic.Image = ((System.Drawing.Image)(resources.GetObject("arrowPic.Image")));
            this.arrowPic.Location = new System.Drawing.Point(31, 66);
            this.arrowPic.Name = "arrowPic";
            this.arrowPic.Size = new System.Drawing.Size(153, 105);
            this.arrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowPic.TabIndex = 1;
            this.arrowPic.TabStop = false;
            this.arrowPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // expl1
            // 
            this.expl1.AutoSize = true;
            this.expl1.Font = new System.Drawing.Font("나눔바른고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expl1.Location = new System.Drawing.Point(21, 8);
            this.expl1.Name = "expl1";
            this.expl1.Size = new System.Drawing.Size(184, 55);
            this.expl1.TabIndex = 1;
            this.expl1.Text = "Control";
            this.expl1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UIpanel
            // 
            this.UIpanel.BackColor = System.Drawing.Color.Beige;
            this.UIpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UIpanel.Controls.Add(this.score);
            this.UIpanel.Controls.Add(this.scoreBox);
            this.UIpanel.Location = new System.Drawing.Point(606, 483);
            this.UIpanel.Name = "UIpanel";
            this.UIpanel.Size = new System.Drawing.Size(221, 105);
            this.UIpanel.TabIndex = 0;
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.Beige;
            this.scoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreBox.Font = new System.Drawing.Font("나눔바른고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scoreBox.Location = new System.Drawing.Point(3, 42);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(211, 56);
            this.scoreBox.TabIndex = 0;
            this.scoreBox.TabStop = false;
            this.scoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Beige;
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score.Location = new System.Drawing.Point(56, 3);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 32);
            this.score.TabIndex = 1;
            this.score.TabStop = false;
            this.score.Text = "Score";
            this.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 600);
            this.Controls.Add(this.UIpanel);
            this.Controls.Add(this.explPanel);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "snake";
            this.Text = "Snake!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.explPanel.ResumeLayout(false);
            this.explPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).EndInit();
            this.UIpanel.ResumeLayout(false);
            this.UIpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel explPanel;
        private System.Windows.Forms.Panel UIpanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label expl1;
        private System.Windows.Forms.PictureBox arrowPic;
        private System.Windows.Forms.Label expl2;
        private System.Windows.Forms.PictureBox spacePic;
        private System.Windows.Forms.Label expl3;
        private System.Windows.Forms.PictureBox escPic;
        private System.Windows.Forms.TextBox score;
    }
}

