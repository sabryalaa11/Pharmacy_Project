using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp100
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=.;Database=OnlinePharmacy;Integrated Security=True;";
        private int currentMedicineId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMedicines();
            LoadCategories();
            LoadOrders();
        }

        private void LoadMedicines()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT m.MedicineID, m.MedicineName, m.Price, m.Stock, c.CategoryName, m.Manufacturer " +
                                 "FROM Medicines m " +
                                 "JOIN Categories c ON m.CategoryID = c.CategoryID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CategoryID, CategoryName FROM Categories";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    cmbCategory.Items.Clear();
                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(new { ID = reader["CategoryID"], Name = reader["CategoryName"] });
                    }
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT o.OrderID, u.FullName, o.OrderDate, o.TotalAmount, o.Status, o.PaymentMethod " +
                                 "FROM Orders o " +
                                 "JOIN Users u ON o.UserID = u.UserID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT m.MedicineID, m.MedicineName, m.Price, m.Stock, c.CategoryName, m.Manufacturer " +
                                 "FROM Medicines m " +
                                 "JOIN Categories c ON m.CategoryID = c.CategoryID " +
                                 "WHERE m.MedicineName LIKE @search OR m.Manufacturer LIKE @search";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMedicines();
            txtSearch.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                currentMedicineId = Convert.ToInt32(row.Cells["MedicineID"].Value);
                txtMedicineName.Text = row.Cells["MedicineName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
                
                // Find and select the category in the combo box
                foreach (var item in cmbCategory.Items)
                {
                    if (item.GetType().GetProperty("Name").GetValue(item).ToString() == row.Cells["CategoryName"].Value.ToString())
                    {
                        cmbCategory.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        
                        // First, get the maximum ID from the Medicines table
                        string getMaxIdQuery = "SELECT ISNULL(MAX(MedicineID), 0) + 1 FROM Medicines";
                        SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection);
                        int newId = Convert.ToInt32(getMaxIdCommand.ExecuteScalar());

                        // Then insert the new medicine with the generated ID
                        string query = "INSERT INTO Medicines (MedicineID, MedicineName, Price, Stock, CategoryID, Manufacturer) " +
                                     "VALUES (@MedicineID, @MedicineName, @Price, @Stock, @CategoryID, @Manufacturer)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MedicineID", newId);
                        command.Parameters.AddWithValue("@MedicineName", txtMedicineName.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        command.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                        command.Parameters.AddWithValue("@CategoryID", ((dynamic)cmbCategory.SelectedItem).ID);
                        command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show($"Medicine added successfully with ID: {newId}!");
                            ClearForm();
                            LoadMedicines();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding medicine: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentMedicineId == -1)
            {
                MessageBox.Show("Please select a medicine to update.");
                return;
            }

            if (ValidateInput())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Medicines SET MedicineName = @MedicineName, Price = @Price, " +
                                     "Stock = @Stock, CategoryID = @CategoryID, Manufacturer = @Manufacturer " +
                                     "WHERE MedicineID = @MedicineID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MedicineID", currentMedicineId);
                        command.Parameters.AddWithValue("@MedicineName", txtMedicineName.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        command.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                        command.Parameters.AddWithValue("@CategoryID", ((dynamic)cmbCategory.SelectedItem).ID);
                        command.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Medicine updated successfully!");
                            ClearForm();
                            LoadMedicines();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating medicine: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentMedicineId == -1)
            {
                MessageBox.Show("Please select a medicine to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this medicine?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Medicines WHERE MedicineID = @MedicineID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MedicineID", currentMedicineId);

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Medicine deleted successfully!");
                            ClearForm();
                            LoadMedicines();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting medicine: " + ex.Message);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("Please enter medicine name.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Please enter manufacturer name.");
                return false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            currentMedicineId = -1;
            txtMedicineName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtManufacturer.Clear();
            cmbCategory.SelectedIndex = -1;
        }
    }
}