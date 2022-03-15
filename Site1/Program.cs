using MongoDB.Driver;

namespace Site1
{
    public static class Program
    {
        public static IMongoDatabase DB;

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            /****************************/
            var dbConfigSection = app.Configuration.GetSection("DBConfig");
            var dbConfig = new DBConf(dbConfigSection);
            var mongoClient = new MongoClient(dbConfig.ConnectionString);
            DB = mongoClient.GetDatabase(dbConfig.DBName);
            /****************************/


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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

    }
}