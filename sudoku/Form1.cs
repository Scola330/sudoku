namespace sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";

            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
            label17.Text = " ";
            label18.Text = " ";
            label19.Text = " ";

            label20.Text = " ";
            label21.Text = " ";
            label22.Text = " ";
            label23.Text = " ";
            label24.Text = " ";
            label25.Text = " ";
            label26.Text = " ";
            label27.Text = " ";
            label28.Text = " ";
            label29.Text = " ";

            label30.Text = " ";
            label31.Text = " ";
            label32.Text = " ";
            label33.Text = " ";
            label34.Text = " ";
            label35.Text = " ";
            label36.Text = " ";
            label37.Text = " ";
            label38.Text = " ";
            label39.Text = " ";

            label40.Text = " ";
            label41.Text = " ";
            label42.Text = " ";
            label43.Text = " ";
            label44.Text = " ";
            label45.Text = " ";
            label46.Text = " ";
            label47.Text = " ";
            label48.Text = " ";
            label49.Text = " ";

            label50.Text = " ";
            label51.Text = " ";
            label52.Text = " ";
            label53.Text = " ";
            label54.Text = " ";
            label55.Text = " ";
            label56.Text = " ";
            label57.Text = " ";
            label58.Text = " ";
            label59.Text = " ";

            label60.Text = " ";
            label61.Text = " ";
            label62.Text = " ";
            label63.Text = " ";
            label64.Text = " ";
            label65.Text = " ";
            label66.Text = " ";
            label67.Text = " ";
            label68.Text = " ";
            label69.Text = " ";

            label70.Text = " ";
            label71.Text = " ";
            label72.Text = " ";
            label73.Text = " ";
            label74.Text = " ";
            label75.Text = " ";
            label76.Text = " ";
            label77.Text = " ";
            label78.Text = " ";
            label79.Text = " ";

            label80.Text = " ";
            label81.Text = " ";


        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void gra(object sender, EventArgs e)
        {
            int liczbaR = (int)rowselect.Value;
            int liczbaC = (int)columnselect.Value;
            int liczbaB = (int)blockselect.Value;
            int liczbaI = (int)insert.Value;

            if (liczbaR == 1)
            {
                if (liczbaC == 1)
                {
                    if (liczbaB == 1)
                    {
                        label1.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label2.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label3.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label4.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label5.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label6.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label7.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label8.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label9.Text = liczbaI.ToString();
                    }
                }

                else if (liczbaC == 2)
                {
                    if (liczbaB == 1)
                    {
                        label10.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label11.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label12.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label13.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label14.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label15.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label16.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label17.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label18.Text = liczbaI.ToString();
                    }
                }

                else if (liczbaC == 3)
                {
                    if (liczbaB == 1)
                    {
                        label19.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label20.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label21.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label22.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label23.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label24.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label25.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label26.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label27.Text = liczbaI.ToString();
                    }
                }

            }

            else if (liczbaR == 2)
            {
                if (liczbaC == 1)
                {
                    if (liczbaB == 1)
                    {
                        label28.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label29.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label30.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label31.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label32.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label33.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label34.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label35.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label36.Text = liczbaI.ToString();
                    }
                }

                else if (liczbaC == 2)
                {
                    if (liczbaB == 1)
                    {
                        label37.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label38.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label39.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label40.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label41.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label42.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label43.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label44.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label45.Text = liczbaI.ToString();
                    }
                }

                else if (liczbaC == 3)
                {
                    if (liczbaB == 1)
                    {
                        label46.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 2)
                    {
                        label47.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 3)
                    {
                        label48.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 4)
                    {
                        label49.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 5)
                    {
                        label50.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 6)
                    {
                        label51.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 7)
                    {
                        label52.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 8)
                    {
                        label53.Text = liczbaI.ToString();
                    }
                    else if (liczbaB == 9)
                    {
                        label54.Text = liczbaI.ToString();
                    }
                }

                else if (liczbaR == 3)
                {
                    if (liczbaC == 1)
                    {
                        if (liczbaB == 1)
                        {
                            label55.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 2)
                        {
                            label56.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 3)
                        {
                            label57.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 4)
                        {
                            label58.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 5)
                        {
                            label59.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 6)
                        {
                            label60.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 7)
                        {
                            label61.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 8)
                        {
                            label62.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 9)
                        {
                            label63.Text = liczbaI.ToString();
                        }
                    }

                    else if (liczbaC == 2)
                    {
                        if (liczbaB == 1)
                        {
                            label64.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 2)
                        {
                            label65.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 3)
                        {
                            label66.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 4)
                        {
                            label67.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 5)
                        {
                            label68.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 6)
                        {
                            label69.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 7)
                        {
                            label70.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 8)
                        {
                            label71.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 9)
                        {
                            label72.Text = liczbaI.ToString();
                        }
                    }

                    else if (liczbaC == 3)
                    {
                        if (liczbaB == 1)
                        {
                            label73.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 2)
                        {
                            label74.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 3)
                        {
                            label75.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 4)
                        {
                            label76.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 5)
                        {
                            label77.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 6)
                        {
                            label78.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 7)
                        {
                            label79.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 8)
                        {
                            label80.Text = liczbaI.ToString();
                        }
                        else if (liczbaB == 9)
                        {
                            label81.Text = liczbaI.ToString();
                        }
                    }

                }
            }
        }
    }
}
