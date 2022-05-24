var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseStaticFiles();

string Credentials = "Data Source=DESKTOP-PBKFIIP; Initial Catalog = TagBD; User ID = localhost; Password = ";

app.Map("/addAddr", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {
        string Name = context.Request.Query["Name"].ToString();
        string Description = context.Request.Query["Description"].ToString();
        string Category = context.Request.Query["Category"].ToString();
        int Price = Convert.ToInt32(context.Request.Query["Price"]);
        Console.WriteLine(Credentials);
        Database dbInstanse = new Database(Credentials);
        dbInstanse.AddAddress(Name, Description, Category, Price);
        await next(); 
    });

    appBuilder.Run(async context => await context.Response.WriteAsync("Done"));
});

app.Map("/addStatus", appBuilder =>
{
    
    appBuilder.Use(async (context, next) =>
    {

        await next();
    });

    appBuilder.Run(async context => await context.Response.WriteAsync("Done"));
});

app.Map("/addJur", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next(); 
    });

    appBuilder.Run(async context => await context.Response.WriteAsync(""));
});

app.Map("/addPhys", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {

        await next();   
    });

    appBuilder.Run(async context => await context.Response.WriteAsync(""));
});

app.Run();
