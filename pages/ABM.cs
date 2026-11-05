using E_9.DAL;
using E_9.Entidades;
using E_9.Entidades.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using E_9.BLL;

namespace E_9.pages
{
    public partial class ABM : Form
    {
        public string Modo;
        public string cod;
        public Principalcs pc;
        public ABM(Principalcs PC)
        {
            InitializeComponent();
            Conexion.Conectar();
            this.pc = PC;
        }
        public ABM()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void ABM_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Regular");
            comboBox1.Items.Add("Libre");
            comboBox1.SelectedIndex = 0;

            if (Modo == "Alta")
            {
                button1.Text = "Añadir";
                button1.BackColor = Color.FromArgb(32, 0, 130);
            }
            if (Modo == "Modificar")
            {
                button1.Text = "Editar";
                button1.BackColor = Color.FromArgb(53, 0, 152);

                CargarDatos(cod);
                label7.Text = "Datos del alumno";
                txt_a.ReadOnly = true;
                txt_a.BackColor = Color.White;
                txt_b.ReadOnly = true;
                txt_b.BackColor = Color.White;
                txt_c.ReadOnly = true;
                txt_c.BackColor = Color.White;
                numericUpDown1.Enabled = false;

            }
            if (Modo == "Ver")
            {
                CargarDatos(cod);
                label7.Text = "Datos del alumno";
                comboBox1.Enabled = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox txt)
                    {
                        txt.ReadOnly = true;
                        txt.BackColor = Color.White;
                    }
                }
            }
        }


        public bool Validar()
        {
            bool error = false;




            return error;
        }

        public void GenerarAlta()
        {

            errorProvider1.Clear();

            Props p = new Props();

            p.DNI = txt_a.Text;
            p.Apellido = txt_b.Text;
            p.Nombre = txt_c.Text;
            p.Edad = (int)numericUpDown1.Value;
            p.Telefono = txt_d.Text;
            p.Mail = txt_e.Text;
            p.Condicion = comboBox1.SelectedItem.ToString();

            Consultas db = new Consultas();
            Negocio neg = new Negocio();
            Resultado resultado = neg.ValidarCampo(p);

            if (!resultado.EsValido)
            {
                MostrarResultado(resultado);
                return;
            }

            db.Alta(p);
            pc.LlenarDtg();
            this.Close();
        }

        public void GenerarModi()
        {
            errorProvider1.Clear();
            Props p = new Props();

            p.DNI = txt_a.Text;
            p.Telefono = txt_d.Text;
            p.Mail = txt_e.Text;
            p.Condicion = comboBox1.SelectedItem.ToString();

            Consultas db = new Consultas();
            Negocio neg = new Negocio();
            Resultado resultado = neg.ValidarCampoModi(p);

            if (!resultado.EsValido)
            {
                MostrarResultado(resultado);
                return;
            }

            db.Modi(p);
            pc.LlenarDtg();
            this.Close();
        }
        public void MostrarResultado(Resultado rest)
        {
            foreach (var error in rest.Errores)
            {
                switch (error.Campo)
                {
                    case "DNI":
                        errorProvider1.SetError(txt_a, error.Mensaje);
                        break;
                    case "Apellido":
                        errorProvider1.SetError(txt_b, error.Mensaje);
                        break;
                    case "Nombre":
                        errorProvider1.SetError(txt_c, error.Mensaje);
                        break;
                    case "Telefono":
                        errorProvider1.SetError(txt_d, error.Mensaje);
                        break;
                    case "Mail":
                        errorProvider1.SetError(txt_e, error.Mensaje);
                        break;
                    case "Edad":
                        errorProvider1.SetError(numericUpDown1, error.Mensaje);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Modo == "Alta")
            {
                GenerarAlta();
            }
            else if (Modo == "Modificar")
            {
                GenerarModi();
            }


        }

        public void CargarDatos(string dni)
        {
            Consultas db = new Consultas();
            Props pp = db.TraerInfo(dni);

            txt_a.Text = pp.DNI;
            txt_b.Text = pp.Apellido;
            txt_c.Text = pp.Nombre;
            numericUpDown1.Value = (int)pp.Edad;
            txt_d.Text = pp.Telefono;
            txt_e.Text = pp.Mail;
            comboBox1.Text = pp.Condicion;
        }

        private void txt_a_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_a_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && !char.IsControl(c))
            {
                e.Handled = true; // Bloquea cualquier otro carácter
            }
        }

        private void txt_e_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_e_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Button== MouseButtons.Left)
            {
                e = null;
            }
        }
    }
}