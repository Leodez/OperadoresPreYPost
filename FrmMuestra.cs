using System;
using System.Drawing;
using System.Windows.Forms;

namespace OperadoresPreYPost
{
    /* Este nuevo comenario es mi gran contribución. */
    public partial class FrmMuestra : Form
    {
        TextBox txtResultado;
        public FrmMuestra()
        {
            InitializeComponent();

            Load += FrmMuestra_Load;
            txtResultado = new TextBox()
            {
                Location = new Point(0, 0),
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true
            };
            Controls.Add(txtResultado);
        }

        private void FrmMuestra_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "Inizializamos a = 3, b = ++a\r\n";
            int a = 3;
            int b = ++a;
            txtResultado.Text += "Resultado:\r\n";
            txtResultado.Text += $"a = {a}\r\n";
            txtResultado.Text += $"b = {b}\r\n\r\n";

            txtResultado.Text += "Inizializamos c = 3, d = c++\r\n";
            int c = 3;
            int d = c++;
            txtResultado.Text += "Resultado:\r\n";
            txtResultado.Text += $"c = {c}\r\n";
            txtResultado.Text += $"d = {d}\r\n";
            txtResultado.SelectionStart = 0;
        }
    }
}
