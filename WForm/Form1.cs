namespace WForm
{
    public partial class Form1 : Form
    {
        public List<PictureBox> pictureBoxesMore400 = new List<PictureBox>();
        public List<PictureBox> pictureBoxesLess400 = new List<PictureBox>();
        public Random random = new Random();
        public int Counter = 0;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 5000;
            timer1.Start();

            timer2.Interval = 10;
            timer2.Start();
            
            timer3.Interval = 100;
            timer3.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("E:\\.Leskiv_Dmytro\\PROGRAMMING\\1.1_WinForms_C#\\Homeworks\\Homework_4\\2_WForm\\stadionOlymp.jpg");
            BackgroundImage = image;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox();
            picture.Location = new Point(random.Next(0, 800), 540);

            picture.Image = Image.FromFile("E:\\.Leskiv_Dmytro\\PROGRAMMING\\1.1_WinForms_C#\\Homeworks\\Homework_4\\2_WForm\\MyBall.png");
            picture.Size = new Size(picture.Image.Width, picture.Image.Height);

            picture.BackColor = Color.Transparent;

            if(picture.Location.X >= 400) pictureBoxesMore400.Add(picture);
            else if(picture.Location.X < 400) pictureBoxesLess400.Add(picture);

            picture.Click += PictureBoxClick;
            this.Controls.Add(picture);
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;

            if (picture.Location.X >= 400) pictureBoxesMore400.Remove(picture);
            else if (picture.Location.X < 400) pictureBoxesLess400.Remove(picture);
            this.Controls.Remove((PictureBox)sender);

            Counter++;
            label2.Text = Counter.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Location < 400
            foreach (var picture in pictureBoxesLess400)
            {
                if (picture.Location.Y < 400)
                {
                    picture.Location = new Point(picture.Location.X + 1, picture.Location.Y - 2);
                    continue;
                }
                else if (picture.Location.Y < 200)
                {
                    picture.Location = new Point(picture.Location.X + 1, picture.Location.Y - 1);
                    continue;
                }
                picture.Location = new Point(picture.Location.X + 1, picture.Location.Y - 3);
            }
            
            // Location >= 400
            foreach (var picture in pictureBoxesMore400)
            {
                if (picture.Location.Y < 400)
                {
                    picture.Location = new Point(picture.Location.X - 1, picture.Location.Y - 2);
                    continue;
                }
                else if (picture.Location.Y < 200)
                {
                    picture.Location = new Point(picture.Location.X - 1, picture.Location.Y - 1);
                    continue;
                }
                picture.Location = new Point(picture.Location.X - 1, picture.Location.Y - 3);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (var picture in pictureBoxesLess400)
            {
                var tmpPicture = picture;
                if ((tmpPicture.Location.Y < 0) || (tmpPicture.Location.X > BackgroundImage?.Width))
                {
                    pictureBoxesLess400.Remove(tmpPicture);
                    this.Controls.Remove(tmpPicture);
                }
            }
            
            foreach (var picture in pictureBoxesMore400)
            {
                var tmpPicture = picture;
                if ((tmpPicture.Location.Y < 0) || (tmpPicture.Location.X < 0))
                {
                    pictureBoxesMore400.Remove(tmpPicture);
                    this.Controls.Remove(tmpPicture);
                }
            }
        }
    }
}
