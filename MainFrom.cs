using System;
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            TextChanged();
            string str = textBoxOld.Text;
            textBoxOld.Text = textBoxNew.Text;
            textBoxNew.Text = str;
        }
        new private void TextChanged()
        {
            TextStkNew.Push(textBoxNew.Text);
            TextStkOld.Push(textBoxOld.Text);
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (TextStkNew.Count != 0)
            {
                textBoxNew.Text = (string)TextStkNew.Peek();
                textBoxOld.Text = (string)TextStkOld.Peek();
                TextStkNew.Pop();
                TextStkOld.Pop();
            }
            else
            {
                textBoxNew.Text = "";
                textBoxOld.Text = "";
            }
        }

        private void trackBarOld_Scroll(object sender, EventArgs e)
        {
            this.labelOld.Text = Tonality.intDic[this.trackBarOld.Value];
        }

        private void trackBarNew_Scroll(object sender, EventArgs e)
        {
            this.labelNew.Text = Tonality.intDic[this.trackBarNew.Value];

        }

        private void labelOld_Click(object sender, EventArgs e)
        {

        }
    }
}
