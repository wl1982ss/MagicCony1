namespace MagicCony
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbox_System = new System.Windows.Forms.PictureBox();
            this.pbox_Clean = new System.Windows.Forms.PictureBox();
            this.pbox_Youhua = new System.Windows.Forms.PictureBox();
            this.pbox_STool = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Clean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Youhua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_STool)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pbox_STool);
            this.panel2.Controls.Add(this.pbox_Youhua);
            this.panel2.Controls.Add(this.pbox_Clean);
            this.panel2.Controls.Add(this.pbox_System);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 515);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(776, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            // 
            // pbox_System
            // 
            this.pbox_System.BackColor = System.Drawing.Color.Transparent;
            this.pbox_System.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_System.BackgroundImage")));
            this.pbox_System.Location = new System.Drawing.Point(284, 214);
            this.pbox_System.Name = "pbox_System";
            this.pbox_System.Size = new System.Drawing.Size(216, 77);
            this.pbox_System.TabIndex = 0;
            this.pbox_System.TabStop = false;
            // 
            // pbox_Clean
            // 
            this.pbox_Clean.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_Clean.BackgroundImage")));
            this.pbox_Clean.Location = new System.Drawing.Point(32, 418);
            this.pbox_Clean.Name = "pbox_Clean";
            this.pbox_Clean.Size = new System.Drawing.Size(107, 124);
            this.pbox_Clean.TabIndex = 1;
            this.pbox_Clean.TabStop = false;
            // 
            // pbox_Youhua
            // 
            this.pbox_Youhua.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Youhua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_Youhua.BackgroundImage")));
            this.pbox_Youhua.Location = new System.Drawing.Point(156, 418);
            this.pbox_Youhua.Name = "pbox_Youhua";
            this.pbox_Youhua.Size = new System.Drawing.Size(107, 124);
            this.pbox_Youhua.TabIndex = 2;
            this.pbox_Youhua.TabStop = false;
            // 
            // pbox_STool
            // 
            this.pbox_STool.BackColor = System.Drawing.Color.Transparent;
            this.pbox_STool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_STool.BackgroundImage")));
            this.pbox_STool.Location = new System.Drawing.Point(280, 418);
            this.pbox_STool.Name = "pbox_STool";
            this.pbox_STool.Size = new System.Drawing.Size(107, 124);
            this.pbox_STool.TabIndex = 3;
            this.pbox_STool.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "365系统加速器";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Clean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Youhua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_STool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbox_System;
        private System.Windows.Forms.PictureBox pbox_Clean;
        private System.Windows.Forms.PictureBox pbox_Youhua;
        private System.Windows.Forms.PictureBox pbox_STool;
    }
}

