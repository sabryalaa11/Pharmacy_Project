namespace WinFormsApp100
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            groupBox2 = new GroupBox();
            txtMedicineName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtManufacturer = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();

            // tabControl1
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 600);
            tabControl1.TabIndex = 0;

            // tabPage1
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(992, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Medicines";
            tabPage1.UseVisualStyleBackColor = true;

            // tabPage2
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(992, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add/Edit Medicine";
            tabPage2.UseVisualStyleBackColor = true;

            // tabPage3
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(992, 567);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;

            // dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(980, 461);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // groupBox1
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(986, 91);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";

            // txtSearch
            txtSearch.Location = new Point(6, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 0;

            // btnSearch
            btnSearch.Location = new Point(312, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // btnRefresh
            btnRefresh.Location = new Point(412, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;

            // groupBox2
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbCategory);
            groupBox2.Controls.Add(txtManufacturer);
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtMedicineName);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(986, 561);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medicine Details";

            // txtMedicineName
            txtMedicineName.Location = new Point(150, 26);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(300, 27);
            txtMedicineName.TabIndex = 0;

            // txtPrice
            txtPrice.Location = new Point(150, 59);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 27);
            txtPrice.TabIndex = 1;

            // txtStock
            txtStock.Location = new Point(150, 92);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(300, 27);
            txtStock.TabIndex = 2;

            // txtManufacturer
            txtManufacturer.Location = new Point(150, 125);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(300, 27);
            txtManufacturer.TabIndex = 3;

            // cmbCategory
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(150, 158);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 28);
            cmbCategory.TabIndex = 4;

            // btnAdd
            btnAdd.Location = new Point(150, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // btnUpdate
            btnUpdate.Location = new Point(250, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Location = new Point(350, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 8;
            label1.Text = "Medicine Name:";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 9;
            label2.Text = "Price:";

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 10;
            label3.Text = "Stock:";

            // label4
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 11;
            label4.Text = "Manufacturer:";

            // label5
            label5.AutoSize = true;
            label5.Location = new Point(6, 161);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 12;
            label5.Text = "Category:";

            // groupBox3
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(986, 561);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Orders";

            // dataGridView2
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(980, 535);
            dataGridView2.TabIndex = 0;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Online Pharmacy Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private TextBox txtManufacturer;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtMedicineName;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
    }
} 