namespace Complaintform
{
    public class UI
    {
        public void Run()
        {
            var builder = WebApplication.CreateBuilder();


           
            Console.WriteLine("test"); //to see if repo is working like intended

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();

           
        }
        public string Ask(string fred)
        {
            return "hello";
        }
    }
}