
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace HospitalMDI
{
    public partial class FormDoctorSchedule : Form
    {
        private class DoctorShift
        {
            public string DoctorId { get; set; } = "";
            public string DoctorName { get; set; } = "";
            public string Department { get; set; } = "";
            public string Shift { get; set; } = "";
            public DateTime Date { get; set; }
        }

        private readonly BindingList<DoctorShift> schedules = new();
        private readonly BindingSource source = new();

        public FormDoctorSchedule()
        {
            InitializeComponent();

            schedules.Add(new DoctorShift
            {
                DoctorId = "BS001",
                DoctorName = "Nguyễn Văn An",
                Department = "Khoa Nội",
                Shift = "07:00 - 15:00",
                Date = DateTime.Today
            });

            schedules.Add(new DoctorShift
            {
                DoctorId = "BS002",
                DoctorName = "Trần Thị Bình",
                Department = "Khoa Ngoại",
                Shift = "15:00 - 23:00",
                Date = DateTime.Today
            });

            schedules.Add(new DoctorShift
            {
                DoctorId = "BS003",
                DoctorName = "Lê Văn Cường",
                Department = "Cấp cứu",
                Shift = "23:00 - 07:00",
                Date = DateTime.Today
            });

            dgvSchedule.AutoGenerateColumns = false;
            dgvSchedule.Columns.Clear();

            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã bác sĩ",
                DataPropertyName = nameof(DoctorShift.DoctorId)
            });

            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên bác sĩ",
                DataPropertyName = nameof(DoctorShift.DoctorName)
            });

            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Khoa",
                DataPropertyName = nameof(DoctorShift.Department)
            });

            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ca trực",
                DataPropertyName = nameof(DoctorShift.Shift)
            });

            dgvSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày trực",
                DataPropertyName = nameof(DoctorShift.Date),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy"
                }
            });

            source.DataSource = schedules;
            dgvSchedule.DataSource = source;

            btnToday.Click += (s, e) =>
            {
                dtpDate.Value = DateTime.Today;
                FilterSchedule();
            };

            dtpDate.ValueChanged += (s, e) => FilterSchedule();

            FilterSchedule();
        }

        private void FilterSchedule()
        {
            DateTime selectedDate = dtpDate.Value.Date;

            var result = schedules
                .Where(s => s.Date.Date == selectedDate)
                .ToList();

            source.DataSource = result;
        }

        public void ReloadData()
        {
            FilterSchedule();
            dgvSchedule.Refresh();
        }
    }
}
