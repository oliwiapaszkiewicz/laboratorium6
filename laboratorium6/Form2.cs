using System;
using System.Windows.Forms;

namespace laboratorium6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetupControls();
        }

        private NumericUpDown numericX, numericY, numericTime, numericDydelf, numericSzop, numericKrokodyl;
        private Button startButton, exitButton;

        private void SetupControls()
        {
            this.Text = "Ustawienia Gry";
            this.Size = new System.Drawing.Size(300, 350);

            Label label1 = new Label() { Text = "Szerokość planszy (X):", Top = 20, Left = 10, Width = 150 };
            numericX = new NumericUpDown() { Minimum = 3, Maximum = 10, Value = 5, Top = 40, Left = 10, Width = 100 };

            Label label2 = new Label() { Text = "Wysokość planszy (Y):", Top = 70, Left = 10, Width = 150 };
            numericY = new NumericUpDown() { Minimum = 3, Maximum = 10, Value = 5, Top = 90, Left = 10, Width = 100 };

            Label label3 = new Label() { Text = "Czas (sekundy):", Top = 120, Left = 10, Width = 150 };
            numericTime = new NumericUpDown() { Minimum = 10, Maximum = 60, Value = 30, Top = 140, Left = 10, Width = 100 };

            Label label4 = new Label() { Text = "Liczba Dydelfów:", Top = 170, Left = 10, Width = 150 };
            numericDydelf = new NumericUpDown() { Minimum = 1, Maximum = 6, Value = 3, Top = 190, Left = 10, Width = 100 };

            Label label5 = new Label() { Text = "Liczba Szopów:", Top = 220, Left = 10, Width = 150 };
            numericSzop = new NumericUpDown() { Minimum = 3, Maximum = 8, Value = 3, Top = 240, Left = 10, Width = 100 };

            Label label6 = new Label() { Text = "Liczba Krokodyli:", Top = 270, Left = 10, Width = 150 };
            numericKrokodyl = new NumericUpDown() { Minimum = 0, Maximum = 1, Value = 0, Top = 290, Left = 10, Width = 100 };

            startButton = new Button() { Text = "Start", Top = 320, Left = 10, Width = 100 };
            startButton.Click += StartButton_Click;

            exitButton = new Button() { Text = "Zakończ", Top = 320, Left = 120, Width = 100 };
            exitButton.Click += (s, e) => Application.Exit();

            this.Controls.AddRange(new Control[] {
                label1, numericX,
                label2, numericY,
                label3, numericTime,
                label4, numericDydelf,
                label5, numericSzop,
                label6, numericKrokodyl,
                startButton, exitButton
            });
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int x = (int)numericX.Value;
            int y = (int)numericY.Value;
            int czas = (int)numericTime.Value;
            int dydelf = (int)numericDydelf.Value;
            int szop = (int)numericSzop.Value;
            int krokodyl = (int)numericKrokodyl.Value;

            Form3 gameForm = new Form3(x, y, czas, dydelf, krokodyl, szop);
            gameForm.Show();
        }

        

        
    }
}
