
namespace HospitalMDI
{
    partial class FormDoctorSchedule
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.TableLayoutPanel tableMain = null!;
        private System.Windows.Forms.Panel panelDate = null!;
        private System.Windows.Forms.Label lblTitle = null!;
        private System.Windows.Forms.Label lblDate = null!;
        private System.Windows.Forms.DateTimePicker dtpDate = null!;
        private System.Windows.Forms.Button btnToday = null!;
        private System.Windows.Forms.DataGridView dgvSchedule = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableMain = new System.Windows.Forms.TableLayoutPanel();
            panelDate = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            btnToday = new System.Windows.Forms.Button();
            dgvSchedule = new System.Windows.Forms.DataGridView();

            tableMain.SuspendLayout();
            panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();

            // FormDoctorSchedule
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 600);
            Name = "FormDoctorSchedule";
            Text = "Lịch trực bác sĩ";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // tableMain
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            tableMain.RowCount = 3;
            tableMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 65F));
            tableMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 60F));
            tableMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableMain.Padding = new System.Windows.Forms.Padding(10);
            tableMain.Name = "tableMain";

            // lblTitle
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Text = "QUẢN LÝ LỊCH TRỰC BÁC SĨ";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Name = "lblTitle";

            // panelDate
            panelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDate.Name = "panelDate";

            // lblDate
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(10, 17);
            lblDate.Name = "lblDate";
            lblDate.Text = "Chọn ngày:";
            lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);

            // dtpDate
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDate.Location = new System.Drawing.Point(105, 13);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(150, 23);

            // btnToday
            btnToday.Location = new System.Drawing.Point(270, 10);
            btnToday.Name = "btnToday";
            btnToday.Size = new System.Drawing.Size(120, 30);
            btnToday.Text = "Hôm nay";
            btnToday.UseVisualStyleBackColor = true;

            panelDate.Controls.Add(lblDate);
            panelDate.Controls.Add(dtpDate);
            panelDate.Controls.Add(btnToday);

            // dgvSchedule
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSchedule.MultiSelect = false;
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Name = "dgvSchedule";

            // Add controls to tableMain
            tableMain.Controls.Add(lblTitle, 0, 0);
            tableMain.Controls.Add(panelDate, 0, 1);
            tableMain.Controls.Add(dgvSchedule, 0, 2);

            // Add tableMain to form
            Controls.Add(tableMain);

            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panelDate.ResumeLayout(false);
            panelDate.PerformLayout();
            tableMain.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
