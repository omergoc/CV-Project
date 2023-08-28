using Business.Absttract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace WebUI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<CvDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<IPersonService, PersonService>();
        builder.Services.AddScoped<IBlogService, BlogService>();
        builder.Services.AddScoped<IProjectService, ProjectService>();
        builder.Services.AddScoped<ISkillService, SkillService>();
        builder.Services.AddScoped<IExperienceService, ExperienceService>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
