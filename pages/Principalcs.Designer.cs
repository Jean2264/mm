namespace E_9.pages
{
    partial class Principalcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principalcs));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_paginas = new Label();
            label1 = new Label();
            btn_anterior = new Button();
            btn_siguente = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_add = new Button();
            panel1 = new Panel();
            txt_buscar = new TextBox();
            button4 = new Button();
            dtg_art = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_art).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Controls.Add(button1, 4, 0);
            tableLayoutPanel1.Controls.Add(button2, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1218, 33);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1193, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 10, 0);
            button1.Size = new Size(22, 27);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.maxi;
            button2.Location = new Point(1160, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 10, 0);
            button2.Size = new Size(27, 27);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1129, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 10, 0);
            button3.Size = new Size(25, 27);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.8729877F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.1270142F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 394F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel2.Controls.Add(lbl_paginas, 3, 0);
            tableLayoutPanel2.Controls.Add(label1, 6, 0);
            tableLayoutPanel2.Controls.Add(btn_anterior, 2, 0);
            tableLayoutPanel2.Controls.Add(btn_siguente, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 680);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel2.Size = new Size(1218, 69);
            tableLayoutPanel2.TabIndex = 7;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // lbl_paginas
            // 
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(429, 0);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(50, 20);
            lbl_paginas.TabIndex = 0;
            lbl_paginas.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1068, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.FromArgb(100, 100, 200);
            btn_anterior.Dock = DockStyle.Fill;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_anterior.ForeColor = Color.White;
            btn_anterior.Location = new Point(312, 3);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(111, 46);
            btn_anterior.TabIndex = 2;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguente
            // 
            btn_siguente.BackColor = Color.FromArgb(100, 100, 200);
            btn_siguente.Dock = DockStyle.Fill;
            btn_siguente.FlatAppearance.BorderSize = 0;
            btn_siguente.FlatStyle = FlatStyle.Flat;
            btn_siguente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_siguente.ForeColor = Color.White;
            btn_siguente.Location = new Point(556, 3);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(112, 46);
            btn_siguente.TabIndex = 3;
            btn_siguente.Text = "Siguente";
            btn_siguente.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 416F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            tableLayoutPanel3.Controls.Add(btn_add, 3, 1);
            tableLayoutPanel3.Controls.Add(panel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 33);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.144577F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.855423F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel3.Size = new Size(1218, 100);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 76, 191);
            btn_add.Dock = DockStyle.Fill;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(1077, 35);
            btn_add.Margin = new Padding(5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(136, 43);
            btn_add.TabIndex = 0;
            btn_add.Text = "Agregar";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 33);
            panel1.Margin = new Padding(10, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 47);
            panel1.TabIndex = 1;
            // 
            // txt_buscar
            // 
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Location = new Point(0, 0);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(360, 45);
            txt_buscar.TabIndex = 10;
            txt_buscar.KeyDown += txt_buscar_KeyDown;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(360, 0);
            button4.Name = "button4";
            button4.Size = new Size(41, 45);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dtg_art
            // 
            dtg_art.AllowUserToResizeColumns = false;
            dtg_art.AllowUserToResizeRows = false;
            dtg_art.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_art.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_art.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_art.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_art.Dock = DockStyle.Fill;
            dtg_art.EnableHeadersVisualStyles = false;
            dtg_art.ImeMode = ImeMode.On;
            dtg_art.Location = new Point(0, 133);
            dtg_art.Margin = new Padding(3, 4, 3, 4);
            dtg_art.Name = "dtg_art";
            dtg_art.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_art.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_art.RowHeadersVisible = false;
            dtg_art.RowHeadersWidth = 51;
            dtg_art.Size = new Size(1218, 547);
            dtg_art.TabIndex = 7;
            dtg_art.CellContentClick += dtg_art_CellContentClick;
            // 
            // Principalcs
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1218, 749);
            Controls.Add(dtg_art);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principalcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principalcs";
            Load += Principalcs_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_art).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_add;
        private Panel panel1;
        private Button button4;
        private DataGridView dtg_art;
        private Label lbl_paginas;
        private Label label1;
        private Button btn_anterior;
        private Button btn_siguente;
        private TextBox txt_buscar;
    }
}