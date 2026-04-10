using System;
using System.Drawing;
using System.Windows.Forms;

public class Producto : Form
{
    public Producto()
    {
        Text = "Producto";
        Size = new Size(300, 300);

        Panel panel = new Panel()
        {
            Dock = DockStyle.Fill,
            BorderStyle = BorderStyle.FixedSingle
        };

        Label nombre = new Label()
        {
            Text = "Monitor Gamer 24\"",
            Font = new Font("Arial", 14),
            ForeColor = Color.Blue,
            Location = new Point(10, 10)
        };

        TextBox descripcion = new TextBox()
        {
            Text = "Monitor Full HD, 144Hz, ideal para gaming.",
            Multiline = true,
            BorderStyle = BorderStyle.None,
            Location = new Point(10, 40),
            Width = 260,
            Height = 60,
            ReadOnly = true
        };

        Label precio = new Label()
        {
            Text = "$299.99",
            Font = new Font("Arial", 14),
            ForeColor = Color.Green,
            Location = new Point(10, 110)
        };

        NumericUpDown cantidad = new NumericUpDown()
        {
            Location = new Point(10, 150),
            Minimum = 1,
            Maximum = 10
        };

        Button btn = new Button()
        {
            Text = "Añadir al carrito",
            BackColor = Color.Green,
            ForeColor = Color.White,
            Location = new Point(10, 190),
            Width = 200
        };

        panel.Controls.AddRange(new Control[] { nombre, descripcion, precio, cantidad, btn });
        Controls.Add(panel);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Producto());
    }
}