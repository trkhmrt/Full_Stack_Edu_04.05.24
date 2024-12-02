
using System.Security.Policy;

var builder = WebApplication.CreateBuilder(args);

//Servislerin tan�mland��� yer buras�


builder.Services.AddBusinessServices();//Servie Injections
builder.Services.AddAutoMapper(); //AutoMapper Injections

builder.Services.AddControllersWithViews();//Uygulamada Controller ve View yap�sn�n kullanabilmek i�in bu servisi ekliyoruz 

//appsetings.json 'dan Connection bilgilerini al ve Data katman�ndaki Constructor'a aktar
//builder.Services.AddDbContext<SolidTechContext>(options =>
//{
//    options.UseSqlServer("Server=.;Database=SolidTechDb;Trusted_Connection=True;Encrypt=False");
//});

builder.Services.AddDbContext<SolidTechContext>();

var app = builder.Build();

app.UseStaticFiles();//Uygulamada "wwwroot" klas�r� alt�nda static dosyalar� kullanabilmek i�in ekliyoruz(css,js,images)


app.UseRouting();


app.MapControllerRoute(name: "admin_default",
                       pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");





app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");










app.Run();
