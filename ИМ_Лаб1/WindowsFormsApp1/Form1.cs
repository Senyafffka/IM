using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;
        decimal dt;
        double height, angle, speed;
        decimal t, x, y, cosa, sina, v0, S, m, k, vx, vy, y_max;
        bool f;
        int count_Rows = -1;


        private void bt_Stop_Click(object sender, EventArgs e)
        {
            if (f)
            {
                f = false;
                timer1.Stop();
                bt_Stop.Text = "Пуск";
            }
            else
            {
                f = true;
                timer1.Start();
                bt_Stop.Text = "Стоп";
            }
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {      
            dataGridView1.RowCount++;
            count_Rows++;
            y_max = el_Height.Value;
            f = true;
            bt_Stop.Text = "Стоп";
            
            if (!timer1.Enabled)
            {
                Chart_Graph.Series[0].Points.Clear();
                t = 0;
                x = 0;
                y = el_Height.Value;
                v0 = el_Speed.Value;
                dt = el_Step.Value;
                double a = (double)el_Angle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = el_Size.Value;
                m = el_Weight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina; 
                Chart_Graph.Series[0].Points.AddXY(x, y);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            Chart_Graph.Series[0].Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();

            dataGridView1.Rows[count_Rows].Cells[0].Value = count_Rows;
            dataGridView1.Rows[count_Rows].Cells[1].Value = t; //Временной шаг
            dataGridView1.Rows[count_Rows].Cells[2].Value = x; //Дистанция полета
            if (y >= y_max)
            {
                dataGridView1.Rows[count_Rows].Cells[3].Value = y; //Максимальная высота
                y_max = y;
            }
            dataGridView1.Rows[count_Rows].Cells[4].Value = v; //Скорость в конечной точке
        }
    }
}
