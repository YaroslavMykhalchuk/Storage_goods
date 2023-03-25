using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class AddProvider : Form
    {
        private readonly Provider provider;
        public AddProvider(Provider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBoxAddProvider.Text))
            {
                provider.Provider_name = textBoxAddProvider.Text;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Заповніть пусте поле!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
