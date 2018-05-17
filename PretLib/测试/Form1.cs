using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF[] ps = new PointF[1000];
            Bitmap map = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            this.listBox1.Items.Clear();

            for(int a = 0; a < ps.Length; a++)
            {
                ps[a] = Math.NorMalRandomPoint(this.pictureBox1.Width / 2, 50, this.pictureBox1.Height / 2, 10f, DateTime.Now.Millisecond);
                map.SetPixel(Convert.ToInt32(ps[a].X), Convert.ToInt32(ps[a].Y), Color.Red);
                this.listBox1.Items.Add(ps[a].ToString());
            }
            this.pictureBox1.Image = map;


        }
    }
}
