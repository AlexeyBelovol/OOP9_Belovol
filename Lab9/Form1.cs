namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) && double.TryParse(textBoxB.Text, out double b))
            {
                Bitmap bitmap = new Bitmap(pictureBoxGraph.Width, pictureBoxGraph.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);

                // Draw coordinate system
                Pen axisPen = new Pen(Color.Black);
                g.DrawLine(axisPen, pictureBoxGraph.Width / 2, 0, pictureBoxGraph.Width / 2, pictureBoxGraph.Height);
                g.DrawLine(axisPen, 0, pictureBoxGraph.Height / 2, pictureBoxGraph.Width, pictureBoxGraph.Height / 2);

                // Draw axis labels
                Font font = new Font("Arial", 10);
                g.DrawString("Y", font, Brushes.Black, pictureBoxGraph.Width / 2 + 5, 5);
                g.DrawString("X", font, Brushes.Black, pictureBoxGraph.Width - 20, pictureBoxGraph.Height / 2 + 5);

                // Draw function
                Pen functionPen = new Pen(Color.Blue);

                int centerX = pictureBoxGraph.Width / 2;
                int centerY = pictureBoxGraph.Height / 2;

                for (double t = 0; t <= 2 * Math.PI; t += 0.01)
                {
                    double x = centerX + a * Math.Cos(t);
                    double y = centerY + b * Math.Sin(t);
                    bitmap.SetPixel((int)x, (int)y, Color.Blue);
                }

                pictureBoxGraph.Image = bitmap;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для a та b.");
            }
        }
    }
}
