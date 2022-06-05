using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Becas;
namespace CapaPresentacion
{
    public partial class Becas_Por_Exelencia : Form
    {
        public Becas_Por_Exelencia()
        {
            InitializeComponent();
            listado();
        }
        private void listado()
        {
            dataGridView1.DataSource = CL_BecaExcelencia.Instancia.ListaBecados();
            setCustomColumHeader();
        }
        public void setCustomColumHeader()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "nombre";
            dataGridView1.Columns[2].HeaderText = "apellido";
            dataGridView1.Columns[3].HeaderText = "segundo apellido";   
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
