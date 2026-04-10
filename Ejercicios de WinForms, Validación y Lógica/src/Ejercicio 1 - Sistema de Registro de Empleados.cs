using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class FormEmpleado : Form
{
    TextBox txtNombres = new TextBox() { Top = 20, Left = 150 };
    TextBox txtApellidos = new TextBox() { Top = 50, Left = 150 };
    TextBox txtEmail = new TextBox() { Top = 80, Left = 150 };
    TextBox txtIdentificacion = new TextBox() { Top = 110, Left = 150 };

    NumericUpDown numSueldo = new NumericUpDown()
    {
        Top = 140,
        Left = 150,
        Minimum = 1000,
        Maximum = 10000
    };

    ComboBox cmbDepto = new ComboBox()
    {
        Top = 170,
        Left = 150,
        Width = 150
    };

    Label lblResultado = new Label() { Top = 200, Left = 150, Width = 200 };

    Button btnRegistrar = new Button() { Text = "Registrar", Top = 230, Left = 80 };
    Button btnLimpiar = new Button() { Text = "Limpiar", Top = 230, Left = 180 };

    public FormEmpleado()
    {
        Text = "Registro de Empleados";
        Width = 400;

        cmbDepto.Items.AddRange(new string[] { "Ventas", "IT", "Recursos Humanos", "Contabilidad" });

        Controls.AddRange(new Control[] {
            new Label(){Text="Nombres",Top=20,Left=20}, txtNombres,
            new Label(){Text="Apellidos",Top=50,Left=20}, txtApellidos,
            new Label(){Text="Email",Top=80,Left=20}, txtEmail,
            new Label(){Text="Identificación",Top=110,Left=20}, txtIdentificacion,
            new Label(){Text="Sueldo Base",Top=140,Left=20}, numSueldo,
            new Label(){Text="Departamento",Top=170,Left=20}, cmbDepto,
            lblResultado, btnRegistrar, btnLimpiar
        });

        btnRegistrar.Click += Registrar;
        btnLimpiar.Click += Limpiar;
    }

    void Registrar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
            string.IsNullOrWhiteSpace(txtApellidos.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtIdentificacion.Text))
        {
            MessageBox.Show("Todos los campos son obligatorios");
            return;
        }

        if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            MessageBox.Show("Email inválido");
            return;
        }

        if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
        {
            MessageBox.Show("La identificación debe tener 10 dígitos");
            return;
        }

        decimal sueldo = numSueldo.Value;
        decimal neto = sueldo * 0.9m;

        lblResultado.Text = "Sueldo Neto: $" + neto.ToString("0.00");
    }

    void Limpiar(object sender, EventArgs e)
    {
        txtNombres.Clear();
        txtApellidos.Clear();
        txtEmail.Clear();
        txtIdentificacion.Clear();
        cmbDepto.SelectedIndex = -1;
        lblResultado.Text = "";
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new FormEmpleado());
    }
}