
namespace HospitalMDI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private MenuStrip menuStrip1 = null!;
        private ToolStripMenuItem menuSystem = null!;
        private ToolStripMenuItem menuLogout = null!;
        private ToolStripMenuItem menuReload = null!;
        private ToolStripMenuItem menuExit = null!;

        private ToolStripMenuItem menuManage = null!;
        private ToolStripMenuItem menuPatients = null!;
        private ToolStripMenuItem menuDoctors = null!;
        private ToolStripMenuItem menuDepartments = null!;

        private ToolStripMenuItem menuWindow = null!;
        private ToolStripMenuItem menuCascade = null!;
        private ToolStripMenuItem menuHorizontal = null!;
        private ToolStripMenuItem menuVertical = null!;
        private ToolStripMenuItem menuCloseAll = null!;

        private StatusStrip statusStrip1 = null!;
        private ToolStripStatusLabel lblDutyDoctor = null!;
        private ToolStripProgressBar progressBar1 = null!;
        private ToolStripStatusLabel lblStatus = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();

            menuSystem = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuReload = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();

            menuManage = new ToolStripMenuItem();
            menuPatients = new ToolStripMenuItem();
            menuDoctors = new ToolStripMenuItem();
            menuDepartments = new ToolStripMenuItem();

            menuWindow = new ToolStripMenuItem();
            menuCascade = new ToolStripMenuItem();
            menuHorizontal = new ToolStripMenuItem();
            menuVertical = new ToolStripMenuItem();
            menuCloseAll = new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();
            lblDutyDoctor = new ToolStripStatusLabel();
            progressBar1 = new ToolStripProgressBar();
            lblStatus = new ToolStripStatusLabel();

            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // Menu Hệ thống

            menuSystem.Text = "Hệ thống";

            menuLogout.Text = "Đăng xuất";
            menuReload.Text = "Nạp lại dữ liệu";
            menuExit.Text = "Thoát";

            menuSystem.DropDownItems.AddRange(new ToolStripItem[]
            {
                menuLogout,
                menuReload,
                new ToolStripSeparator(),
                menuExit
            });

            // Menu Quản lý

            menuManage.Text = "Quản lý";

            menuPatients.Text = "Hồ sơ Bệnh nhân";
            menuDoctors.Text = "Danh mục Bác sĩ";
            menuDepartments.Text = "Danh mục Khoa/Phòng";

            menuManage.DropDownItems.AddRange(new ToolStripItem[]
            {
                menuPatients,
                menuDoctors,
                menuDepartments
            });

            // Menu Cửa sổ

            menuWindow.Text = "Cửa sổ";

            menuCascade.Text = "Sắp xếp xếp tầng";
            menuHorizontal.Text = "Sắp xếp ngang";
            menuVertical.Text = "Sắp xếp dọc";
            menuCloseAll.Text = "Đóng tất cả";

            menuWindow.DropDownItems.AddRange(new ToolStripItem[]
            {
                menuCascade,
                menuHorizontal,
                menuVertical,
                new ToolStripSeparator(),
                menuCloseAll
            });

            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                menuSystem,
                menuManage,
                menuWindow
            });

            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Name = "menuStrip1";

            // StatusStrip

            lblDutyDoctor.Text = "Bác sĩ trực: Nguyễn Văn An";
            lblDutyDoctor.BorderSides =
                ToolStripStatusLabelBorderSides.Right;

            progressBar1.Name = "progressBar1";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Size = new Size(150, 16);

            lblStatus.Text = "Sẵn sàng";
            lblStatus.Spring = true;
            lblStatus.TextAlign = ContentAlignment.MiddleRight;

            statusStrip1.Items.AddRange(new ToolStripItem[]
            {
                lblDutyDoctor,
                progressBar1,
                lblStatus
            });

            statusStrip1.Dock = DockStyle.Bottom;
            statusStrip1.Name = "statusStrip1";

            // Form1

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ BỆNH VIỆN - MDI";

            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
