namespace CebotariRazvan_Ionut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllerRoute(name: default, pattern: "{controller=Admitere}/{action=index}/{id?}");

            app.Run();
        }
    }
}
