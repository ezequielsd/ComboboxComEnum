using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploEnumCombobox
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PreencherCombobox();
        }

        private void PreencherCombobox()
        {
            cmbDiasSemana.DisplayMember = "Description";
            cmbDiasSemana.ValueMember = "Value";
            cmbDiasSemana.DataSource = Enum.GetValues(typeof(EnumDiasSemana)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
        }

        private void btnSelecionaQuinta_Click(object sender, EventArgs e)
        {
            cmbDiasSemana.SelectedIndex = 4;
        }
    }
}
