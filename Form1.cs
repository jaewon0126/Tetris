namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CreateTetrisPanel(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Creat location and size of rectangle.
            int x = 50;
            int y = 50;
            int width = 400;
            int height = 650;

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        }
        public void NextPiecePanel(PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Creat location and size of rectangle.
            int x = 500;
            int y = 50;
            int width = 150;
            int height = 150;

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CreateTetrisPanel(e);
            NextPiecePanel(e);
        }
    }
}
