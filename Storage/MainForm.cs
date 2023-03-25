using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Storage
{
    public partial class MainForm : Form
    {
        string connStr;
        DataTable dt;

        private string previousComboBoxChooseQuery;
        private string previousComboBoxChooseItem;
        public MainForm()
        {
            InitializeComponent();

            tabControlMain.Visible = false;
            buttonDownload.Visible = false;
            labelInputNumber.Visible = false;
            numericUpDownInputNumber.Visible = false;
        }

        private void button_SwitchOnOff_Click(object sender, EventArgs e)
        {
            if (button_SwitchOnOff.Text == "Під'єднатися до БД")
            {
                connStr = ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;

                button_SwitchOnOff.Text = "Від'єднатися від БД";
                labelConnStatus.Text = "Статус: Підключено";
                tabControlMain.Visible = true;
                buttonDownload.Visible = true;
            }
            else
            {
                button_SwitchOnOff.Text = "Під'єднатися до БД";
                labelConnStatus.Text = "Статус: Відключено";
                tabControlMain.Visible = false;
                buttonDownload.Visible = false;
                connStr = String.Empty;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == Goods)
            {
                string query = "SELECT G.Id, G.Name_goods AS [Name goods], TG.Type_goods AS [Type goods], " +
                               "P.Provider_name AS [Provider], G.Quantity_goods AS [Quantity], G.Prime_cost AS [Prime cost], " +
                               "G.Date_delivery AS [Date delivery] " +
                               "FROM Goods G " +
                               "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                               "JOIN Providers P ON P.Id=G.provider_ID";
                DownloadDataFromDB(query, dataGridViewGoods);
            }
            else if (tabControlMain.SelectedTab == Type_Goods)
            {
                string query = "select TG.Id, TG.Type_goods AS [Type goods] from Type_Goods TG";
                DownloadDataFromDB(query, dataGridViewType_Goods);
            }
            else if (tabControlMain.SelectedTab == Providers)
            {
                string query = "select P.Id, P.Provider_name AS [Provider] from Providers P";
                DownloadDataFromDB(query, dataGridViewProviders);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == Goods)
            {
                buttonDownload.Text = "Завантажити Goods";
                buttonDownload.Enabled = true;


            }
            else if (tabControlMain.SelectedTab == Type_Goods)
            {
                buttonDownload.Text = "Завантажити Type Goods";
                buttonDownload.Enabled = true;


            }
            else if (tabControlMain.SelectedTab == Providers)
            {
                buttonDownload.Text = "Завантажити Providers";
                buttonDownload.Enabled = true;

            }
            else if (tabControlMain.SelectedTab == Others)
            {
                buttonDownload.Enabled = false;
                buttonDownload.Text = string.Empty;
            }
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            string query;
            switch (comboBoxChooseQuery.Text)
            {
                case "Показати товар з максимальною кількістю.":
                    {
                        comboBoxChooseItem.Visible = false;

                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE Quantity_goods = (" +
                                "SELECT MAX(Quantity_goods) " +
                                "FROM Goods)";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товар з мінімальною кількістю.":
                    {
                        comboBoxChooseItem.Visible = false;

                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE Quantity_goods = (" +
                                "SELECT MIN(Quantity_goods) " +
                                "FROM Goods)";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товар з мінімальною собівартістю.":
                    {
                        comboBoxChooseItem.Visible = false;

                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE Prime_cost = (" +
                                "SELECT MIN(Prime_cost) " +
                                "FROM Goods)";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товар з максимальною собівартістю.":
                    {
                        comboBoxChooseItem.Visible = false;

                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE Prime_cost = (" +
                                "SELECT MAX(Prime_cost) " +
                                "FROM Goods)";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товари заданої категорії.":
                    {
                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE TG.Type_goods = @chooseItem";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товари заданого постачальника.":
                    {
                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE P.Provider_name = @chooseItem";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товар, який знаходиться на складі найдовше з усіх.":
                    {
                        query = "SELECT TOP 1 G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], P.Provider_name as [Provider], " +
                                "G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "ORDER BY G.Date_delivery ASC";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати середню кількість товарів за кожним типом товару.":
                    {
                        query = "SELECT TG.Type_goods AS [Type], AVG(G.Quantity_goods) AS [Average quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "GROUP BY TG.Type_goods";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати інформацію про постачальника, в якого кількість товарів на складі найбільша.":
                    {
                        query = "SELECT P.Id, P.Provider_name AS [Provider], G.Total_quantity AS [Total quantity] " +
                                "FROM Providers P " +
                                "JOIN (" +
                                "SELECT provider_ID, SUM(Quantity_goods) AS Total_quantity " +
                                "FROM Goods " +
                                "GROUP BY provider_ID " +
                                "HAVING SUM(Quantity_goods) = (" +
                                "SELECT MAX(Total_quantity) " +
                                "FROM ( " +
                                "SELECT SUM(Quantity_goods) AS Total_quantity " +
                                "FROM Goods " +
                                "GROUP BY provider_ID) T)) G " +
                                "ON P.Id = G.provider_ID;";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати інформацію про постачальника, в якого кількість товарів на складі найменша.":
                    {
                        query = "SELECT P.Id, P.Provider_name AS [Provider], G.Total_quantity AS [Total quantity] " +
                                "FROM Providers P " +
                                "JOIN (" +
                                "SELECT provider_ID, SUM(Quantity_goods) AS Total_quantity " +
                                "FROM Goods " +
                                "GROUP BY provider_ID " +
                                "HAVING SUM(Quantity_goods) = (" +
                                "SELECT MIN(Total_quantity) " +
                                "FROM ( " +
                                "SELECT SUM(Quantity_goods) AS Total_quantity " +
                                "FROM Goods " +
                                "GROUP BY provider_ID) T)) G " +
                                "ON P.Id = G.provider_ID;";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати інформацію про тип товару з найбільшою кількістю одиниць на складі.":
                    {
                        query = "SELECT TOP 1 TG.Type_goods AS [Type], SUM(G.Quantity_goods) as [Total Quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id = G.type_goods_ID " +
                                "GROUP BY TG.Type_goods " +
                                "ORDER BY [Total Quantity] DESC;";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати інформацію про тип товарів з найменшою кількістю товарів на складі.":
                    {
                        query = "SELECT TOP 1 TG.Type_goods AS [Type], SUM(G.Quantity_goods) as [Total Quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id = G.type_goods_ID " +
                                "GROUP BY TG.Type_goods " +
                                "ORDER BY [Total Quantity]";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "Показати товари, з постачання яких минула задана кількість днів.":
                    {
                        query = "SELECT G.Id, G.Name_goods as [Name goods], TG.Type_goods as [Type goods], " +
                                "P.Provider_name as [Provider], G.Quantity_goods as [Quantity], G.Prime_cost as [Prime cost], " +
                                "G.Date_delivery as [Date delivery] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "JOIN Providers P ON P.Id=G.provider_ID " +
                                "WHERE G.Date_delivery < DATEADD(day, -@chooseItem, GETDATE())";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Виберіть запит!");
                    }
                    break;
            }
        }

        private void DownloadItemFromDB(string query, ComboBox comboBoxChooseItem)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxChooseItem.Items.Add(reader.GetString(1));
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

        private void DownloadDataFromDB(string query, DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataReader reader = null;
                dt = new DataTable();

                SqlCommand command = new SqlCommand(query, conn);
                if (query.Contains("@chooseItem") && comboBoxChooseItem.Visible == true)
                {
                    command.Parameters.AddWithValue("@chooseItem", comboBoxChooseItem.Text);
                }
                else if (query.Contains("@chooseItem") && numericUpDownInputNumber.Visible == true)
                {
                    command.Parameters.AddWithValue("@chooseItem", numericUpDownInputNumber.Value);
                }
                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                    bool firstCheck = false;

                    while (reader.Read())
                    {
                        if (!firstCheck)
                        {
                            firstCheck = true;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dt.Columns.Add(reader.GetName(i));
                            }
                        }
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        dt.Rows.Add(row);
                    }
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reader.Close();
                    conn.Close();
                }
                finally
                {
                    reader?.Close();
                    conn?.Close();
                }
            }
        }

        private void comboBoxChooseQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentComboBoxChooseQuery = comboBoxChooseQuery.SelectedItem.ToString();
            if (currentComboBoxChooseQuery != previousComboBoxChooseQuery)
            {
                dataGridViewOthers.DataSource = null;
            }
            previousComboBoxChooseQuery = currentComboBoxChooseQuery;

            if (comboBoxChooseQuery.Text == "Показати товари заданої категорії.")
            {
                comboBoxChooseItem.Visible = true;
                comboBoxChooseItem.Items.Clear();
                DownloadItemFromDB("SELECT * FROM Type_goods", comboBoxChooseItem);
            }
            else if (comboBoxChooseQuery.Text == "Показати товари заданого постачальника.")
            {
                comboBoxChooseItem.Visible = true;
                comboBoxChooseItem.Items.Clear();
                DownloadItemFromDB("SELECT * FROM Providers", comboBoxChooseItem);
            }
            else if (comboBoxChooseQuery.Text == "Показати товари, з постачання яких минула задана кількість днів.")
            {
                comboBoxChooseItem.Visible = false;
                labelInputNumber.Visible = true;
                numericUpDownInputNumber.Visible = true;
            }
            else
            {
                comboBoxChooseItem.Visible = false;
                labelInputNumber.Visible = false;
                numericUpDownInputNumber.Visible = false;
                numericUpDownInputNumber.Value = 0;
            }
        }

        private void comboBoxChooseItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentComboBoxChooseItem = comboBoxChooseItem.SelectedItem.ToString();
            if (currentComboBoxChooseItem != previousComboBoxChooseItem)
            {
                dataGridViewOthers.DataSource = null;
            }
            previousComboBoxChooseItem = currentComboBoxChooseItem;
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            TypeGoods typeGoods = new TypeGoods();
            AddTypeGoods addTypeGoods = new AddTypeGoods(typeGoods);

            if (addTypeGoods.ShowDialog() == DialogResult.OK)
            {
                UploadDataToDb(typeGoods);

                string query = "select TG.Id, TG.Type_goods AS [Type goods] from Type_Goods TG";

                DownloadDataFromDB(query, dataGridViewType_Goods);
            }
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            AddProvider addProvider = new AddProvider(provider);

            if (addProvider.ShowDialog() == DialogResult.OK)
            {
                UploadDataToDb(provider);

                string query = "select P.Id, P.Provider_name AS [Provider] from Providers P";
                DownloadDataFromDB(query, dataGridViewProviders);
            }
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            AddGoods addGoods = new AddGoods(goods);

            if (addGoods.ShowDialog() == DialogResult.OK)
            {
                UploadDataToDb(goods);

                string query = "SELECT G.Id, G.Name_goods AS [Name goods], TG.Type_goods AS [Type goods], " +
                               "P.Provider_name AS [Provider], G.Quantity_goods AS [Quantity], G.Prime_cost AS [Prime cost], " +
                               "G.Date_delivery AS [Date delivery] " +
                               "FROM Goods G " +
                               "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                               "JOIN Providers P ON P.Id=G.provider_ID";
                DownloadDataFromDB(query, dataGridViewType_Goods);
            }
        }

        private void UploadDataToDb(object obj)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn?.Open();

                    if (obj is Goods)
                    {
                        Goods goods = (Goods)obj;

                        string query = $"INSERT INTO Goods VALUES( N'{goods.Name_goods}', '{goods.Type_goods_ID}', '{goods.Provider_ID}', '{goods.Quantity_goods}', '{goods.Prime_cost}', '{goods.Date_delivery.ToString("yyyy-MM-dd HH:mm:ss")}')";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.ExecuteNonQuery();
                    }
                    else if (obj is Provider)
                    {
                        Provider provider = (Provider)obj;
                        string query = "INSERT INTO Providers (Provider_name) VALUES (@Name);";

                        SqlCommand command = new SqlCommand(query, conn);

                        command.Parameters.AddWithValue("@Name", provider.Provider_name);

                        command.ExecuteNonQuery();
                    }
                    else if (obj is TypeGoods)
                    {
                        TypeGoods typeGoods = (TypeGoods)obj;
                        string query = "INSERT INTO Type_Goods (Type_goods) VALUES (@type);";

                        SqlCommand command = new SqlCommand(query, conn);

                        command.Parameters.AddWithValue("@type", typeGoods.Type_goods);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Дані успішно додані!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn?.Close();
                }
            }
        }

        private void UpdateDataInDb(DataGridView dataGridView, object obj)
        {
            
        }

        private int AddIDFromDb(string query, DataGridViewRow row, string str)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    string chooseID = row.Cells[$"{str}"].Value.ToString();
                    command.Parameters.AddWithValue("@chooseID", chooseID);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
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
            return -1;
        }

        private void buttonChangeGoods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            DataGridViewRow row = dataGridViewGoods.CurrentRow;

            if (dataGridViewGoods.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть рядок з даними, які хочете змінити!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count > 1)
            {
                MessageBox.Show("Оберіть 1 рядок з даними, які хочете змінити!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow == null)
            {
                MessageBox.Show("Ви обрали порожній рядок", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow != null)
            {
                goods.Type_goods_ID = AddIDFromDb("SELECT ID FROM Type_Goods WHERE Type_goods = @chooseID", row, "Type Goods");
                goods.Provider_ID = AddIDFromDb($"SELECT ID FROM Providers WHERE Provider_name = @chooseID", row, "Provider");

                goods.Name_goods = row.Cells["Name goods"].Value.ToString();
                //goods.Type_goods_ID = AddIDFromDb($"SELECT ID FROM Type_Goods WHERE Type_goods = '{row.Cells["Type Goods"].Value}'");
                //goods.Provider_ID = AddIDFromDb($"SELECT ID FROM Providers WHERE Provider_name = '{row.Cells["Provider"].Value}'");
                goods.Quantity_goods = Convert.ToInt32(row.Cells["Quantity"].Value);
                goods.Prime_cost = Convert.ToInt32(row.Cells["Prime cost"].Value);
                goods.Date_delivery = Convert.ToDateTime(row.Cells["Date delivery"].Value);
            }

            AddGoods addGoods = new AddGoods(goods);

            if (addGoods.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void UploadChangedDataToDb(object obj)
        {

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn?.Open();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn?.Close();
                }
            }
        }
    }
}
