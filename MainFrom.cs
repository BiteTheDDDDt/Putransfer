using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Putransfer
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonTransferRight_Click(object sender, EventArgs e)
        {

        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBackTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ButtonBackTip_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            string str = textBoxOld.Text;
            textBoxOld.Text = textBoxNew.Text;
            textBoxNew.Text = str;
            TextChanged();
        }

        private void TextChanged()
        {
            TextStkNew.Push(textBoxNew.Text);
            TextStkOld.Push(textBoxOld.Text);
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if(TextStkNew.Count!=0)
            {
                TextStkNew.Pop();
                TextStkOld.Pop();
            }
            if (TextStkNew.Count != 0)
            {
                textBoxNew.Text = (string)TextStkNew.Peek();
                textBoxOld.Text = (string)TextStkOld.Peek();
            }
            else
            {
                textBoxNew.Text = "";
                textBoxOld.Text = "";
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
