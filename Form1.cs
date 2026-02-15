using System.Drawing.Printing;
using System.Net.Http.Headers;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateTetrisBlock(PaintEventArgs e)
        {
            byte[,] block = new byte[22, 12];
                for (byte i = 0; i < 22; i++)
                {
                    for (byte j = 0; j < 12; j++)
                    {
                        byte outline = 1;
                        if (j == 0 || j == 11 ) block[i, j] = outline;
                        else if (i == 0 || i == 21) block[i, j] = outline;
                        else block[i, j] = 0;
                        CreateBlockView(e, i, j, block);
                    }
                };
        }
        private void CreateBlockView(PaintEventArgs e, byte i, byte j, byte [,] block) {
            SolidBrush grayBrush = new SolidBrush(Color.Gray);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Black);

            // Creat location and size of rectangle.
            byte blockIndex = 40;

            int x = blockIndex;
            if (j != 0) x += j * blockIndex;

            int y = blockIndex;
            if (i != 0) y += i * blockIndex; 

            int width = blockIndex;
            int height = blockIndex;
            Rectangle rect = new Rectangle(x, y, width, height);

            // Draw rectangle to screen.
            if (block[i, j] == 1)
            {
                e.Graphics.FillRectangle(grayBrush, rect);
                e.Graphics.DrawRectangle(pen, x, y, width, height);
            }
            else
            {
                e.Graphics.FillRectangle(whiteBrush, rect);
                e.Graphics.DrawRectangle(pen, x, y, width, height);
            }
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
            CreateTetrisBlock(e);
            //NextPiecePanel(e);
        }
    }
}
