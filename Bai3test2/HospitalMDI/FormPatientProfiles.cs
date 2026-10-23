
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HospitalMDI
{
    public partial class FormPatientProfiles : Form
    {
        private class Patient
        {
            public string PatientId { get; set; } = "";
            public string FullName { get; set; } = "";
            public int Age { get; set; }
            public string Gender { get; set; } = "";
            public string Diagnosis { get; set; } = "";
        }

        private readonly BindingList<Patient> patients = new();
        private readonly BindingSource source = new();

        public FormPatientProfiles()
        {
            InitializeComponent();

            patients.Add(new Patient
            {
                PatientId = "BN001",
                FullName = "Nguyễn Văn Minh",
                Age = 35,
                Gender = "Nam",
                Diagnosis = "Cảm cúm"
            });

            patients.Add(new Patient
            {
                PatientId = "BN002",
                FullName = "Trần Thị Hoa",
                Age = 28,
                Gender = "Nữ",
                Diagnosis = "Khám định kỳ"
            });

            patients.Add(new Patient
            {
                PatientId = "BN003",
                FullName = "Lê Văn Nam",
                Age = 46,
                Gender = "Nam",
                Diagnosis = "Tăng huyết áp"
            });

            SetupGrid();

            source.DataSource = patients;
            dgvPatients.DataSource = source;

            btnSearch.Click += (s, e) => SearchPatient();
            btnAdd.Click += (s, e) => AddPatient();
            btnDelete.Click += (s, e) => DeletePatient();
        }

        private void SetupGrid()
        {
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.Columns.Clear();

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã bệnh nhân",
                DataPropertyName = nameof(Patient.PatientId)
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Họ và tên",
                DataPropertyName = nameof(Patient.FullName)
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tuổi",
                DataPropertyName = nameof(Patient.Age)
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Giới tính",
                DataPropertyName = nameof(Patient.Gender)
            });

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chẩn đoán",
                DataPropertyName = nameof(Patient.Diagnosis)
            });
        }

        private void SearchPatient()
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword.Length == 0)
            {
                source.DataSource = patients;
                return;
            }

            var result = patients
                .Where(p =>
                    p.PatientId.Contains(
                        keyword, StringComparison.OrdinalIgnoreCase) ||
                    p.FullName.Contains(
                        keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            source.DataSource = result;
        }

        private void AddPatient()
        {
            using Form input = new()
            {
                Text = "Thêm bệnh nhân",
                Size = new System.Drawing.Size(380, 280),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblName = new()
            {
                Text = "Họ và tên",
                Location = new System.Drawing.Point(15, 20),
                AutoSize = true
            };

            TextBox txtName = new()
            {
                Location = new System.Drawing.Point(120, 16),
                Width = 220
            };

            Label lblAge = new()
            {
                Text = "Tuổi",
                Location = new System.Drawing.Point(15, 60),
                AutoSize = true
            };

            NumericUpDown numAge = new()
            {
                Location = new System.Drawing.Point(120, 56),
                Width = 100,
                Minimum = 1,
                Maximum = 120,
                Value = 25
            };

            Label lblGender = new()
            {
                Text = "Giới tính",
                Location = new System.Drawing.Point(15, 100),
                AutoSize = true
            };

            ComboBox cboGender = new()
            {
                Location = new System.Drawing.Point(120, 96),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.SelectedIndex = 0;

            Label lblDiagnosis = new()
            {
                Text = "Chẩn đoán",
                Location = new System.Drawing.Point(15, 140),
                AutoSize = true
            };

            TextBox txtDiagnosis = new()
            {
                Location = new System.Drawing.Point(120, 136),
                Width = 220
            };

            Button btnSave = new()
            {
                Text = "Lưu",
                Location = new System.Drawing.Point(120, 185),
                Width = 100,
                DialogResult = DialogResult.OK
            };

            input.Controls.Add(lblName);
            input.Controls.Add(txtName);
            input.Controls.Add(lblAge);
            input.Controls.Add(numAge);
            input.Controls.Add(lblGender);
            input.Controls.Add(cboGender);
            input.Controls.Add(lblDiagnosis);
            input.Controls.Add(txtDiagnosis);
            input.Controls.Add(btnSave);

            input.AcceptButton = btnSave;

            if (input.ShowDialog(this) != DialogResult.OK)
                return;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }

            int nextNumber = 1;

            while (patients.Any(p =>
                p.PatientId == "BN" + nextNumber.ToString("D3")))
            {
                nextNumber++;
            }

            patients.Add(new Patient
            {
                PatientId = "BN" + nextNumber.ToString("D3"),
                FullName = txtName.Text.Trim(),
                Age = (int)numAge.Value,
                Gender = cboGender.Text,
                Diagnosis = txtDiagnosis.Text.Trim()
            });

            source.DataSource = patients;
        }

        private void DeletePatient()
        {
            if (dgvPatients.CurrentRow?.DataBoundItem is not Patient patient)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa.");
                return;
            }

            if (MessageBox.Show(
                $"Xóa hồ sơ của {patient.FullName}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            patients.Remove(patient);
            source.DataSource = patients;
        }

        public void ReloadData()
        {
            source.DataSource = patients;
            dgvPatients.Refresh();
        }
    }
}
