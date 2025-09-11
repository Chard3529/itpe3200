var builder = WebApplication.CreateBuilder(args);
//Uses views 
builder.Services.AddControllersWithViews();
var app = builder.Build();

// For debugging 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//Mapps the default controller to / and so on i think
app.MapDefaultControllerRoute();

app.Run();
