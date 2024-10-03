using ITDepartment_BusinessLogic;
using ITDepartment_BusinessLogic.Services;
using ITDepartment_DataAccess.Context;
using ITDepartment_DataAccess.models;
using ITDepartment_DataAccess.repositories;
using Microsoft.EntityFrameworkCore;


namespace ItDepartment_presentationlayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Register the DbContext with connection string
            builder.Services.AddDbContext<ITDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); // Optional for read-only scenarios
            });

            // Register Repositories and Unit of Work
            builder.Services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            builder.Services.AddScoped<IBaseRepository<ITDepartment_DataAccess.models.Device>, BaseRepository<ITDepartment_DataAccess.models.Device>>();
            builder.Services.AddScoped<IBaseRepository<Property>, BaseRepository<Property>>();
            builder.Services.AddScoped<IBaseRepository<PropertyValue>, BaseRepository<PropertyValue>>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
            // Register services
            builder.Services.AddScoped<IDeviceService,DeviceService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
