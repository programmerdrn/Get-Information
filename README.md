📋 Get Information - C# User Input & Data Collection
یک برنامه کنسول C# برای دریافت و مدیریت اطلاعات کاربران - مناسب برای تمرین مفاهیم پایه برنامه‌نویسی

https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/Console%2520App-Terminal%2520Based-black?style=for-the-badge
https://img.shields.io/badge/GitHub-Open%2520Source-181717?style=for-the-badge&logo=github

https://img.shields.io/github/stars/programmerdrn/Get-Information
https://img.shields.io/github/forks/programmerdrn/Get-Information
https://img.shields.io/github/issues/programmerdrn/Get-Information
https://img.shields.io/badge/License-MIT-green?style=for-the-badge



✨ ویژگی‌ها
✅ دریافت اطلاعات کاربر: نام، سن، ایمیل، شماره تلفن

✅ اعتبارسنجی داده‌ها: بررسی صحت اطلاعات ورودی

✅ مدیریت خطاها: هندل کردن خطاهای ورودی

✅ فرمت‌دهی خروجی: نمایش زیبا و منظم اطلاعات

✅ کدهای آموزشی: مناسب برای یادگیری مفاهیم پایه

🏗️ ساختار پروژه
text
Get-Information/
├── Program.cs                 # فایل اصلی برنامه
├── Models/                    # کلاس‌های مدل داده
│   └── UserInfo.cs           # مدل اطلاعات کاربر
├── Services/                  # سرویس‌های برنامه
│   ├── InputService.cs       # سرویس دریافت ورودی
│   └── ValidationService.cs  # سرویس اعتبارسنجی
├── Utilities/                 # ابزارهای کمکی
│   └── ConsoleHelper.cs      # helper functions
└── README.md
🚀 نحوه اجرا
پیش‌نیازها
.NET 6.0 یا بالاتر

اجرای پروژه
bash
# کلون کردن ریپوزیتوری
git clone https://github.com/programmerdrn/Get-Information.git
cd Get-Information

# اجرای پروژه
dotnet run
📝 نحوه استفاده
اجرای برنامه
csharp
// برنامه به صورت تعاملی اجرا می‌شود
// و اطلاعات زیر را دریافت می‌کند:
نمونه خروجی برنامه
text
🎯 برنامه دریافت اطلاعات کاربر

لطفا نام خود را وارد کنید: محمد
لطفا سن خود را وارد کنید: 25
لطفا ایمیل خود را وارد کنید: mohammad@example.com
لطفا شماره تلفن خود را وارد کنید: 09123456789

📊 اطلاعات وارد شده:
├── نام و نام خانوادگی: محمد
├── سن: 25 سال
├── ایمیل: mohammad@example.com
└── شماره تلفن: 09123456789

✅ اطلاعات با موفقیت ذخیره شد!
💡 کدهای نمونه
دریافت اطلاعات از کاربر
csharp
string name = GetInput("لطفا نام خود را وارد کنید");
int age = GetValidatedAge("لطفا سن خود را وارد کنید");
string email = GetValidatedEmail("لطفا ایمیل خود را وارد کنید");
string phone = GetValidatedPhone("لطفا شماره تلفن خود را وارد کنید");
اعتبارسنجی داده‌ها
csharp
public static bool IsValidEmail(string email)
{
    try
    {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == email;
    }
    catch
    {
        return false;
    }
}

public static bool IsValidPhone(string phone)
{
    return !string.IsNullOrEmpty(phone) && phone.Length >= 10;
}
نمایش اطلاعات
csharp
public static void DisplayUserInfo(string name, int age, string email, string phone)
{
    Console.WriteLine("\n📊 اطلاعات وارد شده:");
    Console.WriteLine($"├── نام و نام خانوادگی: {name}");
    Console.WriteLine($"├── سن: {age} سال");
    Console.WriteLine($"├── ایمیل: {email}");
    Console.WriteLine($"└── شماره تلفن: {phone}");
}
🎯 قابلیت‌های برنامه
✅ اعتبارسنجی سن
بررسی عدد بودن ورودی

بررسی محدوده منطقی (مثلاً 1 تا 120)

✅ اعتبارسنجی ایمیل
بررسی فرمت صحیح ایمیل

بررسی وجود @ و دامنه

✅ اعتبارسنجی شماره تلفن
بررسی طول شماره

بررسی عدد بودن

✅ مدیریت خطا
هندل کردن Exceptionها

پیام‌های خطای واضح

🔧 توسعه و customization
می‌توانید این پروژه را توسعه دهید:

اضافه کردن فیلدهای جدید
csharp
// اضافه کردن آدرس
string address = GetInput("لطفا آدرس خود را وارد کنید");

// اضافه کردن جنسیت
string gender = GetGenderInput("لطفا جنسیت خود را وارد کنید (مرد/زن)");
ذخیره‌سازی در فایل
csharp
// ذخیره اطلاعات در فایل JSON
var userData = new { Name = name, Age = age, Email = email };
string json = JsonSerializer.Serialize(userData);
File.WriteAllText("userdata.json", json);
🧪 تست برنامه
bash
# اجرای برنامه
dotnet run

# ساخت release
dotnet build -c Release
🎓 اهداف آموزشی
این پروژه برای یادگیری این مفاهیم مناسب است:

✅ دریافت ورودی از کاربر

✅ اعتبارسنجی داده‌ها

✅ مدیریت خطاها

✅ کار با رشته‌ها

✅ برنامه‌نویسی ساخت یافته

🤝 مشارکت در توسعه
ریپو را Fork کنید

Branch جدید ایجاد کنید (git checkout -b feature/enhancement)

تغییرات را Commit کنید (git commit -m 'Add new feature')

Branch را Push کنید (git push origin feature/enhancement)

Pull Request ایجاد کنید

📄 لایسنس
این پروژه تحت لایسنس MIT منتشر شده است.

👨‍💻 توسعه‌دهنده
[programmerdrn - GitHub Profile
](https://github.com/programmerdrn)
⭐ اگر این پروژه برایتان مفید بود، حتما به آن Star بدهید!

💬 پشتیبانی
📧 ایجاد Issue در گیتهاب برای گزارش باگ یا پیشنهاد

🔄 پیشنهاد قابلیت‌های جدید

برچسب‌ها: csharp dotnet console-app user-input validation educational beginner-friendly
