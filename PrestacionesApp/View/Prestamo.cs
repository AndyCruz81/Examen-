using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestacionesApp
{
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();

            cmbPeriodo.Items.AddRange(
                Enum.GetValues(typeof(Enums.Periodo)).Cast<object>().ToArray()
            );
            cmbPeriodo.SelectedIndex = 0;
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
