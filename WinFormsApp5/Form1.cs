namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            
                Random random = new Random();
                int maxWidth = this.ClientSize.Width - label1.Width;
                int maxHeight = this.ClientSize.Height - label1.Height;

                int newX = random.Next(maxWidth);
                int newY = random.Next(maxHeight);

            label1.Location = new System.Drawing.Point(newX, newY);
            
        }
    }
}