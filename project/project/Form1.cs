namespace project
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            Hidehomepage();
            picturesale.Hide();
            picturesale2.Hide();
            buttonback.Hide();
            button4.Hide();
        }

        private void backhome()
        {
            button1.Show();
            button2.Show();
            button3.Show();
            picturesale.Hide();
            label1.Show();
            label12.Show();

        }
        private void hidelandtext()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();



        } // ไฟล์ไว้ซ่อนชื่อ สัตว์บก
        private LandAnimal dog = new LandAnimal("สุนัข");
        private LandAnimal dog2 = new LandAnimal("สุนัข");
        private LandAnimal cat = new LandAnimal("แมว");
        private void landtext()
        {
            label2.Text = "สุนัข";
            label3.Text = "Golden";
            label4.Text = "ราคา  15,000";
            dog.price = 15_000;
            dog.gene = "Golden";

            label5.Text = "สุนัข";
            label6.Text = "Border collie";
            label7.Text = "ราคา  45,000";
            dog2.price = 45_5000;
            dog2.gene = "Border collie";

            label8.Text = "แมว";
            label9.Text = "ราคา  25,000";
            label10.Text = "British Shorthair";
            cat.price = 25_000;
            cat.gene = "British SHorthair";

        }  // ข้อมูลของสัตว์บก  

        private ReptileAnimal snake = new ReptileAnimal("งู");
        private ReptileAnimal snake2 = new ReptileAnimal("งู");
        private ReptileAnimal chameleon = new ReptileAnimal("กิ้งก่า");
        private void Reptiletext()
        {
            label2.Text = "งู";
            label3.Text = "Slaty grey";
            label4.Text = "ราคา  7,000";
            snake.price = 7_000;
            snake.gene = "Slaty Grey";

            label5.Text = "กิ้งก่า";
            label6.Text = "Veiled chameleon";
            label7.Text = "ราคา  5,000";
            chameleon.price = 5_000;
            chameleon.gene = "Veiled chameleon";

            label8.Text = "งู";
            label9.Text = "ราคา  12,000";
            label10.Text = "Milk Snakes";
            snake2.price = 12_000;
            snake2.gene = "Milk Snakes";
        } // ข้อมุลของสัตว์เลื้อคลาน 
        private PoultryAnimal bird = new PoultryAnimal("นก");
        private PoultryAnimal bird2 = new PoultryAnimal("นก");
        private PoultryAnimal bird3 = new PoultryAnimal("นก");

        private void Poultrytext()
        {
            label2.Text = "นก";
            label3.Text = "Blue and Gold Macaw";
            label4.Text = "ราคา  15,000";
            bird.price = 15_000;
            bird.gene = "Blue and Gold Macaw";

            label5.Text = "นก";
            label6.Text = "Sun conure";
            label7.Text = "ราคา  10,000";
            bird2.price = 10_000;
            bird2.gene = "Sun conure";

            label8.Text = "นก";
            label9.Text = "ราคา  12,000";
            label10.Text = "Hummingbird";
            bird3.price = 12_000;
            bird3.gene = "Hummingbird";

        } // ข้อมูลของสัตว์ปีก
        private void Hidehomepage()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            sale1.Hide();
            sale2.Hide();
            sale3.Hide();
            sale4.Hide();
            sale5.Hide();
            sale6.Hide();
            sale7.Hide();
            sale8.Hide();

            sale9.Hide();

        }
        private void hide123()
        {
            sale1.Hide();
            sale2.Hide();
            sale3.Hide();
        }
        private void hide456()
        {
            sale4.Hide();
            sale5.Hide();
            sale6.Hide();

        }
        private void hide789()
        {
            sale7.Hide();
            sale8.Hide();
            sale9.Hide();
        }



        private void Hidehomepage2()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();

            sale1.Hide();
            sale2.Hide();
            sale3.Hide();
            sale4.Hide();
            sale5.Hide();
            sale6.Hide();
            sale7.Hide();
            sale8.Hide();
            sale9.Hide();


            button1.Hide();
            button2.Hide();
            button3.Hide();

            showsard1.Hide();
            showsard2.Hide();
            showsard3.Hide();
        }
        private void Showinformationland()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            sale1.Show();
            sale2.Show();
            sale3.Show();

        }

        private void ShowinformationReptile()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            sale4.Show();
            sale5.Show();
            sale6.Show();

        }

        private void ShowinformationPoultry()
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            sale7.Show();
            sale8.Show();
            sale9.Show();

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int type;
        int sub_type;
        private void button1_Click(object sender, EventArgs e)
        {
            type = 1;
            showsard1.Image = Properties.Resources.golden;
            showsard2.Image = Properties.Resources.border_collie;
            showsard3.Image = Properties.Resources.British_Shorthair;
            Showinformationland();
            landtext();
            hide456();
            hide789();
            showsard1.Show();
            showsard2.Show();
            showsard3.Show();
            buttonback.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = 3;
            showsard1.Image = Properties.Resources.Blue_and_Gold_Macaw;
            showsard2.Image = Properties.Resources.sun_conure;
            showsard3.Image = Properties.Resources.hummingbird;
            ShowinformationPoultry();
            Poultrytext();
            hide123();
            hide456();
            showsard1.Show();
            showsard2.Show();
            showsard3.Show();
            buttonback.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = 2;
            showsard1.Image = Properties.Resources.slaty_grey;
            showsard2.Image = Properties.Resources.Veiled_Chameleon;
            showsard3.Image = Properties.Resources.Milk_Snakes;
            ShowinformationReptile();
            Reptiletext();
            hide789();
            hide123();
            showsard1.Show();
            showsard2.Show();
            showsard3.Show();
            buttonback.Hide();


        }

        private void showsard2_Click(object sender, EventArgs e)
        {


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void sale1_Click(object sender, EventArgs e)
        {
            sub_type = 1;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.golden;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.goldenInfo;
            button4.Show();

        }

        private void sale3_Click(object sender, EventArgs e)
        {
            sub_type = 3;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.border_collie;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.borderCollieInfo;
            button4.Show();

        }

        private void sale2_Click(object sender, EventArgs e)
        {
            sub_type = 2;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.British_Shorthair;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.BritishInfo;
            button4.Show();

        }

        private void sale4_Click(object sender, EventArgs e)
        {
            sub_type = 1;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.slaty_grey;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.slatyInfo;
            button4.Show();


        }

        private void sale5_Click(object sender, EventArgs e)
        {
            sub_type = 2;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.Milk_Snakes;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.milksnakeInfo;
            button4.Show();
        }

        private void sale6_Click(object sender, EventArgs e)
        {
            sub_type = 3;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.Veiled_Chameleon;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.veiledchameleonInfo;
            button4.Show();
        }

        private void sale7_Click(object sender, EventArgs e)
        {
            sub_type = 1;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.Blue_and_Gold_Macaw;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.BlueandGoldInfo;
            button4.Show();
        }

        private void sale8_Click(object sender, EventArgs e)
        {
            sub_type = 2;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.hummingbird;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.Hummingbirdinfo;
            button4.Show();


        }

        private void sale9_Click(object sender, EventArgs e)
        {
            sub_type = 3;
            Hidehomepage();
            Hidehomepage2();
            picturesale.Image = Properties.Resources.sun_conure;
            picturesale.Show();
            buttonback.Show();
            picturesale2.Show();
            picturesale2.Image = Properties.Resources.SunConureInfo;
            button4.Show();

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            button4.Hide();
            backhome();
            picturesale2.Hide();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            bool canWrite;
            if (type == 1)
            {
                if (sub_type == 1)
                {
                    canWrite = csv.SavetoFile(dog);
                }
                else if (sub_type == 2)
                {
                    canWrite = csv.SavetoFile(cat);
                }
                else
                {
                    canWrite = csv.SavetoFile(dog2);
                }
            }
            else if (type == 2)
            {
                if (sub_type == 1)
                {
                    canWrite = csv.SavetoFile(snake);
                }
                else if (sub_type == 2)
                {
                    canWrite = csv.SavetoFile(snake2);
                }
                else
                {
                    canWrite = csv.SavetoFile(chameleon);
                }
            }
            else
            {
                if (sub_type == 1)
                {
                    canWrite = csv.SavetoFile(bird);
                }
                else if (sub_type == 2)
                {
                    canWrite = csv.SavetoFile(bird3);
                }
                else
                {
                    canWrite = csv.SavetoFile(bird2);
                }
            }
            if (canWrite)
            {
                MessageBox.Show("เขียนไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("เขียนไฟล์ไม่สำเร็จ");
            }
            MessageBox.Show("Buy Success");
            this.Close();
        }

        private void showsard3_Click(object sender, EventArgs e)
        {

        }
    }
}
