namespace bt_17_10_4._11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            grpInput = new GroupBox();
            btnSelectImage = new Button();
            picDevice = new PictureBox();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            nudEstimatedCost = new NumericUpDown();
            lblEstimatedCost = new Label();
            dtpReceivedDate = new DateTimePicker();
            lblReceivedDate = new Label();
            txtErrorDescription = new TextBox();
            lblErrorDescription = new Label();
            cboDeviceType = new ComboBox();
            lblDeviceType = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            txtOrderId = new TextBox();
            lblOrderId = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grpFilter = new GroupBox();
            cboFilterStatus = new ComboBox();
            lblFilterStatus = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvOrders = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblFilteredCount = new ToolStripStatusLabel();
            lblIncompleteCost = new ToolStripStatusLabel();
            epCheck = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDevice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedCost).BeginInit();
            grpActions.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(85, 24);
            mnuFile.Text = "Hệ thống";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.Size = new Size(179, 26);
            mnuExportCsv.Text = "Xuất file CSV";
            mnuExportCsv.Click += mnuExportCsv_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(179, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(btnSelectImage);
            grpInput.Controls.Add(picDevice);
            grpInput.Controls.Add(cboStatus);
            grpInput.Controls.Add(lblStatus);
            grpInput.Controls.Add(nudEstimatedCost);
            grpInput.Controls.Add(lblEstimatedCost);
            grpInput.Controls.Add(dtpReceivedDate);
            grpInput.Controls.Add(lblReceivedDate);
            grpInput.Controls.Add(txtErrorDescription);
            grpInput.Controls.Add(lblErrorDescription);
            grpInput.Controls.Add(cboDeviceType);
            grpInput.Controls.Add(lblDeviceType);
            grpInput.Controls.Add(txtPhoneNumber);
            grpInput.Controls.Add(lblPhoneNumber);
            grpInput.Controls.Add(txtCustomerName);
            grpInput.Controls.Add(lblCustomerName);
            grpInput.Controls.Add(txtOrderId);
            grpInput.Controls.Add(lblOrderId);
            grpInput.Location = new Point(12, 35);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(830, 205);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin đơn đăng ký dịch vụ";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(675, 165);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(140, 30);
            btnSelectImage.TabIndex = 17;
            btnSelectImage.Text = "Chọn Ảnh...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // picDevice
            // 
            picDevice.BorderStyle = BorderStyle.FixedSingle;
            picDevice.Location = new Point(675, 25);
            picDevice.Name = "picDevice";
            picDevice.Size = new Size(140, 135);
            picDevice.TabIndex = 16;
            picDevice.TabStop = false;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(440, 135);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(210, 28);
            cboStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(340, 138);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(78, 20);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Trạng thái:";
            // 
            // nudEstimatedCost
            // 
            nudEstimatedCost.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            nudEstimatedCost.Location = new Point(440, 95);
            nudEstimatedCost.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudEstimatedCost.Name = "nudEstimatedCost";
            nudEstimatedCost.Size = new Size(210, 27);
            nudEstimatedCost.TabIndex = 13;
            // 
            // lblEstimatedCost
            // 
            lblEstimatedCost.AutoSize = true;
            lblEstimatedCost.Location = new Point(340, 98);
            lblEstimatedCost.Name = "lblEstimatedCost";
            lblEstimatedCost.Size = new Size(95, 20);
            lblEstimatedCost.TabIndex = 12;
            lblEstimatedCost.Text = "Chi phí dự kiến:";
            // 
            // dtpReceivedDate
            // 
            dtpReceivedDate.CustomFormat = "dd/MM/yyyy";
            dtpReceivedDate.Format = DateTimePickerFormat.Custom;
            dtpReceivedDate.Location = new Point(440, 55);
            dtpReceivedDate.Name = "dtpReceivedDate";
            dtpReceivedDate.Size = new Size(210, 27);
            dtpReceivedDate.TabIndex = 11;
            // 
            // lblReceivedDate
            // 
            lblReceivedDate.AutoSize = true;
            lblReceivedDate.Location = new Point(340, 58);
            lblReceivedDate.Name = "lblReceivedDate";
            lblReceivedDate.Size = new Size(97, 20);
            lblReceivedDate.TabIndex = 10;
            lblReceivedDate.Text = "Ngày tiếp nhận:";
            // 
            // txtErrorDescription
            // 
            txtErrorDescription.Location = new Point(115, 135);
            txtErrorDescription.Multiline = true;
            txtErrorDescription.Name = "txtErrorDescription";
            txtErrorDescription.Size = new Size(200, 60);
            txtErrorDescription.TabIndex = 9;
            // 
            // lblErrorDescription
            // 
            lblErrorDescription.AutoSize = true;
            lblErrorDescription.Location = new Point(15, 138);
            lblErrorDescription.Name = "lblErrorDescription";
            lblErrorDescription.Size = new Size(76, 20);
            lblErrorDescription.TabIndex = 8;
            lblErrorDescription.Text = "Mô tả lỗi:";
            // 
            // cboDeviceType
            // 
            cboDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeviceType.FormattingEnabled = true;
            cboDeviceType.Location = new Point(440, 20);
            cboDeviceType.Name = "cboDeviceType";
            cboDeviceType.Size = new Size(210, 28);
            cboDeviceType.TabIndex = 7;
            // 
            // lblDeviceType
            // 
            lblDeviceType.AutoSize = true;
            lblDeviceType.Location = new Point(340, 23);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(88, 20);
            lblDeviceType.TabIndex = 6;
            lblDeviceType.Text = "Loại thiết bị:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(115, 95);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(15, 98);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(115, 55);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 27);
            txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(15, 58);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(91, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên khách:";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(115, 20);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(200, 27);
            txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(15, 23);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(62, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Mã đơn:";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(850, 35);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(140, 205);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Thao tác";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(10, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa Đơn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 68);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpFilter
            // 
            grpFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFilter.Controls.Add(cboFilterStatus);
            grpFilter.Controls.Add(lblFilterStatus);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Location = new Point(12, 245);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(830, 60);
            grpFilter.TabIndex = 3;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(540, 21);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(180, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(450, 25);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(78, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(115, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 310);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(978, 250);
            dgvOrders.TabIndex = 4;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblFilteredCount, lblIncompleteCost });
            statusStrip1.Location = new Point(0, 567);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1002, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblFilteredCount
            // 
            lblFilteredCount.Name = "lblFilteredCount";
            lblFilteredCount.Size = new Size(125, 20);
            lblFilteredCount.Text = "Số đơn hiển thị: 0";
            // 
            // lblIncompleteCost
            // 
            lblIncompleteCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIncompleteCost.ForeColor = Color.Blue;
            lblIncompleteCost.Name = "lblIncompleteCost";
            lblIncompleteCost.Size = new Size(270, 20);
            lblIncompleteCost.Text = "Tổng chi phí chưa hoàn tất: 0 VNĐ";
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 593);
            Controls.Add(statusStrip1);
            Controls.Add(dgvOrders);
            Controls.Add(grpFilter);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1020, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Service Tracker - Quản Lý Đơn Đăng Ký Dịch Vụ Sửa Chữa";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDevice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstimatedCost).EndInit();
            grpActions.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuExportCsv;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private GroupBox grpInput;
        private TextBox txtOrderId;
        private Label lblOrderId;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private ComboBox cboDeviceType;
        private Label lblDeviceType;
        private TextBox txtErrorDescription;
        private Label lblErrorDescription;
        private DateTimePicker dtpReceivedDate;
        private Label lblReceivedDate;
        private NumericUpDown nudEstimatedCost;
        private Label lblEstimatedCost;
        private ComboBox cboStatus;
        private Label lblStatus;
        private PictureBox picDevice;
        private Button btnSelectImage;
        private GroupBox grpActions;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpFilter;
        private ComboBox cboFilterStatus;
        private Label lblFilterStatus;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvOrders;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblFilteredCount;
        private ToolStripStatusLabel lblIncompleteCost;
        private ErrorProvider epCheck;
    }
}
