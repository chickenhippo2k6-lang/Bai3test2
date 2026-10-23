
namespace HospitalMDI
{
    partial class FormPatientProfiles
    {
        private System.ComponentModel.IContainer? components = null;

        private TableLayoutPanel tableMain = null!;
        private Panel panelTop = null!;
        private Label lblTitle = null!;
        private TextBox txtSearch = null!;
        private Button btnSearch = null!;
        private Button btnAdd = null!;
        private Button btnDelete = null!;
        private DataGridView dgvPatients = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            tableMain = new TableLayoutPanel();
            panelTop = new Panel();
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvPatients = new DataGridView();

            tableMain.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();

            // tableMain

            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));

            tableMain.RowCount = 2;
            tableMain.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 100F));
            tableMain.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            tableMain.Dock = DockStyle.Fill;
            tableMain.Padding = new Padding(10);
            tableMain.Controls.Add(panelTop, 0, 0);
            tableMain.Controls.Add(dgvPatients, 0, 1);

            // panelTop

            panelTop.Dock = DockStyle.Fill;
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnDelete);

            // lblTitle

            lblTitle.Text = "QUẢN LÝ HỒ SƠ BỆNH NHÂN";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(5, 5);
            lblTitle.Size = new Size(450, 30);

            // txtSearch

            txtSearch.Name = "txtSearch";
            txtSearch.Location = new Point(5, 48);
            txtSearch.Size = new Size(250, 27);
            txtSearch.PlaceholderText = "Nhập mã hoặc tên bệnh nhân";

            // btnSearch

            btnSearch.Name = "btnSearch";
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Location = new Point(265, 45);
            btnSearch.Size = new Size(100, 32);

            // btnAdd

            btnAdd.Name = "btnAdd";
            btnAdd.Text = "Thêm bệnh nhân";
            btnAdd.Location = new Point(375, 45);
            btnAdd.Size = new Size(140, 32);

            // btnDelete

            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Xóa";
            btnDelete.Location = new Point(525, 45);
            btnDelete.Size = new Size(80, 32);

            // dgvPatients

            dgvPatients.Name = "dgvPatients";
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.ReadOnly = true;
            dgvPatients.MultiSelect = false;
            dgvPatients.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.RowHeadersVisible = false;

            // Form

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Name = "FormPatientProfiles";
            Text = "Hồ sơ bệnh nhân";

            Controls.Add(tableMain);

            tableMain.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }
    }
}
