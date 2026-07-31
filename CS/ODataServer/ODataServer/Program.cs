using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;
using ODataServer.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure URLs
builder.WebHost.UseUrls("http://localhost:5005", "https://localhost:5006");

builder.Services.AddDbContext<NorthwindContext>((sp, options) => {
    var env = sp.GetRequiredService<IWebHostEnvironment>();
    var dbPath = Path.Combine(env.ContentRootPath, "Northwind.db");
    options.UseSqlite("Data Source=" + dbPath);
});

// Build the Edm model
var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<Order>("Orders");

// Configure OData
builder.Services.AddControllers().AddOData(options => options
    .Select()
    .Filter()
    .OrderBy()
    .Expand()
    .Count()
    .SetMaxTop(null)
    .AddRouteComponents("odata", modelBuilder.GetEdmModel())
);

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
