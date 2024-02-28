using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_Лаб4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Grid.RowCount++;
            for (int i = 0; i < N - 1; i++)
            {
                Grid.RowCount++;
                Grid.ColumnCount++;
                Grid.Columns[i].Width = 29;
                for (int j = 0; j < N - 1; j++)
                {
                    mass[i, j] = false;
                    new_mass[i, j] = false;
                }
            }
            Grid.Columns[N - 1].Width = 29;
        }

        const int N = 30;
        bool[,] mass = new bool[N, N];
        bool[,] new_mass = new bool[N, N];

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid.CurrentCell.Style.BackColor = Color.YellowGreen;
            mass[e.RowIndex, e.ColumnIndex] = true;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++) { 
                    if (rule(i, j))
                        new_mass[i, j] = true;
                    else
                        new_mass[i, j] = false;
                }

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    mass[i, j] = new_mass[i, j];
                    if (new_mass[i, j])
                    {
                        new_mass[i, j] = true;
                        Grid.Rows[i].Cells[j].Style.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        new_mass[i, j] = false;
                        Grid.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }

            int summ = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    if (mass[i, j]) summ++;
            }
            if (summ == 0) timer1.Stop();
        }

        private bool sap_rule(int summ, int i, int j)
        {
            if (mass[i, j] && summ < 2)
                return false;
            if (mass[i, j] && summ == 2 || mass[i, j] && summ == 3)
                return true;
            if (mass[i, j] && summ > 3)
                return false;
            if (!mass[i, j] && summ == 3)
                return true;
            return false;
        }

        private bool rule(int i, int j)
        {
            int summ = 0;

            if (i == 0 && j == 0)
            {   //Левый верхний угол
                if (mass[i + 1, j]) summ++;
                if (mass[i, j + 1]) summ++;
                if (mass[i + 1, j + 1]) summ++;
                return sap_rule(summ, i, j);
            }

            if (i == 0 && j == N - 1)
            {   //Правый верхний угол
                if (mass[i + 1, j]) summ++;
                if (mass[i, j - 1]) summ++;
                if (mass[i + 1, j - 1]) summ++;
                return sap_rule(summ, i, j);
            }

            if (i == N - 1 && j == 0)
            {   //Левый нижний угол
                if (mass[i - 1, j]) summ++;
                if (mass[i, j + 1]) summ++;
                if (mass[i - 1, j + 1]) summ++;
                return sap_rule(summ, i, j);
            }

            if (i == N - 1 && j == N - 1)
            {   //Правый нижний угол
                if (mass[i - 1, j]) summ++;
                if (mass[i, j - 1]) summ++;
                if (mass[i - 1, j - 1]) summ++;
                return sap_rule(summ, i, j);
            }

            if (i > 0 && j > 0 && i < N - 1 && j < N - 1)
            {   //Центр
                for (int k = i - 1; k <= i + 1; k++)
                    for (int t = j - 1; t <= j + 1; t++)
                        if (mass[k, t] && !(k == i && t == j)) summ++;
                return sap_rule(summ, i, j);
            }
                
            if (i == 0 && j > 0 && j < N - 1)
            {   //Верхний ряд
                for (int k = i; k <= i + 1; k++)
                    for (int t = j - 1; t <= j + 1; t++)
                        if (mass[k, t] && !(k == i && t == j)) summ++;
                return sap_rule(summ, i, j);
            }

            if (i == N - 1 && j > 0 && j < N - 1)
            {   //Нижний ряд
                for (int k = i - 1; k <= i; k++)
                    for (int t = j - 1; t <= j + 1; t++)
                        if (mass[k, t] && !(k == i && t == j)) summ++;
                return sap_rule(summ, i, j);
            }

            if (i > 0 && i < N - 1 && j == 0)
            {   //Левый ряд
                for (int k = i - 1; k <= i + 1; k++)
                    for (int t = j; t <= j + 1; t++)
                        if (mass[k, t] && !(k == i && t == j)) summ++;
                return sap_rule(summ, i, j);
            }

            if (i > 0 && i < N - 1 && j == N - 1)
            {   //Правый ряд
                for (int k = i - 1; k <= i + 1; k++)
                    for (int t = j - 1; t <= j; t++)
                        if (mass[k, t] && !(k == i && t == j)) summ++;
                return sap_rule(summ, i, j);
            }

            return false;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    mass[i, j] = false;
                    new_mass[i, j] = false;
                    Grid.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
    }
}
