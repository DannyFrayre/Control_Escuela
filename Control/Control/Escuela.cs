using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Control
{
    public partial class Escuela : UserControl
    {
        public Escuela()
        {
            InitializeComponent();
        }
        Stopwatch Cronometro = new Stopwatch();
        private void btnE1_Click(object sender, EventArgs e)
        {
 
                btnE1.Text = "No";
                btnE1.BackColor = Color.Yellow;
                btnE1.Enabled = false; //No esta habilitado
                lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("El salon ha sido ocupado");
        }
        private void btnE2_Click(object sender, EventArgs e)
        {

            btnE2.Text = "No";
            btnE2.BackColor = Color.Yellow;
            btnE2.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            btnE3.Text = "No";
            btnE3.BackColor = Color.Yellow;
            btnE3.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
           
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            btnE4.Text = "No";
            btnE4.BackColor = Color.Yellow;
            btnE4.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            btnE5.Text = "No";
            btnE5.BackColor = Color.Yellow;
            btnE5.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            btnE6.Text = "No";
            btnE6.BackColor = Color.Yellow;
            btnE6.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            btnE7.Text = "No";
            btnE7.BackColor = Color.Yellow;
            btnE7.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            btnE8.Text = "No";
            btnE8.BackColor = Color.Yellow;
            btnE8.Enabled = false; //No esta habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El salon ha sido ocupado");
        }

        private void Escuela_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Cronometro.Elapsed.Hours, Cronometro.Elapsed.Minutes, Cronometro.Elapsed.Seconds, Cronometro.Elapsed.Milliseconds / 10);   
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Cronometro.Start();
            btnLaboratorio.Text = "Ocupado";
            btnLaboratorio.BackColor = Color.Yellow;
            btnLaboratorio.Enabled = false; //No esta habilitado
            MessageBox.Show("El Laboratorio ha sido ocupado");

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnE1.Text = "E1";
            btnE1.BackColor = Color.White;
            btnE1.Enabled = true; //Habilitado

            btnE2.Text = "E2";
            btnE2.BackColor = Color.White;
            btnE2.Enabled = true; //Habilitado

            btnE3.Text = "E3";
            btnE3.BackColor = Color.White;
            btnE3.Enabled = true; //Habilitado

            btnE4.Text = "E4";
            btnE4.BackColor = Color.White;
            btnE4.Enabled = true; //Habilitado

            btnE5.Text = "E5";
            btnE5.BackColor = Color.White;
            btnE5.Enabled = true; //Habilitado

            btnE6.Text = "E6";
            btnE6.BackColor = Color.White;
            btnE6.Enabled = true; //Habilitado

            btnE7.Text = "E7";
            btnE7.BackColor = Color.White;
            btnE7.Enabled = true; //Habilitado

            btnE8.Text = "E8";
            btnE8.BackColor = Color.White;
            btnE8.Enabled = true; //Habilitado

            lbxDatos.Text = "";

            MessageBox.Show("Los registros han sio reiniciados");

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Cronometro.Stop();
            Cronometro.Reset();
            btnLaboratorio.Text = "Laboratorio";
            btnLaboratorio.BackColor = Color.White;
            btnLaboratorio.Enabled = true; //Habilitado
            lbxDatos.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + label13.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("El Laboratorio esta libre");

        }
    }
}
