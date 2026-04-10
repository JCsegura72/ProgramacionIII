using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class Inventario : Form
{
    TextBox txtCodigo = new TextBox() { Top = 20, Left = 150 };
    TextBox txtNombre = new TextBox() { Top = 50, Left = 150 };

    ComboBox cmbCategoria = new ComboBox() { Top = 80, Left = 150 };

    NumericUpDown numStockInicial = new NumericUpDown() { Top = 110, Left = 150 };
    NumericUpDown numStockMinimo = new NumericUpDown() { Top = 140, Left = 150 };

    RadioButton rbExento = new RadioButton() { Text = "0%", Top = 20 };
    RadioButton rbGeneral = new RadioButton() { Text = "19%", Top = 40 };
    RadioButton rbReducido = new RadioButton() { Text = "5%", Top = 60 };

    CheckBox chkPerecedero = new CheckBox() { Text = "Perecedero", Top = 200, Left = 20 };

    DateTimePicker dtpVencimiento = new DateTimePicker()
    {
        Top = 230,
        Left = 150,
        Enabled = false
    };

    Button btnGuardar = new Button() { Text = "Guardar", Top = 270, Left = 120 };

    public Inventario()
    {
        Text = "Inventario";
        Width = 400;

        cmbCategoria.Items.AddRange(new string[] { "Electrónica", "Alimentos", "Ropa" });

        GroupBox gbIVA = new GroupBox()
        {
            Text = "IVA",
            Top = 170,
            Left = 150,
            Width = 100,
            Height = 90
        };

        gbIVA.Controls.AddRange(new Control[] { rbExento, rbGeneral, rbReducido });

        Controls.AddRange(new Control[] {
            new Label(){Text="Código",Top=20,Left=20}, txtCodigo,
            new Label(){Text="Nombre",Top=50,Left=20}, txtNombre,
            new Label(){Text="Categoría",Top=80,Left=20}, cmbCategoria,
            new Label(){Text="Stock Inicial",Top=110,Left=20}, numStockInicial,
            new Label(){Text="Stock Mínimo",Top=140,Left=20}, numStockMinimo,
            gbIVA, chkPerecedero,
            new Label(){Text="Vencimiento",Top=230,Left=20}, dtpVencimiento,
            btnGuardar
        });

        chkPerecedero.CheckedChanged += (s, e) =>
        {
            dtpVencimiento.Enabled = chkPerecedero.Checked;
        };

        btnGuardar.Click += Validar;
    }

    void Validar(object sender, EventArgs e)
    {
        if (!txtCodigo.Text.StartsWith("PROD-"))
        {
            MessageBox.Show("Código inválido");
            return;
        }

        if (numStockInicial.Value < numStockMinimo.Value)
        {
            MessageBox.Show("Stock inicial no puede ser menor al mínimo");
            return;
        }

        if (!(rbExento.Checked || rbGeneral.Checked || rbReducido.Checked))
        {
            MessageBox.Show("Seleccione un IVA");
            return;
        }

        MessageBox.Show("Producto registrado correctamente");
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Inventario());
    }
}