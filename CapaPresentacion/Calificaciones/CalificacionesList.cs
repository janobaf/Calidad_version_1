using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Calificaciones;
using CapaLogica.Calificaciones;
namespace CapaPresentacion.Calificaciones
{
    public partial class CalificacionesList : Form
    {
        public CalificacionesList()
        {
            InitializeComponent();
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            E_Calificaciones aux = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni_txt.Text);
            ProfesordataGridView1.Rows.Add(aux.Curso_id, aux.Califi_Promedio, aux.Califi_Parcial1, aux.Califi_Parcial2, aux.Califi_Trabajos, aux.Califi_Final);
        }

        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
