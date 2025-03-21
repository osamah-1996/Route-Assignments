namespace mvclect02
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.MapGet("/", () => "Hello World");
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}"// ID is optional with constrain
                                                                       //pattern: "{controller=Movies}/{action=Index}/{id:regex(^\\d{{2}}$)?}"
                                                                       //pattern: "{controller=Movies}/{action=Index}" // if the id not in most of the controller
                                                                       // we do not need to route it we can add in the action paramters
                                                                       // ID is optional with constrain
                                                                       //constraints :  new {id = new IntRouteConstraint()} // adding constrain to input 
                                                                       //constraints: new {id = @"\d{2}"} // using pattern matching
                ) // Routing (Mixed Routing)
                .WithStaticAssets();

            app.Run();
        }


    }
}
