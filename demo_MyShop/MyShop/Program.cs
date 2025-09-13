var builder = WebApplication.CreateBuilder(args);
//Uses views 
builder.Services.AddControllersWithViews();
var app = builder.Build();

// For debugging 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Tells the program to use the static files in wwwroot
app.UseStaticFiles();

//Mapps the default controller to / and so on i think
app.MapDefaultControllerRoute();

app.Run();
