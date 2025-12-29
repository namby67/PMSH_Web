using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseBusiness.util
{
    public static class ValidationUtils
    {
        public class ValidationError
        {
            public string Field { get; set; }
            public string Message { get; set; }
        }

        // 1. Check điều kiện tùy chỉnh (GỐC)
        public static ValidationError? Check(bool isInvalid, string fieldName, string message)
        {
            if (isInvalid) return new ValidationError { Field = fieldName, Message = message };
            return null;
        }

        // 2. Check String (Rỗng, null hoặc chỉ chứa khoảng trắng)
        public static ValidationError? Check(string value, string fieldName, string message)
        {
            return Check(string.IsNullOrWhiteSpace(value), fieldName, message);
        }

        // 3. Check Int (Dùng cho ID, Số lượng bắt buộc) -> Chặn <= 0
        public static ValidationError? Check(int value, string fieldName, string message)
        {
            return Check(value <= 0, fieldName, message);
        }

        // 3.1. [MỚI] Check Nullable Int (int?)
        // Logic: Nếu Null thì lỗi HOẶC Nếu có giá trị mà <= 0 cũng lỗi
        public static ValidationError? Check(int? value, string fieldName, string message)
        {
            return Check(!value.HasValue || value.Value <= 0, fieldName, message);
        }

        // 4. Check Object (Null)
        public static ValidationError? Check(object value, string fieldName, string message)
        {
            return Check(value == null, fieldName, message);
        }

        // 5. Check Decimal (Giá tiền) -> Chặn <= 0
        public static ValidationError? Check(decimal value, string fieldName, string message)
        {
            return Check(value <= 0, fieldName, message);
        }

        // 5.1. Check Nullable Decimal (decimal?)
        public static ValidationError? Check(decimal? value, string fieldName, string message)
        {
            return Check(!value.HasValue || value.Value <= 0, fieldName, message);
        }

        // 6. [MỚI] Check DateTime (Ngày tháng)
        // Lỗi khi: Chưa chọn ngày (năm 0001) hoặc Null
        public static ValidationError? Check(DateTime value, string fieldName, string message)
        {
            return Check(value == default(DateTime), fieldName, message); // default là 01/01/0001
        }

        public static ValidationError? Check(DateTime? value, string fieldName, string message)
        {
            return Check(!value.HasValue || value.Value == default(DateTime), fieldName, message);
        }

        // 7. [MỚI] Check List/Array (Danh sách)
        // Lỗi khi: Null hoặc Rỗng (Count = 0)
        // <T> giúp hàm nhận bất kỳ List kiểu nào (List<User>, List<int>...)
        public static ValidationError? Check<T>(IEnumerable<T> list, string fieldName, string message)
        {
            return Check(list == null || !list.Any(), fieldName, message);
        }

        // --- HÀM GOM LỖI ---
        public static List<ValidationError> GetErrors(params ValidationError?[] checks)
        {
            return checks.Where(x => x != null).ToList()!;
        }
    }
}