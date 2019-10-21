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
            this.dSkinChart1 = new DSkin.Controls.DSkinChart();
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
            // dSkinChart1
            // 
            this.dSkinChart1.AppearanceStyle = DSkin.Controls.DSkinChart.AppearanceStyles.Bar_2D_Breeze_NoCrystal_NoGlow_NoBorder;
            this.dSkinChart1.Aurora = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(202)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(242))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(32)))), ((int)(((byte)(242))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(242)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(151)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(242)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(32)))), ((int)(((byte)(242))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(131)))), ((int)(((byte)(242))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(101)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(153)))), ((int)(((byte)(245)))))};
            this.dSkinChart1.Background.Highlight = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.dSkinChart1.Background.Lowlight = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dSkinChart1.BaseLineX = 0D;
            this.dSkinChart1.Breeze = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(166)))), ((int)(((byte)(231))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(184)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(231))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(231)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(166)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(166)))), ((int)(((byte)(231))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(231)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(166)))), ((int)(((byte)(226))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(181)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))))};
            this.dSkinChart1.ChartTitle.BackColor = System.Drawing.Color.White;
            this.dSkinChart1.ChartTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.ChartTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.dSkinChart1.ChartTitle.OffsetY = 0;
            this.dSkinChart1.ChartTitle.Show = true;
            this.dSkinChart1.ChartTitle.Text = "DSkinChart";
            this.dSkinChart1.ColorGuider.BackColor = System.Drawing.Color.White;
            this.dSkinChart1.ColorGuider.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.ColorGuider.ForeColor = System.Drawing.Color.Black;
            this.dSkinChart1.ColorGuider.Show = true;
            this.dSkinChart1.Crystal.Contraction = 0;
            this.dSkinChart1.Crystal.CoverFull = true;
            this.dSkinChart1.Crystal.Direction = DSkin.Controls.DSkinChart.Direction.TopBottom;
            this.dSkinChart1.Crystal.Enable = false;
            this.dSkinChart1.Fill.Color1 = System.Drawing.Color.Empty;
            this.dSkinChart1.Fill.Color2 = System.Drawing.Color.Empty;
            this.dSkinChart1.Fill.Color3 = System.Drawing.Color.Empty;
            this.dSkinChart1.Fill.ColorStyle = DSkin.Controls.DSkinChart.ColorStyles.Breeze;
            this.dSkinChart1.Fill.ShiftStep = 0;
            this.dSkinChart1.Fill.TextureEnable = false;
            this.dSkinChart1.Fill.TextureStyle = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
            this.dSkinChart1.LineConnectionRadius = 18;
            this.dSkinChart1.Location = new System.Drawing.Point(26, 101);
            this.dSkinChart1.MaxValueY = 0D;
            this.dSkinChart1.MinValueY = 0D;
            this.dSkinChart1.Name = "dSkinChart1";
            this.dSkinChart1.PeripheralLineColor = System.Drawing.Color.Gray;
            this.dSkinChart1.Shadow.Alpha = ((byte)(255));
            this.dSkinChart1.Shadow.Angle = 60F;
            this.dSkinChart1.Shadow.Color = System.Drawing.Color.Black;
            this.dSkinChart1.Shadow.Distance = 0;
            this.dSkinChart1.Shadow.Enable = false;
            this.dSkinChart1.Shadow.Hollow = false;
            this.dSkinChart1.Shadow.Radius = 3;
            this.dSkinChart1.Size = new System.Drawing.Size(577, 287);
            this.dSkinChart1.SpecLine.Color = System.Drawing.Color.Black;
            this.dSkinChart1.SpecLine.EnableTexture = false;
            this.dSkinChart1.SpecLine.HighLimit = 0;
            this.dSkinChart1.SpecLine.LowLimit = 0;
            this.dSkinChart1.SpecLine.Show = false;
            this.dSkinChart1.SpecLine.TextureStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.dSkinChart1.SpecLine.Width = 1;
            this.dSkinChart1.StarryNight = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(78))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(55)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(60)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(35)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(14)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(14)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(86)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(3)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))))};
            this.dSkinChart1.Stroke.Color1 = System.Drawing.Color.Empty;
            this.dSkinChart1.Stroke.Color2 = System.Drawing.Color.Empty;
            this.dSkinChart1.Stroke.Color3 = System.Drawing.Color.Empty;
            this.dSkinChart1.Stroke.ColorStyle = DSkin.Controls.DSkinChart.ColorStyles.Aurora;
            this.dSkinChart1.Stroke.ShiftStep = 0;
            this.dSkinChart1.Stroke.TextureEnable = true;
            this.dSkinChart1.Stroke.TextureStyle = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
            this.dSkinChart1.Stroke.Width = 0;
            this.dSkinChart1.TabIndex = 2;
            this.dSkinChart1.Text = "dSkinChart1";
            this.dSkinChart1.Tips.BackColor = System.Drawing.Color.White;
            this.dSkinChart1.Tips.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.Tips.ForeColor = System.Drawing.Color.Black;
            this.dSkinChart1.Tips.Show = true;
            this.dSkinChart1.Trend.End = new System.DateTime(2019, 10, 21, 9, 32, 9, 181);
            this.dSkinChart1.Trend.Start = new System.DateTime(2019, 10, 21, 9, 32, 9, 181);
            this.dSkinChart1.Trend.TimeSpan = DSkin.Controls.DSkinChart.TimeSpanTypes.Hour;
            this.dSkinChart1.Trend.ValueFormat = "hh:mm";
            this.dSkinChart1.XAxis.BackColor = System.Drawing.Color.White;
            this.dSkinChart1.XAxis.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.XAxis.ForeColor = System.Drawing.Color.Black;
            this.dSkinChart1.XAxis.LabelCount = 5;
            this.dSkinChart1.XAxis.RotateAngle = 30F;
            this.dSkinChart1.XAxis.SampleSize = 1;
            this.dSkinChart1.XAxis.Show = true;
            this.dSkinChart1.XAxis.UnitFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.XAxis.UnitText = "XAxis";
            this.dSkinChart1.XAxis.ValueFormat = "0.0";
            this.dSkinChart1.XLabels = new string[] {
        "string"};
            this.dSkinChart1.YAxis.BackColor = System.Drawing.Color.White;
            this.dSkinChart1.YAxis.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.YAxis.ForeColor = System.Drawing.Color.Black;
            this.dSkinChart1.YAxis.LabelCount = 5;
            this.dSkinChart1.YAxis.Show = true;
            this.dSkinChart1.YAxis.UnitFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dSkinChart1.YAxis.UnitText = "YAxis";
            this.dSkinChart1.YAxis.ValueFormat = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dSkinChart1);
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
        private DSkin.Controls.DSkinChart dSkinChart1;
    }
}

