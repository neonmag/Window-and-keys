namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (this.Location.Y + 50 < Screen.PrimaryScreen.Bounds.Height)
                this.Location = new Point(this.Location.X, this.Location.Y + 50);
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (this.Location.Y - 50 > 0)
                    this.Location = new Point(this.Location.X, this.Location.Y - 50);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (this.Location.X - 50 > 0)
                    this.Location = new Point(this.Location.X - 50, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (this.Location.X + 50 < Screen.PrimaryScreen.Bounds.Width)
                    this.Location = new Point(this.Location.X + 50, this.Location.Y);
            }
        }
    }
}