using System;
using BaseBusiness.Model;
using BaseBusiness.bc;

namespace BaseBusiness.Examples
{
    /// <summary>
    /// Ví dụ thực tế về cách sử dụng BaseModel
    /// </summary>
    public class BaseModelExamples
    {
        /// <summary>
        /// Ví dụ 1: Sử dụng GetID() và GetStringID()
        /// </summary>
        public static void Example1_GetID()
        {
            // Tạo đối tượng AllotmentTypeModel
            AllotmentTypeModel allotment = new AllotmentTypeModel
            {
                ID = 100,
                Code = "AT001",
                Name = "Loại phân bổ A",
                Description = "Mô tả loại phân bổ"
            };

            // GetID() trả về 0 mặc định vì chưa override
            // Để sử dụng đúng, cần override trong AllotmentTypeModel:
            // public override long GetID() { return this.ID; }
            long id = allotment.GetID(); // Trả về 0
            Console.WriteLine($"ID: {id}");

            // GetStringID() cũng tương tự
            string stringId = allotment.GetStringID(); // Trả về ""
            Console.WriteLine($"String ID: {stringId}");
        }

        /// <summary>
        /// Ví dụ 2: Quản lý User ID
        /// </summary>
        public static void Example2_UserID()
        {
            ARAccountReceivableModel account = new ARAccountReceivableModel
            {
                ID = 1,
                AccountNo = "AR001",
                AccountName = "Khách hàng ABC"
            };

            // Gán user ID cho đối tượng
            account.SetUserID(12345);

            // Lấy user ID
            int userId = account.GetUserID(); // Trả về 12345
            Console.WriteLine($"User ID: {userId}");
        }

        /// <summary>
        /// Ví dụ 3: Clone đối tượng (Deep Copy)
        /// </summary>
        public static void Example3_Clone()
        {
            AllotmentTypeModel original = new AllotmentTypeModel
            {
                ID = 1,
                Code = "AT001",
                Name = "Loại phân bổ gốc",
                Description = "Mô tả gốc",
                CreateDate = DateTime.Now
            };

            // Clone đối tượng
            AllotmentTypeModel cloned = (AllotmentTypeModel)original.Clone();

            // Thay đổi giá trị của bản clone
            cloned.Name = "Loại phân bổ đã clone";
            cloned.Description = "Mô tả đã thay đổi";

            // Kiểm tra: original không bị ảnh hưởng
            Console.WriteLine($"Original Name: {original.Name}"); // "Loại phân bổ gốc"
            Console.WriteLine($"Cloned Name: {cloned.Name}"); // "Loại phân bổ đã clone"
        }

        /// <summary>
        /// Ví dụ 4: Chuyển đổi sang XML
        /// </summary>
        public static void Example4_ToXML()
        {
            ARAccountReceivableModel account = new ARAccountReceivableModel
            {
                ID = 1,
                AccountNo = "AR001",
                AccountName = "Công ty ABC",
                CreditLimit = 1000000,
                CurrencyID = "VND"
            };

            // Chuyển đổi sang XML
            System.Text.StringBuilder xml = account.ToXML();
            Console.WriteLine(xml.ToString());
            // Kết quả:
            // <record id='1'>
            //   <ID>1</ID>
            //   <AccountNo>AR001</AccountNo>
            //   <AccountName>Công ty ABC</AccountName>
            //   <CreditLimit>1000000</CreditLimit>
            //   <CurrencyID>VND</CurrencyID>
            //   ...
            // </record>
        }

        /// <summary>
        /// Ví dụ 5: So sánh đối tượng (CompareTo)
        /// </summary>
        public static void Example5_CompareTo()
        {
            // Tạo đối tượng gốc
            AllotmentTypeModel original = new AllotmentTypeModel
            {
                ID = 1,
                Code = "AT001",
                Name = "Loại phân bổ A",
                Description = "Mô tả ban đầu"
            };

            // Tạo đối tượng đã thay đổi
            AllotmentTypeModel modified = new AllotmentTypeModel
            {
                ID = 1,
                Code = "AT001",
                Name = "Loại phân bổ A - Đã cập nhật",
                Description = "Mô tả mới"
            };

            // So sánh và lấy danh sách thay đổi
            string changes = modified.CompareTo(original);
            Console.WriteLine(changes);
            // Kết quả:
            // - Name: Loại phân bổ A -> Loại phân bổ A - Đã cập nhật<br>
            // - Description: Mô tả ban đầu -> Mô tả mới<br>

            // So sánh với null (trường hợp tạo mới)
            string newRecord = modified.CompareTo(null!); // null! để bỏ qua warning nullable
            Console.WriteLine(newRecord);
            // Kết quả: Liệt kê tất cả giá trị của modified
        }

        /// <summary>
        /// Ví dụ 6: Lấy danh sách Audit Fields
        /// </summary>
        public static void Example6_GetAuditFields()
        {
            ARAccountReceivableModel account = new ARAccountReceivableModel();

            // Lấy danh sách tất cả properties để audit
            string[] auditFields = account.GetAuditFields();

            foreach (string field in auditFields)
            {
                Console.WriteLine($"Audit Field: {field}");
            }
            // Kết quả: ID, AccountNo, AccountTypeID, CreditLimit, ...
        }

        /// <summary>
        /// Ví dụ 7: Quản lý Audit Type
        /// </summary>
        public static void Example7_AuditType()
        {
            AllotmentTypeModel model = new AllotmentTypeModel();

            // Gán loại audit
            // Ví dụ: 1 = Create, 2 = Update, 3 = Delete
            model.SetAuditType(1); // Đánh dấu là thao tác Create

            // Lấy loại audit
            int auditType = model.GetAuditType(); // Trả về 1
            Console.WriteLine($"Audit Type: {auditType}");
        }

        /// <summary>
        /// Ví dụ 8: Quản lý Ordering (Sắp xếp)
        /// </summary>
        public static void Example8_Ordering()
        {
            ARAccountReceivableModel account = new ARAccountReceivableModel
            {
                ID = 1,
                AccountName = "Công ty ABC"
            };

            // Thiết lập field để sắp xếp
            account.SetOrderFieldName("AccountName");

            // Lấy field sắp xếp
            string orderField = account.GetOrderFieldName(); // "AccountName"
            Console.WriteLine($"Order Field: {orderField}");

            // Nếu không set, sẽ dùng GetID()
            AllotmentTypeModel model2 = new AllotmentTypeModel { ID = 5 };
            string defaultOrder = model2.GetOrderFieldName(); // "5" (từ GetID())
            Console.WriteLine($"Default Order: {defaultOrder}");
        }

        /// <summary>
        /// Ví dụ 9: Database Mapping (Table Name và Primary Key)
        /// </summary>
        public static void Example9_DatabaseMapping()
        {
            AllotmentTypeModel allotment = new AllotmentTypeModel();

            // Lấy tên bảng (tự động bỏ "Model" khỏi tên class)
            string tableName = allotment.GetTableName(); // "AllotmentType"
            Console.WriteLine($"Table Name: {tableName}");

            // Lấy tên primary key
            string primaryKey = allotment.GetPrimaryKeyName(); // "ID"
            Console.WriteLine($"Primary Key: {primaryKey}");

            // Ví dụ với PropertyModel (có override)
            PropertyModel property = new PropertyModel();
            string propTable = property.GetTableName(); // "Property" (đã override)
            Console.WriteLine($"Property Table: {propTable}");
        }

        /// <summary>
        /// Ví dụ 10: Kết hợp nhiều tính năng
        /// </summary>
        public static void Example10_CompleteWorkflow()
        {
            // 1. Tạo đối tượng mới
            ARAccountReceivableModel newAccount = new ARAccountReceivableModel
            {
                ID = 0, // Chưa có ID (sẽ được tạo khi insert)
                AccountNo = "AR002",
                AccountName = "Khách hàng mới",
                CreditLimit = 5000000,
                CurrencyID = "VND",
                CreatedDate = DateTime.Now,
                CreatedBy = "admin"
            };

            // 2. Gán user ID
            newAccount.SetUserID(12345);

            // 3. Đánh dấu loại audit (Create)
            newAccount.SetAuditType(1);

            // 4. Clone để tạo bản backup
            ARAccountReceivableModel backup = (ARAccountReceivableModel)newAccount.Clone();

            // 5. Sau khi insert vào DB, cập nhật ID
            newAccount.ID = 100; // Giả sử DB trả về ID = 100

            // 6. So sánh với bản backup để xem thay đổi
            string changes = newAccount.CompareTo(backup);
            Console.WriteLine("Changes after insert:");
            Console.WriteLine(changes);

            // 7. Chuyển sang XML để lưu log
            System.Text.StringBuilder xml = newAccount.ToXML();
            Console.WriteLine("\nXML Representation:");
            Console.WriteLine(xml.ToString());

            // 8. Lấy thông tin database mapping
            Console.WriteLine($"\nTable: {newAccount.GetTableName()}");
            Console.WriteLine($"Primary Key: {newAccount.GetPrimaryKeyName()}");
        }
    }
}

