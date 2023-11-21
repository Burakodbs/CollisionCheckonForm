namespace collisionCheckOnForm
{
    public partial class Form1 : Form
    {
        bool moveUp, moveDown, moveRight, moveLeft, moveUp2, moveDown2, moveRight2, moveLeft2;
        int height = 100, width = 100;
        int height2 = 100, width2 = 100;
        int speed = 15;
        public Form1()
        {
            InitializeComponent();
        }
        private void mainTimerEvent(object sender, EventArgs e)
        {
            if (moveUp == true && object2.Top > 0)
            {
                object2.Top -= speed;
            }
            if (moveDown == true && object2.Top < 505)
            {
                object2.Top += speed;
            }
            if (moveLeft == true && object2.Left > 0)
            {
                object2.Left -= speed;
            }
            if (moveRight == true && object2.Left < 812)
            {
                object2.Left += speed;
            }
            if (moveUp2 == true && object1.Top > 0)
            {
                object1.Top -= speed;
            }
            if (moveDown2 == true && object1.Top < 505)
            {
                object1.Top += speed;
            }
            if (moveLeft2 == true && object1.Left > 0)
            {
                object1.Left -= speed;
            }
            if (moveRight2 == true && object1.Left < 812)
            {
                object1.Left += speed;
            }
            if (object1.Location.X <= object2.Location.X + object2.Width && object1.Location.X + object1.Width >= object2.Location.X && object1.Location.Y - object1.Height <= object2.Location.Y && object1.Location.Y >= object2.Location.Y - object2.Height)
            {
                label1.Text = "COLLISION OCCURRED.";
            }
            else
            {
                label1.Text = "COLLISION DID NOT OCCURRED";
            }
        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp2 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown2 = true;
            }
            if (e.KeyCode == Keys.A)
            {
                moveLeft2 = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight2 = true;
            }
        }
        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp2 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown2 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                moveLeft2 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight2 = false;
            }
        }

        private void object1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.White);
            object1.Height = height;
            object1.Width = width;

            g.DrawRectangle(pen1, 0, 0, width, height);
        }

        private void object2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.White);
            object2.Height =    height2;
            object2.Width = width2;

            g.DrawRectangle(pen1, 0, 0, width2, height2);
        }


    }
}