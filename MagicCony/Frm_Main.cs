using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCony
{
    public partial class Frm_Main : Form
    {
        public static PictureBox Tem_PictB = new PictureBox();
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = Properties.Resources.min1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = null;
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void ImageSwitch(object sender, int n, int ns)
        {
            Tem_PictB = (PictureBox)sender;
            switch(n)
            {
                case 0:
                    {
                        Tem_PictB.Image = null;
                        if (ns == 0)
                            Tem_PictB.Image = Properties.Resources.min2;
                        if (ns == 1)
                            Tem_PictB.Image = Properties.Resources.min1;
                        break;
                    }
                case 1:
                    {
                        Tem_PictB.Image = null;
                        if (ns == 0)
                            Tem_PictB.Image = Properties.Resources.close2;
                        if (ns == 1)
                            Tem_PictB.Image = Properties.Resources.close1;
                        break;
                    }
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            // 设置鼠标移入后按钮的图片
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 0);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            // 设置鼠标移出后按钮的图片
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 1);
        }

        public void FrmClickMeans(Form Frm_Tem, int n)
        {
            switch(n)
            {
                case 0:
                    Frm_Tem.WindowState = FormWindowState.Minimized;    // 窗体最小化
                    break;
                case 1:
                    this.WindowState = FormWindowState.Minimized;       // 设置当前窗体最小化
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 设置鼠标单击时按钮的图片
            FrmClickMeans(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
