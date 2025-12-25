using Administration.Controllers;
using Administration.Services;
using Administration.Services.Implements;
using Administration.Services.Interfaces;
using Billing.Controllers;
using Billing.Services.Implements;
using Billing.Services.Interfaces;
using Cashiering.Controllers;
using Cashiering.Services.Implements;
using Cashiering.Services.Interfaces;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using FrontDesk.Controllers;
using FrontDesk.Services.Implements;
using FrontDesk.Services.Interfaces;
using HouseKeeping.Controllers;
using HouseKeeping.Services.Implements;
using HouseKeeping.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.FileProviders;
using Miscellaneous.Controllers;
using Miscellaneous.Hubs;
using Miscellaneous.Services.Implements;
using Miscellaneous.Services.Interfaces;
using NightAudit.Controllers;
using NightAudit.Services.Implements;
using NightAudit.Services.Interfaces;
using Profile.Controllers;
using Profile.Services.Implements;
using Profile.Services.Interfaces;
using Report.Controllers;
using Report.Services.Implements;
using Report.Services.Interfaces;
using Reservation.Controllers;
using Reservation.Services.Implements;
using Reservation.Services.Interfaces;
using RoomManagement.Controllers;
using RoomManagement.Services.Implements;
using RoomManagement.Services.Interfaces;
using User.Controllers;
using User.Services.Implements;
using User.Services.Interfaces;

using WebApp.Commons.Containts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.MimeTypes = new[] { "text/csv" }; // L?y t? appsettings.json n?u c?n
});

builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(HouseKeepingController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ProfileController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ReportController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(UserController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ReservationController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(FrontDeskController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(CashieringController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(BillingController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(NightAuditController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(RoomManagementController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(MiscellaneousController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(AdministrationController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(EmailController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(TransactionGroupController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(TransactionController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(TransactionSubGroupController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ArticleController).Assembly));
builder.Services.AddControllersWithViews()
    .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(HouseKeepingAdminController).Assembly));
builder.Services.AddHttpClient();
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddDevExpressControls();
builder.Services.AddMvc();
builder.Services.ConfigureReportingServices(configurator =>
{
    configurator.ConfigureWebDocumentViewer(viewerconfigurator =>
    {
        viewerconfigurator.UseCachedReportSourceBuilder();
    });
});
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<IHouseKeepingService, HouseKeepingService>();
builder.Services.AddSingleton<IReportService, ReportService>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IReservationService, ReservationService>();
builder.Services.AddSingleton<IFolioDetailService, FolioDetailService>();
builder.Services.AddSingleton<IDepositService, DepositService>();
builder.Services.AddSingleton<IRoutingService, RoutingService>();
builder.Services.AddSingleton<IFrontDeskService, FrontDeskService>();
builder.Services.AddSingleton<ICashieringService, CashieringService>();
builder.Services.AddSingleton<IPostService, PostService>();
builder.Services.AddSingleton<ICrashierService, CrashierService>();
builder.Services.AddSingleton<IInvoicingService, InvoicingService>();
builder.Services.AddSingleton<ITransferTransactionService, TransferTransactionService>();
builder.Services.AddSingleton<IRoomManagementService, RoomManagementService>();
builder.Services.AddSingleton<IRoomRateService, RoomRateService>();
builder.Services.AddSingleton<IMiscellaneousService, MiscellaneousService>();
builder.Services.AddSingleton<IAdministrationService, AdministrationService>();
builder.Services.AddSingleton<IAdjustTransactionService, AdjustTransactionService>();
builder.Services.AddSingleton<ICloseShiftService, CloseShiftService>();
builder.Services.AddSingleton<ICashieringManagerService, CashieringManagerService>();
builder.Services.AddSingleton<IVATSearchService, VATSearchService>();
builder.Services.AddSingleton<IFolioVATSearchService, FolioVATSearchService>();
builder.Services.AddSingleton<IAccountingService, AccountingService>();
builder.Services.AddSingleton<IEmailService, EmailService>();
builder.Services.AddSingleton<ITransactionGroupService, TransactionGroupService>();
builder.Services.AddSingleton<ITransactionService, TransactionService>();
builder.Services.AddSingleton<IProfileExportService, ProfileExportService>();
builder.Services.AddSingleton<IMembershipService, MembershipService>();
builder.Services.AddSingleton<IHouseKeepingAdminService, HouseKeepingAdminService>();
builder.Services.AddSingleton<ITransactionSubGroupService, TransactionSubGroupService>();
builder.Services.AddSingleton<IArticleService, ArticleService>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddSingleton<IGroupReservationService, GroupReservationService>();
builder.Services.AddSingleton<IMessageService, MessageService>();
builder.Services.AddSingleton<IShareService, ShareService>();
builder.Services.AddSingleton<IGroupAdminService, GroupAdminService>();

//Tuan
builder.Services.AddSingleton<IRateClassService, RateClassService>();
builder.Services.AddSingleton<IRateCategoryService, RateCategory>();
builder.Services.AddSingleton<IRateCodeService, RateCodeService>();
builder.Services.AddSingleton<IRateCodeDetailService, RateCodeDetailService>();
builder.Services.AddSingleton<IRateCodeUserRightService, RateCodeUserRightService>();
builder.Services.AddSingleton<IPackageDetailService, PackageDetailService>();
builder.Services.AddSingleton<IPackageService, PackageService>();
builder.Services.AddSingleton<ITransactionArticleLinkService, TransactionArticleLinkService>();

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
    options.LoginPath = "/User/Index";
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddLogging();
builder.Services.AddMemoryCache();

var app = builder.Build();

app.UseDevExpressControls();
System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

var env = builder.Environment;
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "node_modules")),
    RequestPath = "/node_modules",
});

app.MapHub<TagScanHub>("/tagScanHub");
app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseResponseCompression(); // ??t sau UseStaticFiles và tr??c UseRouting
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
