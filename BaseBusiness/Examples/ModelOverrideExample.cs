using System;
using BaseBusiness.bc;

namespace BaseBusiness.Examples
{
    /// <summary>
    /// Ví dụ về cách override các phương thức virtual của BaseModel
    /// </summary>
    public class CustomModelExample : BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Override GetID() để trả về ID thực tế
        public override long GetID()
        {
            return this.ID;
        }

        // Override GetStringID() nếu cần ID dạng string
        public override string GetStringID()
        {
            return this.ID.ToString();
        }

        // Override GetTableName() nếu tên bảng khác với quy tắc mặc định
        public override string GetTableName()
        {
            return "CustomTable"; // Thay vì "CustomModel"
        }

        // Override GetPrimaryKeyName() nếu primary key không phải "ID"
        public override string GetPrimaryKeyName()
        {
            return "CustomID"; // Nếu bảng dùng CustomID làm primary key
        }

        // Override GetAuditFields() để chỉ audit một số field nhất định
        public override string[] GetAuditFields()
        {
            // Chỉ audit các field quan trọng, bỏ qua Description
            return new string[] { "ID", "Code", "Name" };
        }

        // Override GetOrderBy() để định nghĩa cách sắp xếp mặc định
        public override string GetOrderBy()
        {
            return "Code ASC, Name ASC";
        }

        // Override ToString() để hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"{Code} - {Name}";
        }

        // Override GetAuditType() nếu cần logic đặc biệt
        public override int GetAuditType()
        {
            // Ví dụ: Nếu Inactive = true thì audit type = 99 (deleted)
            // return this.Inactive ? 99 : base.GetAuditType();
            return base.GetAuditType();
        }
    }

    /// <summary>
    /// Ví dụ sử dụng CustomModelExample
    /// </summary>
    public class CustomModelUsageExample
    {
        public static void RunExample()
        {
            CustomModelExample model = new CustomModelExample
            {
                ID = 100,
                Code = "C001",
                Name = "Custom Item",
                Description = "Mô tả"
            };

            // Sử dụng các phương thức đã override
            long id = model.GetID(); // Trả về 100 (không phải 0)
            string stringId = model.GetStringID(); // Trả về "100"
            string tableName = model.GetTableName(); // "CustomTable"
            string primaryKey = model.GetPrimaryKeyName(); // "CustomID"
            string[] auditFields = model.GetAuditFields(); // Chỉ có ID, Code, Name
            string orderBy = model.GetOrderBy(); // "Code ASC, Name ASC"
            string display = model.ToString(); // "C001 - Custom Item"

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"String ID: {stringId}");
            Console.WriteLine($"Table: {tableName}");
            Console.WriteLine($"Primary Key: {primaryKey}");
            Console.WriteLine($"Display: {display}");
        }
    }
}

