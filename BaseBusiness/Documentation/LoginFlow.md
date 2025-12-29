# Tài liệu: Luồng xử lý đăng nhập (Login Flow)

## Tổng quan
Hệ thống sử dụng Cookie Authentication và Session để quản lý đăng nhập. Mật khẩu được mã hóa bằng Rijndael (AES) với MD5/SHA1.

---

## 1. Frontend - Giao diện đăng nhập

### File: `WebApp/Views/User/Index.cshtml`

**Chức năng:**
- Form đăng nhập với 2 trường: `LoginName` và `Password`
- Gửi request POST đến `/User/Login` qua AJAX
- Xử lý phản hồi và lưu thông tin vào localStorage

**Code chính:**
```196:251:WebApp/Views/User/Index.cshtml
<script>
    function login() {
        var formData = new FormData();
        formData.append('LoginName', $('#txtLoginName').val());
        formData.append('Password', $('#txtPassword').val());

        $.ajax({
            url: '/User/Login',
            type: 'POST',
            processData: false,
            contentType: false,
            data: formData,
            success: function (data) {
                $('#alert').empty();
                if (data.code == -1) {
                    // Hiển thị lỗi đăng nhập
                    $('#alert').append(`<div class="alert alert-danger" role="alert">
                       ${data.msg}
                    </div>`)
                    $('#txtLoginName').val('');
                    $('#txtPassword').val('');
                } 
                else{
                    // Lưu thông tin vào localStorage
                    localStorage.setItem("PermissionNames", JSON.stringify(data.data));
                    localStorage.setItem("crashierLogin", "NotYet");
                    localStorage.setItem("Loginname", JSON.stringify(data.namelogin));
                    localStorage.setItem("userID", JSON.stringify(data.userID));
                    localStorage.setItem("businessDate", JSON.stringify(data.businessDate));
                    window.location.href = "/Home/Index";
                }
            }
        });
    }
</script>
```

---

## 2. Controller - Xử lý request đăng nhập

### File: `User/Controllers/UserController.cs`

**Chức năng:**
- Nhận request POST từ frontend
- Gọi service để xác thực
- Lưu thông tin vào Session
- Trả về JSON response

**Code chính:**
```40:81:User/Controllers/UserController.cs
[AllowAnonymous]
[HttpPost]
public async Task<IActionResult> Login()
{
    try
    {
        // 1. Lấy thông tin từ form
        string loginName = Request.Form["LoginName"].ToString();
        string password = Request.Form["Password"].ToString();
        
        // 2. Gọi service để xác thực
        var result = _iUserService.Login(loginName,password);
        
        // 3. Lấy thông tin user
        int UserGroupID = result.UserGroupID;
        int UserID = result.ID;
        int CashierNo = result.CashierNo;
        
        // 4. Lấy danh sách quyền (permissions)
        var result2 = _iUserService.PermissionNames(UserGroupID, UserID);
        
        // 5. Lưu vào Session
        HttpContext.Session.SetInt32("UserID", UserID);
        HttpContext.Session.SetString("LoginName", loginName);
        HttpContext.Session.SetInt32("CashierNo", CashierNo);

        // 6. Lấy business date
        var businessDate = PropertyUtils.ConvertToList<BusinessDateModel>(BusinessDateBO.Instance.FindAll());
        
        // 7. Xử lý danh sách quyền
        var resultname = (from d in result2.AsEnumerable()
                      select new
                      {
                          Name = !string.IsNullOrEmpty(d["Name"].ToString()) ? d["Name"] : "",
                      }).ToList();

        // 8. Trả về kết quả
        if (result.ID != 0) {
            return Json(new { 
                code = 0, 
                msg = "Successfully", 
                data = resultname,
                namelogin = loginName,
                userID = UserID,
                businessDate = businessDate[0].BusinessDate.ToString() 
            });
        }
        else
        {
            return Json(new { 
                code = -1, 
                msg = "The username or password is incorrect. Please try again." 
            });
        }
    }
    catch (Exception ex)
    {
        return Json(new { code = 1, msg = ex.Message });
    }
}
```

---

## 3. Service - Logic xác thực

### File: `User/Services/Implements/UserService.cs`

**Chức năng:**
- Mã hóa mật khẩu bằng MD5.Encrypt()
- Tìm user trong database theo LoginName và PasswordHash
- Trả về UsersModel nếu tìm thấy, ngược lại trả về object rỗng

**Code chính:**
```18:32:User/Services/Implements/UserService.cs
public UsersModel Login(string LoginName, string Password)
{
    try
    {
        // 1. Mã hóa mật khẩu
        string PasswordHash = MD5.Encrypt(Password);
        
        // 2. Tìm user trong database
        var list = PropertyUtils.ConvertToList<UsersModel>(UsersBO.Instance.FindAll())
            .Where(x => x.LoginName == LoginName && x.PasswordHash == PasswordHash)
            .ToList();
        
        // 3. Trả về kết quả
        if (list.Count > 0) {
            return list[0];
        }
        return new UsersModel(); // Trả về object rỗng nếu không tìm thấy
    }
    catch (Exception ex) { 
        return new UsersModel();
    }
}
```

**Lấy danh sách quyền:**
```33:43:User/Services/Implements/UserService.cs
public DataTable PermissionNames(int UserGroupID,int UserID)
{
    SqlParameter[] param = new SqlParameter[]
    {
       new SqlParameter("@UserGroupID", UserGroupID),
       new SqlParameter("@UserID", UserID),
    };

    DataTable myTable = DataTableHelper.getTableData("GetPermissionNamesByUserGroup", param);
    return myTable;
}
```

---

## 4. Mã hóa mật khẩu

### File: `BaseBusiness/util/MD5.cs`

**Chức năng:**
- Mã hóa mật khẩu sử dụng Rijndael (AES) với SHA1
- Sử dụng salt và passphrase để tăng tính bảo mật

**Cấu hình:**
```12:17:BaseBusiness/util/MD5.cs
public static string passPhrase = "Pas5pr@se";        // can be any string
public static string saltValue = "s@1tValue";        // can be any string
public static string hashAlgorithm = "SHA1";             // can be "MD5"
public static int passwordIterations = 2;                  // can be any number
public static string initVector = "@CSS@CSS@CSS@CSS"; // must be 16 bytes
public static int keySize = 256;
```

**Phương thức mã hóa:**
```37:72:BaseBusiness/util/MD5.cs
public static string Encrypt(string plainText)
{
    byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
    byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

    PasswordDeriveBytes password = new PasswordDeriveBytes(
        saltValueBytes,
        hashAlgorithm,
        passwordIterations);

    byte[] keyBytes = password.GetBytes(keySize / 8);
    RijndaelManaged symmetricKey = new RijndaelManaged();
    symmetricKey.Mode = CipherMode.CBC;
    
    ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
        keyBytes,
        initVectorBytes);

    MemoryStream memoryStream = new MemoryStream();
    CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                 encryptor,
                                                 CryptoStreamMode.Write);
    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
    cryptoStream.FlushFinalBlock();

    byte[] cipherTextBytes = memoryStream.ToArray();
    memoryStream.Close();
    cryptoStream.Close();
    string cipherText = Convert.ToBase64String(cipherTextBytes);

    return cipherText;
}
```

---

## 5. Cấu hình Authentication

### File: `WebApp/Program.cs`

**Cấu hình Cookie Authentication:**
```156:170:WebApp/Program.cs
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(AppConstants.EXPIRE_TIME);
    options.Cookie.IsEssential = true;
    options.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
    options.Cookie.Path = "/";
    options.LoginPath = "/User/Index";  // Đường dẫn trang đăng nhập
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
});
```

**Cấu hình Session:**
```171:176:WebApp/Program.cs
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
```

**Middleware pipeline:**
```203:205:WebApp/Program.cs
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
```

---

## 6. Luồng xử lý tổng thể

```
┌─────────────────┐
│   Frontend      │
│  (Index.cshtml) │
└────────┬────────┘
         │ POST /User/Login
         │ (LoginName, Password)
         ▼
┌─────────────────┐
│ UserController  │
│   Login()       │
└────────┬────────┘
         │
         │ Gọi UserService.Login()
         ▼
┌─────────────────┐
│  UserService    │
│   Login()       │
└────────┬────────┘
         │
         │ 1. MD5.Encrypt(Password)
         │ 2. Tìm user trong DB
         │    (LoginName + PasswordHash)
         ▼
┌─────────────────┐
│   Database      │
│   Users Table   │
└────────┬────────┘
         │
         │ Trả về UsersModel
         ▼
┌─────────────────┐
│ UserController  │
│   (tiếp tục)    │
└────────┬────────┘
         │
         │ 1. Lấy PermissionNames
         │ 2. Lưu vào Session
         │    - UserID
         │    - LoginName
         │    - CashierNo
         │ 3. Lấy BusinessDate
         ▼
┌─────────────────┐
│  JSON Response  │
│  - code: 0/-1   │
│  - data: [...]  │
│  - userID       │
│  - businessDate │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│   Frontend      │
│  (xử lý response)│
│  - Lưu localStorage│
│  - Redirect /Home│
└─────────────────┘
```

---

## 7. Dữ liệu được lưu trữ

### Session (Server-side):
- `UserID` (int)
- `LoginName` (string)
- `CashierNo` (int)

### LocalStorage (Client-side):
- `PermissionNames` (JSON array) - Danh sách quyền
- `Loginname` (string) - Tên đăng nhập
- `userID` (int) - ID người dùng
- `businessDate` (string) - Ngày kinh doanh
- `crashierLogin` (string) - Trạng thái đăng nhập cashier

---

## 8. Xử lý lỗi

### Các mã lỗi:
- **code = 0**: Đăng nhập thành công
- **code = -1**: Tên đăng nhập hoặc mật khẩu không đúng
- **code = 1**: Lỗi exception (hiển thị ex.Message)

### Xử lý lỗi:
- Frontend hiển thị thông báo lỗi trong div `#alert`
- Xóa giá trị trong các ô input
- Không redirect, giữ nguyên trang đăng nhập

---

## 9. Bảo mật

### Điểm mạnh:
- Mật khẩu được mã hóa bằng Rijndael (AES) với salt
- Session timeout: 30 phút
- Cookie HttpOnly: true (chống XSS)
- Cookie SameSite: Lax (chống CSRF một phần)

### Điểm cần cải thiện:
- ⚠️ Sử dụng MD5/SHA1 (nên nâng cấp lên bcrypt/Argon2)
- ⚠️ Salt và passphrase hardcode trong code (nên lưu trong config)
- ⚠️ Không có rate limiting cho đăng nhập
- ⚠️ Không có 2FA (Two-Factor Authentication)

---

## 10. Các file liên quan

1. **Frontend:**
   - `WebApp/Views/User/Index.cshtml` - Giao diện đăng nhập

2. **Controller:**
   - `User/Controllers/UserController.cs` - Xử lý request

3. **Service:**
   - `User/Services/Interfaces/IUserService.cs` - Interface
   - `User/Services/Implements/UserService.cs` - Implementation

4. **Model:**
   - `BaseBusiness/Model/UsersModel.cs` - Model người dùng

5. **Utility:**
   - `BaseBusiness/util/MD5.cs` - Mã hóa mật khẩu
   - `BaseBusiness/util/DataTableHelper.cs` - Helper database

6. **Configuration:**
   - `WebApp/Program.cs` - Cấu hình authentication

---

## 11. Ví dụ sử dụng

### Test đăng nhập:
```javascript
// Gửi request đăng nhập
$.ajax({
    url: '/User/Login',
    type: 'POST',
    data: {
        LoginName: 'admin',
        Password: 'password123'
    },
    success: function(data) {
        if (data.code == 0) {
            console.log('Đăng nhập thành công!');
            console.log('User ID:', data.userID);
            console.log('Permissions:', data.data);
        }
    }
});
```

### Kiểm tra Session trong Controller:
```csharp
int? userId = HttpContext.Session.GetInt32("UserID");
string loginName = HttpContext.Session.GetString("LoginName");

if (userId == null)
{
    // Chưa đăng nhập, redirect về trang login
    return RedirectToAction("Index", "User");
}
```

---

## Kết luận

Hệ thống đăng nhập sử dụng kiến trúc 3 lớp (Controller-Service-Data) với Cookie Authentication. Mật khẩu được mã hóa trước khi lưu và so sánh trong database. Thông tin user được lưu trong Session và LocalStorage để sử dụng trong các request tiếp theo.








