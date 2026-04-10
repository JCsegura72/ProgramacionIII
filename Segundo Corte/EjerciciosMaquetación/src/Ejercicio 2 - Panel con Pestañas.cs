using System;
using System.Drawing;
using System.Windows.Forms;

public class FormTabs : Form
{
    public FormTabs()
    {
        Text = "Configuración";
        Size = new Size(400, 300);

        TabControl tabs = new TabControl() { Dock = DockStyle.Fill };

        // Apariencia
        TabPage tab1 = new TabPage("Apariencia");

        Label lblTema = new Label() { Text = "Tema del Sistema", Location = new Point(20, 20) };
        ComboBox combo = new ComboBox()
        {
            Location = new Point(20, 50),
            Width = 150
        };
        combo.Items.AddRange(new string[] { "Claro", "Oscuro", "Azul Cobalto" });

        CheckBox chkAnim = new CheckBox()
        {
            Text = "Activar animaciones de ventana",
            Location = new Point(20, 90)
        };

        tab1.Controls.AddRange(new Control[] { lblTema, combo, chkAnim });

        // Notificaciones
        TabPage tab2 = new TabPage("Notificaciones");

        CheckBox c1 = new CheckBox() { Text = "Recibir correos", Location = new Point(20, 20) };
        CheckBox c2 = new CheckBox() { Text = "Alertas de escritorio", Location = new Point(20, 50) };
        CheckBox c3 = new CheckBox() { Text = "Sonidos de sistema", Location = new Point(20, 80) };

        NumericUpDown num = new NumericUpDown()
        {
            Location = new Point(20, 120),
            Minimum = 0,
            Maximum = 100
        };

        tab2.Controls.AddRange(new Control[] { c1, c2, c3, num });

        tabs.TabPages.Add(tab1);
        tabs.TabPages.Add(tab2);

        Controls.Add(tabs);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new FormTabs());
    }
}