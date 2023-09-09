using RealEstate_Dapper_UI.Models.DapperContext;
using RealEstate_Dapper_UI.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_UI.Repositories.BottomGridRepositories;
using RealEstate_Dapper_UI.Repositories.CategoryRepositories;
using RealEstate_Dapper_UI.Repositories.ProductRepositories;
using RealEstate_Dapper_UI.Repositories.ProductRepositories;
using RealEstate_Dapper_UI.Repositories.ServiceRepositories;
using RealEstate_Dapper_UI.Repositories.ServiceRepositories;
using RealEstate_Dapper_UI.Repositories.WhoWeAreRepositories;
using RealEstate_Dapper_UI.Repositories.WhoWeAreRepositories;
using RealEstate_Dapper_UI.Repositories.TestimonialRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreRepository, WhoWeAreRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
