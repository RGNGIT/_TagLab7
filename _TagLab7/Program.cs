var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseStaticFiles();

string Credentials = "Data Source=DESKTOP-JHJ14RM; Initial Catalog = rent; User ID = rgn; Password = 12345678";

app.Map("/addAddr", appBuilder =>
{

    appBuilder.Use(async (context, next) =>
    {
        string City = context.Request.Query["City"].ToString();
        string Street = context.Request.Query["Street"].ToString();
        string Number = context.Request.Query["Number"].ToString();
        Console.WriteLine(Credentials);
        Database dbInstanse = new Database(Credentials);
        dbInstanse.AddAddress(City, Street, Number);
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
