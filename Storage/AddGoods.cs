using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Storage
{
    public partial class AddGoods : Form
    {
        private readonly Goods goods;
        //List<Provider> providers = new List<Provider>();
        string connStr = ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;

        public AddGoods(Goods goods)
        {
            InitializeComponent();
            this.goods = goods;
            DownloadToComboBoxFromDb("Select * from Providers", comboBoxProvider);
            DownloadToComboBoxFromDb("Select * from Type_Goods", comboBoxType);

            if (goods.Name_goods != null)
            {
                Text = "Редагуйте товар";
                textBoxAddName.Text = goods.Name_goods;
                comboBoxType.SelectedItem = DownloadNameByIdFromDb($"SELECT TG.Type_Goods FROM Type_goods TG WHERE TG.Id = {goods.Type_goods_ID}");
                comboBoxProvider.SelectedItem = DownloadNameByIdFromDb($"SELECT P.Provider_name FROM Providers P WHERE p.Id = {goods.Provider_ID}");
                textBoxAddQuantity.Text = goods.Quantity_goods.ToString();
                textBoxAddPrimeCost.Text = goods.Prime_cost.ToString();
                if (goods.Date_delivery == default(DateTime))
                {
                    dateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    dateTimePicker.Value = goods.Date_delivery;
                }
            }
            else
            {
                Text = "Додайте товар";
            }
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxAddName.Text) && !String.IsNullOrWhiteSpace(textBoxAddPrimeCost.Text) && !String.IsNullOrWhiteSpace(textBoxAddQuantity.Text))
            {
                goods.Name_goods = textBoxAddName.Text;
                if (comboBoxType.SelectedIndex != -1)
                {
                    goods.Type_goods_ID = AddIDFromDb($"SELECT TG.Id FROM Type_Goods TG WHERE TG.Type_goods = @data", comboBoxType);
                }
                if(comboBoxProvider.SelectedIndex != -1)
                {
                    goods.Provider_ID = AddIDFromDb($"SELECT P.Id FROM Providers P WHERE P.Provider_name = @data", comboBoxProvider);
                }
                int quantity;
                if (int.TryParse(textBoxAddQuantity.Text, out quantity))
                    goods.Quantity_goods = quantity;
                else
                    MessageBox.Show("Ви ввели невірну кількість товару!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int primeCost;
                if (int.TryParse(textBoxAddPrimeCost.Text, out primeCost))
                    goods.Prime_cost = primeCost;
                else
                    MessageBox.Show("Ви ввели невірну собівартість товару!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goods.Date_delivery = dateTimePicker.Value.Date;
            }
            else
                MessageBox.Show("Заповніть порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            goods.Date_delivery = dateTimePicker.Value.Date;

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DownloadToComboBoxFromDb(string query, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = null;

                try
                {
                    conn?.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetString(1));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader?.Close();
                    conn?.Close();
                }
            }
        }

        private int? AddIDFromDb(string query, ComboBox comboBox)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@data", comboBox.Text);
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        private string DownloadNameByIdFromDb(string query)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    object result = command.ExecuteScalar();
                    return Convert.ToString(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return string.Empty;
        }

    }
}
