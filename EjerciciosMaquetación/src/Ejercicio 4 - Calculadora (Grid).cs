using System;
using System.Drawing;
using System.Windows.Forms;

public class Calculadora : Form
{
    public Calculadora()
    {
        Text = "Calculadora";
        Size = new Size(300, 400);

        TextBox pantalla = new TextBox()
        {
            Location = new Point(10, 10),
            Width = 260,
            Font = new Font("Arial", 18),
            TextAlign = HorizontalAlignment.Right,
            ReadOnly = true
        };

        Controls.Add(pantalla);

        string[] botones = {
            "7","8","9","/",
            "4","5","6","*",
            "1","2","3","-",
            "0","=","+"
        };

        int x = 10, y = 60, i = 0;

        foreach (var txt in botones)
        {
            Button btn = new Button()
            {
                Text = txt,
                Size = new Size(60, 40),
                Location = new Point(x, y),
                BackColor = char.IsDigit(txt[0]) ? Color.LightGray : Color.Orange
            };

            Controls.Add(btn);

            x += 65;
            i++;

            if (i % 4 == 0)
            {
                x = 10;
                y += 45;
            }
        }
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new Calculadora());
    }
}