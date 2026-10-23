
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            menuPatients.Click += (s, e) =>
                OpenChild<FormPatientProfiles>();

            menuDoctors.Click += (s, e) =>
                OpenChild<FormDoctorSchedule>();

            menuDepartments.Click += (s, e) =>
                MessageBox.Show(
                    "Danh mục Khoa/Phòng chưa được triển khai.",
                    "Quản lý bệnh viện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            menuCascade.Click += (s, e) =>
                LayoutMdi(MdiLayout.Cascade);

            menuHorizontal.Click += (s, e) =>
                LayoutMdi(MdiLayout.TileHorizontal);

            menuVertical.Click += (s, e) =>
                LayoutMdi(MdiLayout.TileVertical);

            menuCloseAll.Click += (s, e) => CloseAllChildren();

            menuReload.Click += (s, e) => ReloadData();

            menuLogout.Click += (s, e) => Logout();

            menuExit.Click += (s, e) =>
            {
                if (MessageBox.Show(
                    "Bạn có chắc muốn thoát chương trình?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            };

            MdiChildActivate += (s, e) =>
            {
                if (ActiveMdiChild != null)
                    lblStatus.Text =
                        "Đang mở: " + ActiveMdiChild.Text;
                else
                    lblStatus.Text = "Sẵn sàng";
            };
        }

        private void OpenChild<T>() where T : Form, new()
        {
            foreach (Form child in MdiChildren)
            {
                if (child is T)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;

                    child.Activate();
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void CloseAllChildren()
        {
            foreach (Form child in MdiChildren)
                child.Close();

            lblStatus.Text = "Đã đóng tất cả cửa sổ";
        }

        private void ReloadData()
        {
            progressBar1.Value = 0;
            lblStatus.Text = "Đang nạp dữ liệu...";

            progressBar1.Value = 30;
            Application.DoEvents();

            foreach (Form child in MdiChildren)
            {
                if (child is FormPatientProfiles patientForm)
                    patientForm.ReloadData();

                if (child is FormDoctorSchedule doctorForm)
                    doctorForm.ReloadData();
            }

            progressBar1.Value = 100;
            lblStatus.Text = "Nạp dữ liệu hoàn tất";

            Application.DoEvents();
            progressBar1.Value = 0;
        }

        private void Logout()
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất khỏi hệ thống?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            CloseAllChildren();

            lblDutyDoctor.Text = "Bác sĩ trực: Chưa đăng nhập";
            lblStatus.Text = "Đã đăng xuất";

            MessageBox.Show(
                "Đã đăng xuất. Đây là mô phỏng đăng xuất, chưa có màn hình đăng nhập.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
