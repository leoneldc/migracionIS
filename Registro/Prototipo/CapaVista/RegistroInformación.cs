using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroInformación : Form
    {
        public RegistroInformación()
        {
            InitializeComponent();
        }

        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Municipios de Alta Verapaz
            DataTable Municipios_Alta_Verapaz = new DataTable();
            Municipios_Alta_Verapaz.Columns.Add("municipio");
            DataRow row1 = Municipios_Alta_Verapaz.NewRow();
            row1["municipio"] = "Cobán";
            Municipios_Alta_Verapaz.Rows.Add(row1);
            DataRow row2 = Municipios_Alta_Verapaz.NewRow();
            row2["municipio"] = "Santa Cruz Verapaz";
            Municipios_Alta_Verapaz.Rows.Add(row2);
            DataRow row3 = Municipios_Alta_Verapaz.NewRow();
            row3["municipio"] = "San Cristobal Verapaz";
            Municipios_Alta_Verapaz.Rows.Add(row3);
            DataRow row4 = Municipios_Alta_Verapaz.NewRow();
            row4["municipio"] = "Tactic";
            Municipios_Alta_Verapaz.Rows.Add(row4);
            DataRow row5 = Municipios_Alta_Verapaz.NewRow();
            row5["municipio"] = "Tamahú";
            Municipios_Alta_Verapaz.Rows.Add(row5);
            DataRow row6 = Municipios_Alta_Verapaz.NewRow();
            row6["municipio"] = "San Miguel Tucurú";
            Municipios_Alta_Verapaz.Rows.Add(row6);
            DataRow row7 = Municipios_Alta_Verapaz.NewRow();
            row7["municipio"] = "Panzos";
            Municipios_Alta_Verapaz.Rows.Add(row7);
            DataRow row8 = Municipios_Alta_Verapaz.NewRow();
            row8["municipio"] = "Senahú";
            Municipios_Alta_Verapaz.Rows.Add(row8);
            DataRow row9 = Municipios_Alta_Verapaz.NewRow();
            row9["municipio"] = "San Pedro Carchá";
            Municipios_Alta_Verapaz.Rows.Add(row9);
            DataRow row10 = Municipios_Alta_Verapaz.NewRow();
            row10["municipio"] = "San Juan Chamelco";
            Municipios_Alta_Verapaz.Rows.Add(row10);
            DataRow row11 = Municipios_Alta_Verapaz.NewRow();
            row11["municipio"] = "Lanquin";
            Municipios_Alta_Verapaz.Rows.Add(row11);
            DataRow row12 = Municipios_Alta_Verapaz.NewRow();
            row12["municipio"] = "Santa Maria Chabón";
            Municipios_Alta_Verapaz.Rows.Add(row12);
            DataRow row13 = Municipios_Alta_Verapaz.NewRow();
            row13["municipio"] = "Chisec";
            Municipios_Alta_Verapaz.Rows.Add(row13);
            DataRow row14 = Municipios_Alta_Verapaz.NewRow();
            row14["municipio"] = "Chahal";
            Municipios_Alta_Verapaz.Rows.Add(row14);
            DataRow row15 = Municipios_Alta_Verapaz.NewRow();
            row15["municipio"] = "Fray Bartolomé de las Casas";
            Municipios_Alta_Verapaz.Rows.Add(row15);
            DataRow row16 = Municipios_Alta_Verapaz.NewRow();
            row16["municipio"] = "Santa Catarina la Tinta";
            Municipios_Alta_Verapaz.Rows.Add(row16);

            //Municipios de Baja Verapaz
            DataTable Municipios_Baja_Verapaz = new DataTable();
            Municipios_Baja_Verapaz.Columns.Add("municipio");
            DataRow row17 = Municipios_Baja_Verapaz.NewRow();
            row17["municipio"] = "Salamá";
            Municipios_Baja_Verapaz.Rows.Add(row17);
            DataRow row18 = Municipios_Baja_Verapaz.NewRow();
            row18["municipio"] = "San Miguel Chicaj";
            Municipios_Baja_Verapaz.Rows.Add(row18);
            DataRow row19 = Municipios_Baja_Verapaz.NewRow();
            row19["municipio"] = "Rabinal";
            Municipios_Baja_Verapaz.Rows.Add(row19);
            DataRow row20 = Municipios_Baja_Verapaz.NewRow();
            row20["municipio"] = "Cubulco";
            Municipios_Baja_Verapaz.Rows.Add(row20);
            DataRow row21 = Municipios_Baja_Verapaz.NewRow();
            row21["municipio"] = "Granados";
            Municipios_Baja_Verapaz.Rows.Add(row21);
            DataRow row22 = Municipios_Baja_Verapaz.NewRow();
            row22["municipio"] = "Santa Cruz El Chol";
            Municipios_Baja_Verapaz.Rows.Add(row22);
            DataRow row23 = Municipios_Baja_Verapaz.NewRow();
            row23["municipio"] = "San Jerónimo";
            Municipios_Baja_Verapaz.Rows.Add(row23);
            DataRow row24 = Municipios_Baja_Verapaz.NewRow();
            row24["municipio"] = "Purulhá";
            Municipios_Baja_Verapaz.Rows.Add(row24);

            if (cbxDepartamento.SelectedIndex == 0)
            {
                cbxMunicipio.DataSource = Municipios_Alta_Verapaz;
                cbxMunicipio.DisplayMember = "municipio";
            }else if(cbxDepartamento.SelectedIndex == 1)
            {
                cbxMunicipio.DataSource = Municipios_Baja_Verapaz;
                cbxMunicipio.DisplayMember = "municipio";
            }
        }
    }
}
