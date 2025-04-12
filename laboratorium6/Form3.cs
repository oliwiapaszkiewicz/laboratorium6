using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace laboratorium6
{
    public partial class Form3 : Form
    {
        private int rows, cols, totalTime, dydelfsLeft;
        private int krokodyle, szopy;
        private string[,] gridContent;
        private DataGridView dataGrid;
        private System.Windows.Forms.Timer gameTimer;
        private int timeLeft;

        private Stopwatch krokodylStopwatch; 
        private DataGridViewCell lastClickedCell; 

        public Form3(int x, int y, int czas, int dydelf, int krokodyl, int szop)
        {
            InitializeComponent();
            rows = x;
            cols = y;
            totalTime = czas;
            dydelfsLeft = dydelf;
            krokodyle = krokodyl;
            szopy = szop;
            StartTimer();
            InitGrid();
        }

        private void InitGrid()
        {
            dataGrid = new DataGridView
            {
                RowCount = rows,
                ColumnCount = cols,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                SelectionMode = DataGridViewSelectionMode.CellSelect,
                RowHeadersVisible = false,
                ColumnHeadersVisible = false,
            };
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGrid.CellClick += CellClick;
            this.Controls.Add(dataGrid);
            gridContent = new string[rows, cols];
            PlaceAnimals("Dydelf", dydelfsLeft);
            PlaceAnimals("Krokodyl", krokodyle);
            PlaceAnimals("Szop", szopy);
            krokodylStopwatch = new Stopwatch(); 
        }

        private void PlaceAnimals(string type, int count)
        {
            Random rand = new Random();
            int placed = 0;
            while (placed < count)
            {
                int r = rand.Next(rows);
                int c = rand.Next(cols);
                if (gridContent[r, c] == null)
                {
                    gridContent[r, c] = type;
                    placed++;
                }
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var cell = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Tag != null) return;

            string content = gridContent[e.RowIndex, e.ColumnIndex];

            if (content == "Dydelf")
            {
                cell.Value = "dydelo"; 
                cell.Tag = "clicked";
                dydelfsLeft--;
                if (dydelfsLeft == 0)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Wszystkie dydelfy znalezione!");
                    this.Close();
                }
            }
            else if (content == "Krokodyl")
            {
                cell.Value = "crocodillobombardilo"; 
                cell.Tag = "clicked";
                lastClickedCell = cell;
                krokodylStopwatch.Restart(); 
                MessageBox.Show("Kliknij w ikonke jeszcze raz masz dwie sekundy!");

                gameTimer.Stop();
            }
            else if (content == "Szop")
            {
                cell.Value = "szops"; 
                cell.Tag = "clicked";
                MessageBox.Show("Szop blokuje sasiadow.");
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int nx = e.RowIndex + dx;
                        int ny = e.ColumnIndex + dy;
                        if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                        {
                            var neighborCell = dataGrid.Rows[nx].Cells[ny];
                            neighborCell.ReadOnly = true;
                            neighborCell.Style.BackColor = Color.LightGray;
                        }
                    }
                }
            }
            else
            {
                cell.Value = ""; 
                cell.Tag = "clicked";
            }
        }

        private void StartTimer()
        {
            timeLeft = totalTime;
            gameTimer = new System.Windows.Forms.Timer(); 
            gameTimer.Interval = 1000; 
            gameTimer.Tick += (s, e) =>
            {
                timeLeft--;
                this.Text = $"Czas: {timeLeft}s - Dydelfy do znalezienia: {dydelfsLeft}";

                if (timeLeft <= 0)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Czas się skończył! Przegrana.");
                    this.Close();
                }
            };
            gameTimer.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}