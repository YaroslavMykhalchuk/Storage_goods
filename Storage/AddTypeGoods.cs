using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Storage
{
    public partial class AddTypeGoods : Form
    {
        private readonly TypeGoods typeGoods;
        public AddTypeGoods(TypeGoods typeGoods)
        {
            InitializeComponent();
            this.typeGoods = typeGoods;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxAddType.Text))
            {
                typeGoods.Type_goods = textBoxAddType.Text;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Заповніть пусте поле!", "Еrror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
