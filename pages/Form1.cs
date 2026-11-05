using E_9.pages;

namespace E_9
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.Load += Form1_Load; 
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIHelper.Redondear(this, 20);
        }
    }
}
