using E_9.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace E_9.pages
{
    public partial class Principalcs : Form
    {
        public Color Colorborde = Color.Gray;
        private bool modoFiltro = false;
        private bool maxi = false;
        int pagina = 1;
        int limite = 20;
        int totalPaginas = 0;
        public Principalcs()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void Principalcs_Load(object sender, EventArgs e)
        {
          //  UIHelper.Redondear(this, 6);
            //UIHelper.Redondear(panel1, 10);

           // UIHelper.Redondear(btn_add, 10);
            AggColumnasAccion();
            LlenarDtg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtg_art_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_art.Columns["btnVer"].Index)
            {
                ABM ab = new ABM();
                ab.cod = dtg_art.CurrentRow.Cells["DNI"].Value.ToString();
                ab.Modo = "Ver";
                ab.ShowDialog();
            }

            if (e.ColumnIndex == dtg_art.Columns["btnEditar"].Index)
            {
                ABM ab = new ABM(this);
                ab.cod = dtg_art.CurrentRow.Cells["DNI"].Value.ToString();
                ab.Modo = "Modificar";
                ab.ShowDialog();
            }

            if (e.ColumnIndex == dtg_art.Columns["btnEliminar"].Index)
            {
                string cod = dtg_art.CurrentRow.Cells["DNI"].Value.ToString();

                DialogResult r = MessageBox.Show("Estas seguro de eliminar este Alumno?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Consultas db = new Consultas();
                    db.Baja(cod);

                    LlenarDtg();
                }
            }
        }
        public void LlenarDtg()
        {
            Consultas db = new Consultas();

            var result = db.Cargar(pagina, limite);

            if (result == null) return;

            dtg_art.DataSource = null;
            dtg_art.DataSource = result.Data;

            int ultimo = dtg_art.Columns.Count - 1;

            dtg_art.Columns["btnVer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnVer"].Width = 80;

            dtg_art.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEditar"].Width = 80;

            dtg_art.Columns["btnEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEliminar"].Width = 90;

            dtg_art.Columns["btnEliminar"].DisplayIndex = ultimo;
            dtg_art.Columns["btnEditar"].DisplayIndex = ultimo - 1;
            dtg_art.Columns["btnVer"].DisplayIndex = ultimo - 2;




            totalPaginas = (int)Math.Ceiling((double)result.Total / limite);
            lbl_paginas.Text = $"Pagina {pagina}/{totalPaginas}";
            label1.Text = $"Total registros: {result.Total}";
            btn_anterior.Enabled = pagina > 1;
            btn_siguente.Enabled = pagina < totalPaginas;

            modoFiltro = false;

        }

        public void AggColumnasAccion()
        {
            if (!dtg_art.Columns.Contains("btnVer"))
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.FlatStyle = FlatStyle.Flat;
                btnVer.Width = 150;
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.DefaultCellStyle.BackColor = Color.FromArgb(100, 82, 255);
                btnVer.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnVer);
            }

            if (!dtg_art.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "";
                btnEditar.Text = "Editar";
                btnEditar.FlatStyle = FlatStyle.Flat;
                btnEditar.Width = 150;
                btnEditar.UseColumnTextForButtonValue = true;
                btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(87, 0, 238);
                btnEditar.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnEditar);
            }

            if (!dtg_art.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "";
                btnEliminar.Text = "Eliminar";
                btnEliminar.FlatStyle = FlatStyle.Flat;
                btnEliminar.Width = 150;
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.DefaultCellStyle.BackColor = Color.FromArgb(53, 0, 152);
                btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnEliminar);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ABM alta = new ABM(this);
            alta.Modo = "Alta";
            alta.StartPosition = FormStartPosition.CenterParent;
            alta.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filtro = txt_buscar.Text;

            Consultas db = new Consultas();

            var result = db.CargarFiltro(pagina, limite, filtro);


            if (result == null) return;

            dtg_art.DataSource = null;
            dtg_art.DataSource = result.Data;

            int ultimo = dtg_art.Columns.Count - 1;

            dtg_art.Columns["btnVer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnVer"].Width = 80;

            dtg_art.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEditar"].Width = 80;

            dtg_art.Columns["btnEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEliminar"].Width = 90;

            dtg_art.Columns["btnEliminar"].DisplayIndex = ultimo;
            dtg_art.Columns["btnEditar"].DisplayIndex = ultimo - 1;
            dtg_art.Columns["btnVer"].DisplayIndex = ultimo - 2;




            totalPaginas = (int)Math.Ceiling((double)result.Total / limite);
            lbl_paginas.Text = $"Pagina {pagina}/{totalPaginas}";
            label1.Text = $"Total registros: {result.Total}";
            btn_anterior.Enabled = pagina > 1;
            btn_siguente.Enabled = pagina < totalPaginas;

            modoFiltro = true;

        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!maxi)
            {
                this.WindowState = FormWindowState.Maximized;
                maxi = true;
                button2.Image = Properties.Resources.mini;

            }
            else if (maxi)
            {
                this.WindowState = FormWindowState.Normal;
                maxi = false;
                button2.Image = Properties.Resources.maxi;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
