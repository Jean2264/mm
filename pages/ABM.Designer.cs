namespace E_9.pages
{
    partial class ABM
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
            components = new System.ComponentModel.Container();
            txt_a = new TextBox();
            txt_b = new TextBox();
            txt_c = new TextBox();
            txt_e = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            TELE = new Label();
            txt_d = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_a
            // 
            txt_a.Location = new Point(24, 78);
            txt_a.Multiline = true;
            txt_a.Name = "txt_a";
            txt_a.Size = new Size(261, 39);
            txt_a.TabIndex = 0;
            txt_a.DragEnter += txt_a_DragEnter;
            txt_a.KeyDown += txt_a_KeyDown;
            txt_a.KeyPress += txt_a_KeyPress;
            txt_a.MouseDown += txt_e_MouseDown;
            // 
            // txt_b
            // 
            txt_b.Location = new Point(24, 165);
            txt_b.Multiline = true;
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(261, 39);
            txt_b.TabIndex = 1;
            txt_b.DragEnter += txt_a_DragEnter;
            txt_b.KeyDown += txt_a_KeyDown;
            txt_b.KeyPress += txt_b_KeyPress;
            txt_b.MouseDown += txt_e_MouseDown;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(24, 256);
            txt_c.Multiline = true;
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(261, 39);
            txt_c.TabIndex = 2;
            txt_c.DragEnter += txt_a_DragEnter;
            txt_c.KeyDown += txt_a_KeyDown;
            txt_c.KeyPress += txt_b_KeyPress;
            txt_c.MouseDown += txt_e_MouseDown;
            // 
            // txt_e
            // 
            txt_e.Location = new Point(24, 497);
            txt_e.Multiline = true;
            txt_e.Name = "txt_e";
            txt_e.Size = new Size(261, 39);
            txt_e.TabIndex = 4;
            txt_e.DragEnter += txt_a_DragEnter;
            txt_e.KeyDown += txt_e_KeyDown;
            txt_e.KeyPress += txt_b_KeyPress;
            txt_e.MouseDown += txt_e_MouseDown;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 671);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 7;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 138);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 228);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 316);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 10;
            label4.Text = "Edad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(24, 345);
            numericUpDown1.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(261, 27);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.DragEnter += txt_a_DragEnter;
            numericUpDown1.KeyDown += txt_a_KeyDown;
            numericUpDown1.KeyPress += txt_a_KeyPress;
            numericUpDown1.MouseDown += txt_e_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 473);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 12;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 556);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 13;
            label6.Text = "Condicion";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 582);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 14;
            comboBox1.DragEnter += txt_a_DragEnter;
            comboBox1.MouseDown += txt_e_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 9);
            label7.Name = "label7";
            label7.Size = new Size(230, 23);
            label7.TabIndex = 15;
            label7.Text = "Ingrese los datos del alumno";
            // 
            // TELE
            // 
            TELE.AutoSize = true;
            TELE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TELE.Location = new Point(24, 390);
            TELE.Name = "TELE";
            TELE.Size = new Size(75, 23);
            TELE.TabIndex = 17;
            TELE.Text = "Telefono";
            // 
            // txt_d
            // 
            txt_d.Location = new Point(24, 416);
            txt_d.Multiline = true;
            txt_d.Name = "txt_d";
            txt_d.Size = new Size(261, 39);
            txt_d.TabIndex = 16;
            txt_d.DragEnter += txt_a_DragEnter;
            txt_d.KeyDown += txt_a_KeyDown;
            txt_d.KeyPress += txt_b_KeyPress;
            txt_d.MouseDown += txt_e_MouseDown;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 727);
            Controls.Add(TELE);
            Controls.Add(txt_d);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_e);
            Controls.Add(txt_c);
            Controls.Add(txt_b);
            Controls.Add(txt_a);
            Name = "ABM";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ABM";
            Load += ABM_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_a;
        private TextBox txt_b;
        private TextBox txt_c;
        private TextBox txt_e;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Label TELE;
        private TextBox txt_d;
        private ErrorProvider errorProvider1;
    }
}