namespace WinFormTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dSkinButton1 = new DSkin.Controls.DSkinButton();
            this.dSkinTreeView1 = new DSkin.Controls.DSkinTreeView();
            this.dSkinBaseControl1 = new DSkin.Controls.DSkinBaseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinButton1
            // 
            this.dSkinButton1.AdaptImage = true;
            this.dSkinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.dSkinButton1.ButtonBorderColor = System.Drawing.Color.Gray;
            this.dSkinButton1.ButtonBorderWidth = 1;
            this.dSkinButton1.ButtonStyle = DSkin.DirectUI.ButtonStyles.Style2;
            this.dSkinButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dSkinButton1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinButton1.HoverImage = null;
            this.dSkinButton1.IsPureColor = false;
            this.dSkinButton1.Location = new System.Drawing.Point(61, 37);
            this.dSkinButton1.Name = "dSkinButton1";
            this.dSkinButton1.NormalImage = null;
            this.dSkinButton1.PressColor = System.Drawing.Color.Empty;
            this.dSkinButton1.PressedImage = null;
            this.dSkinButton1.Radius = 10;
            this.dSkinButton1.ShowButtonBorder = true;
            this.dSkinButton1.Size = new System.Drawing.Size(100, 40);
            this.dSkinButton1.TabIndex = 0;
            this.dSkinButton1.Text = "dSkinButton1";
            this.dSkinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dSkinButton1.TextPadding = 0;
            // 
            // dSkinTreeView1
            // 
            this.dSkinTreeView1.Location = new System.Drawing.Point(577, 85);
            this.dSkinTreeView1.Name = "dSkinTreeView1";
            this.dSkinTreeView1.Size = new System.Drawing.Size(216, 122);
            this.dSkinTreeView1.TabIndex = 1;
            this.dSkinTreeView1.Text = "dSkinTreeView1";
            // 
            // dSkinBaseControl1
            // 
            this.dSkinBaseControl1.Location = new System.Drawing.Point(389, 150);
            this.dSkinBaseControl1.Name = "dSkinBaseControl1";
            this.dSkinBaseControl1.Size = new System.Drawing.Size(100, 100);
            this.dSkinBaseControl1.TabIndex = 2;
            this.dSkinBaseControl1.Text = "dSkinBaseControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dSkinBaseControl1);
            this.Controls.Add(this.dSkinTreeView1);
            this.Controls.Add(this.dSkinButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dSkinTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinButton dSkinButton1;
        private DSkin.Controls.DSkinTreeView dSkinTreeView1;
        private DSkin.Controls.DSkinBaseControl dSkinBaseControl1;
    }
}

