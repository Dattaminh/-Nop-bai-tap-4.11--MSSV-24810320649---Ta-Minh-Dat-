using System;

namespace bt_17_10_4._11
{
    public class RepairOrder
    {
        public string OrderId { get; set; }          // Mã đơn
        public string CustomerName { get; set; }     // Tên khách hàng
        public string PhoneNumber { get; set; }      // Số điện thoại
        public string DeviceType { get; set; }       // Loại thiết bị
        public string ErrorDescription { get; set; } // Mô tả lỗi
        public DateTime ReceivedDate { get; set; }   // Ngày tiếp nhận
        public decimal EstimatedCost { get; set; }   // Chi phí dự kiến
        public string Status { get; set; }          // Trạng thái đơn
        public string ImagePath { get; set; }       // Đường dẫn ảnh thiết bị

        public RepairOrder() { }

        public RepairOrder(string orderId, string customerName, string phoneNumber,
                            string deviceType, string errorDescription, DateTime receivedDate,
                            decimal estimatedCost, string status, string imagePath = "")
        {
            OrderId = orderId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            DeviceType = deviceType;
            ErrorDescription = errorDescription;
            ReceivedDate = receivedDate.Date;
            EstimatedCost = estimatedCost;
            Status = status;
            ImagePath = imagePath;
        }
    }
}