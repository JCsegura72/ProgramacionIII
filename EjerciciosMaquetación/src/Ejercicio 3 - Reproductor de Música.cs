using System;
using System.Drawing;
using System.Windows.Forms;

public class Reproductor : Form
{
    public Reproductor()
    {
        Text = "Reproductor";
        Size = new Size(300, 400);

        PictureBox pic = new PictureBox()
        {
            Size = new Size(200, 200),
            Location = new Point(50, 20),
            SizeMode = PictureBoxSizeMode.StretchImage,
            Image = SystemIcons.Information.ToBitmap()
        };

        Label lblTitulo = new Label()
        {
            Text = "Canción",
            Font = new Font("Arial", 10, FontStyle.Bold),
            Location = new Point(100, 230)
        };

        Label lblArtista = new Label()
        {
            Text = "Artista",
            Location = new Point(110, 260)
        };

        ProgressBar barra = new ProgressBar()
        {
            Location = new Point(50, 290),
            Width = 200,
            Value = 45
        };

        Button b1 = new Button() { Text = "<<", Location = new Point(50, 320) };
        Button b2 = new Button() { Text = "Play", Location = new Point(110, 320) };
        Button b3 = new Button() { Text = ">>", Location = new Point(180, 320) };

        Controls.AddRange(new Control[] { pic, lblTitulo, lblArtista, barra, b1, b2, b3 });
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Reproductor());
    }
}