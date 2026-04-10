using System;
using System.Text;
using System.Windows.Forms;

public class Reserva : Form
{
    TextBox txtCliente = new TextBox() { Top = 20, Left = 150 };

    DateTimePicker dtpEntrada = new DateTimePicker() { Top = 50, Left = 150 };
    DateTimePicker dtpSalida = new DateTimePicker() { Top = 80, Left = 150 };

    NumericUpDown numPersonas = new NumericUpDown()
    {
        Top = 110,
        Left = 150,
        Minimum = 1,
        Maximum = 4
    };

    CheckedListBox clbServicios = new CheckedListBox()
    {
        Top = 140,
        Left = 150,
        Height = 80
    };

    RichTextBox rtbResumen = new RichTextBox()
    {
        Top = 230,
        Left = 20,
        Width = 320,
        Height = 120,
        ReadOnly = true
    };

    Button btnCalcular = new Button() { Text = "Calcular", Top = 360, Left = 120 };

    public Reserva()
    {
        Text = "Reserva Hotel";
        Width = 380;
        Height = 450;

        clbServicios.Items.AddRange(new string[]
        {
            "WiFi Premium", "Desayuno Buffet", "Estacionamiento", "Spa"
        });

        Controls.AddRange(new Control[] {
            new Label(){Text="Cliente",Top=20,Left=20}, txtCliente,
            new Label(){Text="Entrada",Top=50,Left=20}, dtpEntrada,
            new Label(){Text="Salida",Top=80,Left=20}, dtpSalida,
            new Label(){Text="Personas",Top=110,Left=20}, numPersonas,
            new Label(){Text="Servicios",Top=140,Left=20}, clbServicios,
            rtbResumen, btnCalcular
        });

        btnCalcular.Click += Calcular;
    }

    void Calcular(object sender, EventArgs e)
    {
        if (dtpEntrada.Value.Date < DateTime.Today)
        {
            MessageBox.Show("Fecha de entrada inválida");
            return;
        }

        if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
        {
            MessageBox.Show("La salida debe ser posterior");
            return;
        }

        int dias = (dtpSalida.Value.Date - dtpEntrada.Value.Date).Days;

        decimal total = dias * 50;

        int personas = (int)numPersonas.Value;
        if (personas > 1)
            total += dias * (personas - 1) * 15;

        int servicios = clbServicios.CheckedItems.Count;
        total += dias * servicios * 10;

        StringBuilder resumen = new StringBuilder();
        resumen.AppendLine("--- RESUMEN DE RESERVA ---");
        resumen.AppendLine("Cliente: " + txtCliente.Text);
        resumen.AppendLine("Estancia: " + dias + " noches");
        resumen.AppendLine("Personas: " + personas);

        resumen.Append("Servicios: ");
        foreach (var item in clbServicios.CheckedItems)
            resumen.Append(item + ", ");

        resumen.AppendLine("\n--------------------------");
        resumen.AppendLine("TOTAL: $" + total);

        rtbResumen.Text = resumen.ToString();
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Reserva());
    }
}