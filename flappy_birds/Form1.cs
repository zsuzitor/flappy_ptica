﻿using System;
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


       /* int column1_top = 0;
        int column1_left = 763;
        int column2_top = 386;
        int column2_left = 763;
        */

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
                //Form1_Load(null, null);
                // this.Close();
                timer1.Enabled = false;

            // if(bird_form.Top<=column1_form.Bottom&&)

        }

        //чекнуть краш
        private bool test_stolknovenii()
        {
            if (bird_form.Top <= 0)
                return false;
            if (bird_form.Bottom >= panel1.Bottom)
                return  false;
            for(int i=0;i< coll_list.Count;++i)
            {
                if(coll_list[i].number<4)
                {
                    if (bird_form.Top <= coll_list[i].bott && bird_form.Right >= coll_list[i].left && bird_form.Right <= coll_list[i].right)
                    {
                        //MessageBox.Show("1");
                        return false;
                    }
                        
                }

                else
                {

                    if (bird_form.Bottom >= coll_list[i].top && bird_form.Right >= coll_list[i].left && bird_form.Right <= coll_list[i].right)
                    {

                        //MessageBox.Show("2");
                        return false;
                    }
                        
                }



                if (bird_form.Right >= coll_list[i].right && bird_form.Right <= coll_list[i].right + 2&& coll_list[i].number<4)
                {
                    int a = Convert.ToInt32(s4et.Text);
                    s4et.Text = (++a).ToString();
                }


            }
           



            return true;
        }


        private void dvig_column_otrisovka()
        {

            for(int i=0;i<coll_list.Count;++i)
            {
                if (coll_list[i].left > 0)
                {
                    coll_list[i].left -= 3;
                    coll_list[i].right -= 3;
                }
                else
                {
                    //перерисовать
                    coll_list[i].left = 763;
                    coll_list[i].right = 763 + 50;
                    Random rand = new Random();
                    rand.Next(0, 10);


                }

            }


            foreach(var i in panel1.Controls)
            {
                if(i is PictureBox)
                {
                    PictureBox tmp = (PictureBox)i;
                    if(tmp.Name.IndexOf("column") !=-1&& tmp.Name.IndexOf("_form") != -1)//"column"+ itt + "_form"
                    {
                        char tmp_str = tmp.Name[6];
                        int nomer_coll =(int)char.GetNumericValue(tmp_str);
                        
                        foreach(var b in coll_list)
                        {
                            if(b.number== nomer_coll)
                            {
                                tmp.Top = b.top;
                                tmp.Left = b.left;
                            }
                            

                        }
                       

                    }

                }

            }
            
                
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            bird_form.Image = Image.FromFile("bird.jpg");
            bird_form.SizeMode = PictureBoxSizeMode.StretchImage;
            
              /*  column1_form.Image = Image.FromFile("column.PNG");
            column1_form.SizeMode = PictureBoxSizeMode.StretchImage;
            column2_form.Image = Image.FromFile("column.PNG");
            column2_form.SizeMode = PictureBoxSizeMode.StretchImage;*/
            for(int i=0;i<3;++i)
            {
                int itt = i+1;
                coll_list.Add(new coll(0, 200, 763+150*i, 763+50 + 150 * i, itt));
                PictureBox a = new PictureBox();
                a.Image = Image.FromFile("column.PNG");
                a.SizeMode = PictureBoxSizeMode.StretchImage;
                a.Height = coll_list[i].bott;
                a.Width = coll_list[i].right- coll_list[i].left;
                a.Top = coll_list[i].top;
                a.Left = coll_list[i].left;
                
                a.Name = "column"+ itt + "_form";
                panel1.Controls.Add(a);

            }
            for (int i = 3; i < 6; ++i)
            {
                int itt = i+1;
                coll_list.Add(new coll(0 + 356, 200+356, 763 + 150 * (i-3), 763 + 50 + 150 * (i-3), i+1));
                PictureBox a = new PictureBox();
                a.Image= Image.FromFile("column.PNG");
                a.SizeMode = PictureBoxSizeMode.StretchImage;
                a.Height = coll_list[i].bott;
                a.Width = coll_list[i].right - coll_list[i].left;
                a.Top = coll_list[i].top;
                a.Left = coll_list[i].left;

                a.Name = "column" + itt + "_form";
                panel1.Controls.Add(a);

            }
            var th = coll_list;
           /* column1_form.Left = column1_left;
            column2_form.Left = column2_left;
            column1_form.Top = column1_top;
            column2_form.Top = column2_top;*/

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                
                bird_form.Top -=60;

            }
            if (e.KeyCode == Keys.Left)
            {
                if (bird_form.Left-20>0)
                bird_form.Left -= 20;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (bird_form.Left + 70 < panel1.Right)
                    bird_form.Left += 20;

            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
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
