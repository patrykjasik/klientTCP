using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace klientTCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void polaczenie_Click(object sender, EventArgs e)
        {

            string host = adres.Text;
            int port = System.Convert.ToInt32(port_p.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);

                listBox1.Items.Add("Nawiązano połączenie z " + host +
                    " na porcie: " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
