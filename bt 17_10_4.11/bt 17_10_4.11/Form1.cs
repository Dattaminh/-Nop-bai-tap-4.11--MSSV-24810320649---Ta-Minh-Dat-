using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bt_17_10_4._11
{
    public partial class Form1 : Form
    {
        // Danh sách chính lưu dữ liệu trong bộ nhớ
        private BindingList<RepairOrder> masterList = new BindingList<RepairOrder>();
        // BindingSource trung gian cho DataGridView
        private BindingSource bsOrders = new BindingSource();
        // Đường dẫn ảnh tạm đang chọn
        private string currentImagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoGiaoDienControls();
            KhoiTaoDuLieuMau();

            bsOrders.DataSource = masterList;
            dgvOrders.DataSource = bsOrders;

            ApDungLocVaTimKiem();
            CapNhatStatusStrip();
        }

        // 1. Khởi tạo danh mục ComboBox và Cột DataGridView thủ công
        private void KhoiTaoGiaoDienControls()
        {
            // Danh mục Loại thiết bị
            cboDeviceType.Items.AddRange(new string[] {
                "Điện thoại",
                "Laptop",
                "Máy tính bảng",
                "Máy tính để bàn",
                "Thiết bị khác"
            });
            cboDeviceType.SelectedIndex = 0;

            // Danh mục Trạng thái đơn
            cboStatus.Items.AddRange(new string[] {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboStatus.SelectedIndex = 0;

            // Bộ lọc Trạng thái
            cboFilterStatus.Items.AddRange(new string[] {
                "Tất cả",
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });
            cboFilterStatus.SelectedIndex = 0;

            // Cấu hình DataGridView thủ công
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId", HeaderText = "Mã Đơn", Width = 90 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Khách Hàng", Width = 140 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Số Điện Thoại", Width = 110 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceType", HeaderText = "Loại Thiết Bị", Width = 120 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ErrorDescription", HeaderText = "Mô Tả Lỗi", Width = 180 });

            var colDate = new DataGridViewTextBoxColumn { DataPropertyName = "ReceivedDate", HeaderText = "Ngày Tiếp Nhận", Width = 110 };
            colDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrders.Columns.Add(colDate);

            var colCost = new DataGridViewTextBoxColumn { DataPropertyName = "EstimatedCost", HeaderText = "Chi Phí Dự Kiến (VNĐ)", Width = 140 };
            colCost.DefaultCellStyle.Format = "N0";
            dgvOrders.Columns.Add(colCost);

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 110 });

            // Đặt chế độ hiển thị ảnh không bị méo tỷ lệ
            picDevice.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 2. Nạp dữ liệu mẫu ban đầu
        private void KhoiTaoDuLieuMau()
        {
            masterList.Add(new RepairOrder("HD001", "Nguyễn Văn An", "0905123456", "Điện thoại", "Vỡ màn hình cảm ứng", DateTime.Today.AddDays(-3), 1200000, "Đang sửa"));
            masterList.Add(new RepairOrder("HD002", "Trần Thị Bích", "0914987654", "Laptop", "Không lên nguồn, hỏng IC", DateTime.Today.AddDays(-2), 2500000, "Chờ linh kiện"));
            masterList.Add(new RepairOrder("HD003", "Lê Hoàng Nam", "0988111222", "Máy tính bảng", "Thay pin mới", DateTime.Today.AddDays(-5), 850000, "Hoàn tất"));
        }

        // 3. Hàm kiểm tra dữ liệu hợp lệ (Validation)
        private bool KiemTraHopLe(bool isUpdate = false)
        {
            epCheck.Clear();
            bool isValid = true;

            // Kiểm tra Mã đơn
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                epCheck.SetError(txtOrderId, "Mã đơn không được để trống!");
                isValid = false;
            }
            else if (!isUpdate && masterList.Any(o => o.OrderId.Equals(txtOrderId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epCheck.SetError(txtOrderId, "Mã đơn đã tồn tại trong hệ thống!");
                isValid = false;
            }

            // Kiểm tra Tên khách hàng
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                epCheck.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            // Kiểm tra Số điện thoại
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                epCheck.SetError(txtPhoneNumber, "Số điện thoại không được để trống!");
                isValid = false;
            }

            // Kiểm tra Mô tả lỗi
            if (string.IsNullOrWhiteSpace(txtErrorDescription.Text))
            {
                epCheck.SetError(txtErrorDescription, "Mô tả lỗi bắt buộc phải nhập!");
                isValid = false;
            }

            // Kiểm tra Chi phí dự kiến
            if (nudEstimatedCost.Value < 0)
            {
                epCheck.SetError(nudEstimatedCost, "Chi phí dự kiến phải là số không âm!");
                isValid = false;
            }

            return isValid;
        }

        // 4. Chức năng THÊM đơn mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe(isUpdate: false)) return;

            RepairOrder order = new RepairOrder(
                txtOrderId.Text.Trim(),
                txtCustomerName.Text.Trim(),
                txtPhoneNumber.Text.Trim(),
                cboDeviceType.Text,
                txtErrorDescription.Text.Trim(),
                dtpReceivedDate.Value,
                nudEstimatedCost.Value,
                cboStatus.Text,
                currentImagePath
            );

            masterList.Add(order);
            ApDungLocVaTimKiem();
            CapNhatStatusStrip();
            ClearInputs();
            MessageBox.Show("Thêm đơn đăng ký dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. Chức năng CẬP NHẬT đơn
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                MessageBox.Show("Vui lòng chọn một đơn từ danh sách để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraHopLe(isUpdate: true)) return;

            var target = masterList.FirstOrDefault(o => o.OrderId.Equals(txtOrderId.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (target != null)
            {
                target.CustomerName = txtCustomerName.Text.Trim();
                target.PhoneNumber = txtPhoneNumber.Text.Trim();
                target.DeviceType = cboDeviceType.Text;
                target.ErrorDescription = txtErrorDescription.Text.Trim();
                target.ReceivedDate = dtpReceivedDate.Value.Date;
                target.EstimatedCost = nudEstimatedCost.Value;
                target.Status = cboStatus.Text;
                target.ImagePath = currentImagePath;

                dgvOrders.Refresh();
                ApDungLocVaTimKiem();
                CapNhatStatusStrip();
                ClearInputs();
                MessageBox.Show("Cập nhật thông tin đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 6. Chức năng XÓA đơn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderId = txtOrderId.Text.Trim();
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn sửa chữa [{orderId}] không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                var target = masterList.FirstOrDefault(o => o.OrderId.Equals(orderId, StringComparison.OrdinalIgnoreCase));
                if (target != null)
                {
                    masterList.Remove(target);
                    ApDungLocVaTimKiem();
                    CapNhatStatusStrip();
                    ClearInputs();
                    MessageBox.Show("Đã xóa đơn sửa chữa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 7. Chọn ảnh thiết bị (OpenFileDialog)
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File hình ảnh (*.jpg; *.png; *.bmp)|*.jpg;*.png;*.bmp|Tất cả các file (*.*)|*.*";
                ofd.Title = "Chọn ảnh thiết bị sửa chữa";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    LoadImageToPictureBox(currentImagePath);
                }
            }
        }

        // Đọc và nạp ảnh an toàn tránh khóa file
        private void LoadImageToPictureBox(string path)
        {
            if (picDevice.Image != null)
            {
                picDevice.Image.Dispose();
                picDevice.Image = null;
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picDevice.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    picDevice.Image = null;
                }
            }
            else
            {
                picDevice.Image = null;
            }
        }

        // 8. Đẩy dữ liệu dòng đang chọn trên DataGridView lên Form
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOrders.Rows.Count)
            {
                var item = dgvOrders.Rows[e.RowIndex].DataBoundItem as RepairOrder;
                if (item != null)
                {
                    txtOrderId.Text = item.OrderId;
                    txtCustomerName.Text = item.CustomerName;
                    txtPhoneNumber.Text = item.PhoneNumber;
                    cboDeviceType.Text = item.DeviceType;
                    txtErrorDescription.Text = item.ErrorDescription;
                    dtpReceivedDate.Value = item.ReceivedDate;
                    nudEstimatedCost.Value = item.EstimatedCost;
                    cboStatus.Text = item.Status;
                    currentImagePath = item.ImagePath;

                    LoadImageToPictureBox(currentImagePath);
                    txtOrderId.ReadOnly = true; // Khóa không cho sửa Mã đơn
                }
            }
        }

        // 9. Áp dụng Lọc và Tìm kiếm tức thời
        private void ApDungLocVaTimKiem()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string filterStatus = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = masterList.Where(o =>
            {
                // Tìm theo Mã đơn, Tên khách hàng hoặc Số điện thoại
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                    o.OrderId.ToLower().Contains(keyword) ||
                                    o.CustomerName.ToLower().Contains(keyword) ||
                                    o.PhoneNumber.ToLower().Contains(keyword);

                // Lọc theo Trạng thái
                bool matchStatus = (filterStatus == "Tất cả") || (o.Status == filterStatus);

                return matchKeyword && matchStatus;
            }).ToList();

            bsOrders.DataSource = new BindingList<RepairOrder>(filtered);
            CapNhatStatusStrip();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApDungLocVaTimKiem();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApDungLocVaTimKiem();

        // 10. Cập nhật thông tin trên StatusStrip
        private void CapNhatStatusStrip()
        {
            int countFiltered = bsOrders.Count;
            // Tổng chi phí của các đơn chưa hoàn tất (Trạng thái khác "Hoàn tất" và "Đã hủy")
            decimal totalIncompleteCost = masterList
                .Where(o => o.Status != "Hoàn tất" && o.Status != "Đã hủy")
                .Sum(o => o.EstimatedCost);

            lblFilteredCount.Text = $"Số đơn hiển thị: {countFiltered}";
            lblIncompleteCost.Text = $"Tổng chi phí chưa hoàn tất: {totalIncompleteCost:N0} VNĐ";
        }

        // 11. Xuất danh sách ra file CSV qua MenuStrip
        private void mnuExportCsv_Click(object sender, EventArgs e)
        {
            var currentList = bsOrders.DataSource as IEnumerable<RepairOrder>;
            if (currentList == null || !currentList.Any())
            {
                MessageBox.Show("Không có dữ liệu để xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "File CSV (*.csv)|*.csv";
                sfd.FileName = $"DanhSachDonSuaChua_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Mã Đơn,Tên Khách Hàng,Số Điện Thoại,Loại Thiết Bị,Mô Tả Lỗi,Ngày Tiếp Nhận,Chi Phí Dự Kiến,Trạng Thái,Đường Dẫn Ảnh");

                            foreach (var item in currentList)
                            {
                                string line = $"\"{item.OrderId}\",\"{item.CustomerName}\",\"{item.PhoneNumber}\",\"{item.DeviceType}\",\"{item.ErrorDescription}\",\"{item.ReceivedDate:dd/MM/yyyy}\",{item.EstimatedCost},\"{item.Status}\",\"{item.ImagePath}\"";
                                sw.WriteLine(line);
                            }
                        }
                        MessageBox.Show("Xuất danh sách đơn sửa chữa ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 12. Thoát ứng dụng
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void ClearInputs()
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            if (cboDeviceType.Items.Count > 0) cboDeviceType.SelectedIndex = 0;
            txtErrorDescription.Clear();
            dtpReceivedDate.Value = DateTime.Today;
            nudEstimatedCost.Value = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            currentImagePath = "";
            LoadImageToPictureBox(null);
            txtOrderId.ReadOnly = false;
            epCheck.Clear();
            txtOrderId.Focus();
        }
    }
}
