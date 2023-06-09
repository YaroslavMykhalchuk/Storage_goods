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
            if (button_SwitchOnOff.Text == "ϳ�'�������� �� ��")
            {
                connStr = ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString;

                button_SwitchOnOff.Text = "³�'�������� �� ��";
                labelConnStatus.Text = "������: ϳ��������";
                tabControlMain.Visible = true;
                buttonDownload.Visible = true;
            }
            else
            {
                button_SwitchOnOff.Text = "ϳ�'�������� �� ��";
                labelConnStatus.Text = "������: ³��������";
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
                buttonDownload.Text = "����������� Goods";
                buttonDownload.Enabled = true;


            }
            else if (tabControlMain.SelectedTab == Type_Goods)
            {
                buttonDownload.Text = "����������� Type Goods";
                buttonDownload.Enabled = true;


            }
            else if (tabControlMain.SelectedTab == Providers)
            {
                buttonDownload.Text = "����������� Providers";
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
                case "�������� ����� � ������������ �������.":
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
                case "�������� ����� � ���������� �������.":
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
                case "�������� ����� � ���������� ����������.":
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
                case "�������� ����� � ������������ ����������.":
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
                case "�������� ������ ������ �������.":
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
                case "�������� ������ �������� �������������.":
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
                case "�������� �����, ���� ����������� �� ����� �������� � ���.":
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
                case "�������� ������� ������� ������ �� ������ ����� ������.":
                    {
                        query = "SELECT TG.Type_goods AS [Type], AVG(G.Quantity_goods) AS [Average quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                "GROUP BY TG.Type_goods";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "�������� ���������� ��� �������������, � ����� ������� ������ �� ����� ��������.":
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
                case "�������� ���������� ��� �������������, � ����� ������� ������ �� ����� ��������.":
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
                case "�������� ���������� ��� ��� ������ � ��������� ������� ������� �� �����.":
                    {
                        query = "SELECT TOP 1 TG.Type_goods AS [Type], SUM(G.Quantity_goods) as [Total Quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id = G.type_goods_ID " +
                                "GROUP BY TG.Type_goods " +
                                "ORDER BY [Total Quantity] DESC;";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "�������� ���������� ��� ��� ������ � ��������� ������� ������ �� �����.":
                    {
                        query = "SELECT TOP 1 TG.Type_goods AS [Type], SUM(G.Quantity_goods) as [Total Quantity] " +
                                "FROM Goods G " +
                                "JOIN Type_Goods TG ON TG.Id = G.type_goods_ID " +
                                "GROUP BY TG.Type_goods " +
                                "ORDER BY [Total Quantity]";
                        DownloadDataFromDB(query, dataGridViewOthers);
                    }
                    break;
                case "�������� ������, � ���������� ���� ������ ������ ������� ����.":
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
                        MessageBox.Show("������� �����!");
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

            if (comboBoxChooseQuery.Text == "�������� ������ ������ �������.")
            {
                comboBoxChooseItem.Visible = true;
                comboBoxChooseItem.Items.Clear();
                DownloadItemFromDB("SELECT * FROM Type_goods", comboBoxChooseItem);
            }
            else if (comboBoxChooseQuery.Text == "�������� ������ �������� �������������.")
            {
                comboBoxChooseItem.Visible = true;
                comboBoxChooseItem.Items.Clear();
                DownloadItemFromDB("SELECT * FROM Providers", comboBoxChooseItem);
            }
            else if (comboBoxChooseQuery.Text == "�������� ������, � ���������� ���� ������ ������ ������� ����.")
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
            }
            string query = "select TG.Id, TG.Type_goods AS [Type goods] from Type_Goods TG";

            DownloadDataFromDB(query, dataGridViewType_Goods);
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            AddProvider addProvider = new AddProvider(provider);

            if (addProvider.ShowDialog() == DialogResult.OK)
            {
                UploadDataToDb(provider);
            }
            string query = "select P.Id, P.Provider_name AS [Provider] from Providers P";
            DownloadDataFromDB(query, dataGridViewProviders);
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            AddGoods addGoods = new AddGoods(goods);

            if (addGoods.ShowDialog() == DialogResult.OK)
            {
                UploadDataToDb(goods);
            }
            string query = "SELECT G.Id, G.Name_goods AS [Name goods], TG.Type_goods AS [Type goods], " +
               "P.Provider_name AS [Provider], G.Quantity_goods AS [Quantity], G.Prime_cost AS [Prime cost], " +
               "G.Date_delivery AS [Date delivery] " +
               "FROM Goods G " +
               "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
               "JOIN Providers P ON P.Id=G.provider_ID";
            DownloadDataFromDB(query, dataGridViewType_Goods);
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
                    MessageBox.Show("���� ������ ������!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dataGridViewGoods.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ 1 ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewGoods.CurrentRow;

                goods.Type_goods_ID = AddIDFromDb("SELECT ID FROM Type_Goods WHERE Type_goods = @chooseID", row, "Type Goods");
                goods.Provider_ID = AddIDFromDb($"SELECT ID FROM Providers WHERE Provider_name = @chooseID", row, "Provider");

                goods.Name_goods = row.Cells["Name goods"].Value.ToString();
                //goods.Type_goods_ID = AddIDFromDb($"SELECT ID FROM Type_Goods WHERE Type_goods = '{row.Cells["Type Goods"].Value}'");
                //goods.Provider_ID = AddIDFromDb($"SELECT ID FROM Providers WHERE Provider_name = '{row.Cells["Provider"].Value}'");
                goods.Quantity_goods = Convert.ToInt32(row.Cells["Quantity"].Value);
                goods.Prime_cost = Convert.ToInt32(row.Cells["Prime cost"].Value);
                goods.Date_delivery = Convert.ToDateTime(row.Cells["Date delivery"].Value);

                AddGoods addGoods = new AddGoods(goods);

                if (addGoods.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataToDb(goods, row);

                    string query = "SELECT G.Id, G.Name_goods AS [Name goods], TG.Type_goods AS [Type goods], " +
                                   "P.Provider_name AS [Provider], G.Quantity_goods AS [Quantity], G.Prime_cost AS [Prime cost], " +
                                   "G.Date_delivery AS [Date delivery] " +
                                   "FROM Goods G " +
                                   "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                   "JOIN Providers P ON P.Id=G.provider_ID";
                    DownloadDataFromDB(query, dataGridViewType_Goods);
                }
            }
        }

        private void UpdateDataToDb(object obj, DataGridViewRow row)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn?.Open();

                    if (obj is Goods)
                    {
                        Goods goods = (Goods)obj;
                        string query = "UPDATE Goods " +
                                       "SET " +
                                       "Name_goods = @name, " +
                                       "Type_goods_ID = @typeId, " +
                                       "Provider_ID = @providerId, " +
                                       "Quantity_goods = @quantity, " +
                                       "Prime_cost = @cost, " +
                                       "Date_delivery = @date " +
                                      $"WHERE Id = {row.Cells["Id"].Value}";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@name", goods.Name_goods);
                        command.Parameters.AddWithValue("@typeId", goods.Type_goods_ID);
                        command.Parameters.AddWithValue("@providerId", goods.Provider_ID);
                        command.Parameters.AddWithValue("@quantity", goods.Quantity_goods);
                        command.Parameters.AddWithValue("@cost", goods.Prime_cost);
                        command.Parameters.AddWithValue("@date", goods.Date_delivery);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("����� ������ ��������!");
                        }
                        else
                        {
                            MessageBox.Show("�� ������� ������� �����!");
                        }
                    }
                    else if (obj is TypeGoods)
                    {
                        TypeGoods typeGoods = (TypeGoods)obj;

                        string query = "UPDATE Type_Goods " +
                                       "SET " +
                                       "Type_goods = @type " +
                                      $"WHERE Id = {row.Cells["Id"].Value}";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@type", typeGoods.Type_goods);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("����� ������ ��������!");
                        }
                        else
                        {
                            MessageBox.Show("�� ������� ������� �����!");
                        }
                    }
                    else if (obj is Provider)
                    {
                        Provider provider = (Provider)obj;

                        string query = "UPDATE Providers " +
                                       "SET " +
                                       "Provider_name = @provider " +
                                      $"WHERE Id = {row.Cells["Id"].Value}";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@provider", provider.Provider_name);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("����� ������ ��������!");
                        }
                        else
                        {
                            MessageBox.Show("�� ������� ������� �����!");
                        }
                    }
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

        private void buttonChangeType_Click(object sender, EventArgs e)
        {
            if (dataGridViewType_Goods.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewType_Goods.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ 1 ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewType_Goods.SelectedRows.Count == 1 && dataGridViewType_Goods.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewType_Goods.SelectedRows.Count == 1 && dataGridViewType_Goods.CurrentRow != null)
            {
                TypeGoods typeGoods = new TypeGoods();
                DataGridViewRow row = dataGridViewType_Goods.CurrentRow;

                typeGoods.Type_goods = row.Cells["Type goods"].Value.ToString();
                AddTypeGoods addTypeGoods = new AddTypeGoods(typeGoods);

                if (addTypeGoods.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataToDb(typeGoods, row);
                }
                string query = "select TG.Id, TG.Type_goods AS [Type goods] from Type_Goods TG";

                DownloadDataFromDB(query, dataGridViewType_Goods);

            }
        }

        private void buttonChangeProvider_Click(object sender, EventArgs e)
        {
            if (dataGridViewProviders.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewProviders.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ 1 ����� � ������, �� ������ ������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewProviders.SelectedRows.Count == 1 && dataGridViewProviders.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewProviders.SelectedRows.Count == 1 && dataGridViewProviders.CurrentRow != null)
            {
                Provider provider = new Provider();
                DataGridViewRow row = dataGridViewProviders.CurrentRow;

                provider.Provider_name = row.Cells["Provider"].Value.ToString();
                AddProvider addProvider = new AddProvider(provider);

                if (addProvider.ShowDialog() == DialogResult.OK)
                {
                    UpdateDataToDb(provider, row);
                }
                string query = "select P.Id, P.Provider_name AS [Provider] from Providers P";
                DownloadDataFromDB(query, dataGridViewProviders);
            }
        }

        private void DeleteDataFromDb(string str, DataGridViewRow row)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn?.Open();

                    string query = string.Empty, typeGoods = string.Empty, provider = string.Empty;
                    if (str == "Goods")
                    {
                        query = "DELETE FROM Goods WHERE Id = @id";

                    }
                    else if (str == "Type Goods")
                    {
                        query = "DELETE FROM Type_Goods WHERE Id = @id";
                        typeGoods = DownloadNameByIdFromDb($"SELECT TG.Type_Goods FROM Type_goods TG WHERE TG.Id = " +
                                                                  $"(SELECT Type_goods_ID FROM Goods WHERE Id = {row.Cells["Id"].Value})");
                    }
                    else if (str == "Provider")
                    {
                        query = "DELETE FROM Providers WHERE Id = @id";
                        provider = DownloadNameByIdFromDb($"SELECT P.Provider_name FROM Providers P WHERE P.Id = " +
                                                                 $"(SELECT Provider_ID FROM Goods WHERE Id = {row.Cells["Id"].Value})");
                    }

                    if (!string.IsNullOrEmpty(typeGoods))
                    {
                        MessageBox.Show($"��������� �������� �����, ������� � ������� Goods � ������ � ����� {typeGoods}.", "������� ��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!string.IsNullOrEmpty(provider))
                    {
                        MessageBox.Show($"��������� �������� �����, ������� � ������� Goods � ������ �� ������������� {provider}.", "������� ��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", row.Cells["Id"].Value);
                    command.ExecuteNonQuery();
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
        }

        private void buttonDeleteGoods_Click(object sender, EventArgs e)
        {
            if (dataGridViewGoods.SelectedRows.Count == 0 || dataGridViewGoods.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ ����� � ������, ���� ������ ��������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewGoods.SelectedRows.Count == 1 && dataGridViewGoods.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewGoods.CurrentRow;

                DialogResult result = MessageBox.Show("�� ����� ������ �������� ��� �����?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    DeleteDataFromDb("Goods", row);

                    string query = "SELECT G.Id, G.Name_goods AS [Name goods], TG.Type_goods AS [Type goods], " +
                                   "P.Provider_name AS [Provider], G.Quantity_goods AS [Quantity], G.Prime_cost AS [Prime cost], " +
                                   "G.Date_delivery AS [Date delivery] " +
                                   "FROM Goods G " +
                                   "JOIN Type_Goods TG ON TG.Id=G.type_goods_ID " +
                                   "JOIN Providers P ON P.Id=G.provider_ID";
                    DownloadDataFromDB(query, dataGridViewType_Goods);
                }
            }
        }

        private void buttonDeleteType_Click(object sender, EventArgs e)
        {
            if (dataGridViewType_Goods.SelectedRows.Count == 0 || dataGridViewType_Goods.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ ����� � ������, �� ������ ��������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewType_Goods.SelectedRows.Count == 1 && dataGridViewType_Goods.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewType_Goods.SelectedRows.Count == 1 && dataGridViewType_Goods.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewType_Goods.CurrentRow;

                DialogResult result = MessageBox.Show("�� ����� ������ �������� ��� �����?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    DeleteDataFromDb("Type Goods", row);

                    string query = "select TG.Id, TG.Type_goods AS [Type goods] from Type_Goods TG";

                    DownloadDataFromDB(query, dataGridViewType_Goods);
                }
            }
        }

        private void buttonDeleteProvider_Click(object sender, EventArgs e)
        {
            if (dataGridViewProviders.SelectedRows.Count == 0 || dataGridViewProviders.SelectedRows.Count > 1)
            {
                MessageBox.Show("������ ����� � ������, ���� ������ ��������!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewProviders.SelectedRows.Count == 1 && dataGridViewProviders.CurrentRow == null)
            {
                MessageBox.Show("�� ������ �������� �����", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewProviders.SelectedRows.Count == 1 && dataGridViewProviders.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewProviders.CurrentRow;

                DialogResult result = MessageBox.Show("�� ����� ������ �������� ��� �����?", "��������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    DeleteDataFromDb("Provider", row);

                    string query = "select P.Id, P.Provider_name AS [Provider] from Providers P";
                    DownloadDataFromDB(query, dataGridViewProviders);
                }
            }
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
