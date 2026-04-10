using System;
using System.Drawing;
using System.Windows.Forms;

public class FormPerfil : Form
{
    public FormPerfil()
    {
        Text = "Mi Cuenta";
        Size = new Size(400, 350);

        GroupBox gb = new GroupBox()
        {
            Text = "Información Personal",
            Dock = DockStyle.Fill
        };

        Label lblNombre = new Label() { Text = "Nombre:", Location = new Point(20, 30) };
        TextBox txtNombre = new TextBox() { Location = new Point(150, 30), Width = 200 };

        Label lblApellido = new Label() { Text = "Apellido:", Location = new Point(20, 70) };
        TextBox txtApellido = new TextBox() { Location = new Point(150, 70), Width = 200 };

        Label lblCorreo = new Label() { Text = "Correo:", Location = new Point(20, 110) };
        TextBox txtCorreo = new TextBox() { Location = new Point(150, 110), Width = 200 };

        Label lblTelefono = new Label() { Text = "Teléfono:", Location = new Point(20, 150) };
        MaskedTextBox txtTelefono = new MaskedTextBox("(999) 000-0000")
        {
            Location = new Point(150, 150),
            Width = 200
        };

        GroupBox gbGenero = new GroupBox()
        {
            Text = "Género",
            Location = new Point(20, 190),
            Size = new Size(330, 50)
        };

        RadioButton rb1 = new RadioButton() { Text = "Masculino", Location = new Point(10, 20) };
        RadioButton rb2 = new RadioButton() { Text = "Femenino", Location = new Point(110, 20) };
        RadioButton rb3 = new RadioButton() { Text = "Otro", Location = new Point(210, 20) };

        gbGenero.Controls.AddRange(new Control[] { rb1, rb2, rb3 });

        Button btnGuardar = new Button()
        {
            Text = "Guardar Cambios",
            Location = new Point(120, 260),
            Width = 150
        };

        gb.Controls.AddRange(new Control[] {
            lblNombre, txtNombre,
            lblApellido, txtApellido,
            lblCorreo, txtCorreo,
            lblTelefono, txtTelefono,
            gbGenero, btnGuardar
        });

        Controls.Add(gb);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new FormPerfil());
    }
}