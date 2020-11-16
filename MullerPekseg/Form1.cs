using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MullerPekseg
{
    public partial class MullerPeksegForm : Form
    {

        private List<Pekaru> pekaruLista;
        private List<Pekseg> peksegLista;
        public MullerPeksegForm()
        {
            InitializeComponent();
            pekaruLista = new List<Pekaru>();
            peksegLista = new List<Pekseg>();
        }

        private void hozzaadasBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Pekaru p = new Pekaru(nevTB.Text, int.Parse(arTB.Text), laktozmentesCB.Checked);
                pekaruLista.Add(p);
                FormUrit();
            }
            catch
            {
                MessageBox.Show("Helytelen értékeket adott meg!");
            }
            pekaruLstBx.Items.Clear();
            for(int i = 0; i < pekaruLista.Count; i++)
            {
                pekaruLstBx.Items.Add(pekaruLista[i].toString());
            }
        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            pekaruLista.RemoveAt(pekaruLstBx.SelectedIndex);
            pekaruLstBx.Items.Clear();
            for (int i = 0; i < pekaruLista.Count; i++)
            {
                pekaruLstBx.Items.Add(pekaruLista[i].toString());
            }
            torlesBtn.Visible = false;
            FormUrit();
        }

        private void pekaruLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            nevTB.Text = pekaruLista[pekaruLstBx.SelectedIndex].Nev;
            arTB.Text =     Convert.ToString(pekaruLista[pekaruLstBx.SelectedIndex].Ar);
            laktozmentesCB.Checked = pekaruLista[pekaruLstBx.SelectedIndex].Laktozmentes;
            torlesBtn.Visible = true;
        }

        private void FormUrit()
        {
            nevTB.Text = "";
            arTB.Text = null;
            laktozmentesCB.Checked = false;
        }

        private void hozzaad2Btn_Click(object sender, EventArgs e)
        {
           
            Pekseg p2 = new Pekseg(peskegNevTB.Text);
            peksegLista.Add(p2);
            peksegekLstBx.Items.Clear();
            for (int i = 0; i < peksegLista.Count; i++)
            {
                peksegekLstBx.Items.Add(peksegLista[i].toString());
            }
            peskegNevTB.Text = "";

        }
    }
}