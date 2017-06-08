using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_birds
{
    public partial class Form1 : Form
    {
        public List<coll> coll_list = new List<coll>();


        int column1_top = 0;
        int column1_left = 763;
        int column2_top = 386;
        int column2_left = 763;


        public Form1()
        {
            InitializeComponent();
        }


        //тик
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool loose_stolkn = true;
            bird_form.Top += 2;
            //column1_form
            dvig_column_otrisovka();
            //обработать столконовение
            loose_stolkn=test_stolknovenii();

            if (!loose_stolkn)
                this.Close();

            // if(bird_form.Top<=column1_form.Bottom&&)

        }

        //чекнуть краш
        private bool test_stolknovenii()
        {
            if (bird_form.Top <= 0)
                return false;
            if (bird_form.Bottom >= panel1.Bottom)
                return  false;
            if(bird_form.Top<=column1_form.Bottom&& bird_form.Right >= column1_form.Left&& bird_form.Right<= column1_form.Right)
                return false;

            if (bird_form.Bottom >= column2_form.Top && bird_form.Right >= column2_form.Left && bird_form.Right <= column2_form.Right)
                return false;


            if (bird_form.Right >= column2_form.Right && bird_form.Right <= column2_form.Right + 2)
            {
                int a = Convert.ToInt32(s4et.Text);
                s4et.Text = (++a).ToString();
            }
                

                return true;
        }
        private void dvig_column_otrisovka()
        {
            if(column1_form.Left>0)
            {
                column1_form.Left -= 3;
                column2_form.Left -= 3;
            }
            else
            {
                //перерисовать
                column1_form.Left = 763;
                column2_form.Left = 763;
                Random rand = new Random();
                rand.Next(0,10);


            }
                
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            bird_form.Image = Image.FromFile("bird.jpg");
            bird_form.SizeMode = PictureBoxSizeMode.StretchImage;
            
                column1_form.Image = Image.FromFile("column.PNG");
            column1_form.SizeMode = PictureBoxSizeMode.StretchImage;
            column2_form.Image = Image.FromFile("column.PNG");
            column2_form.SizeMode = PictureBoxSizeMode.StretchImage;
            for(int i=0;i<3;++i)
            {
                coll_list.Add(new coll(column1_form.Top, column1_form.Bottom, column1_form.Left+150*i, column1_form.Right + 150 * i, i+1));
                PictureBox a = new PictureBox();

            }
            for (int i = 3; i < 6; ++i)
            {
                coll_list.Add(new coll(column1_form.Top + 356, column1_form.Bottom+356, column1_form.Left + 150 * i, column1_form.Right + 150 * i, i+1));

            }

            column1_form.Left = column1_left;
            column2_form.Left = column2_left;
            column1_form.Top = column1_top;
            column2_form.Top = column2_top;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                bird_form.Top -=60;

            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }
    }



    public class coll
    {
        public int top;
        public int bott;
        public int left;
        public int right;
        public int number;

        public coll(int a, int b, int c, int d, int g)
        {
            top = a;
            bott = b;
            left = c;
            right = d;
            number = g;
        }


    }
}
