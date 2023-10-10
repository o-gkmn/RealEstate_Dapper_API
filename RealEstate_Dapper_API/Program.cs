using RealEstate_Dapper_API.Repositories.BottomGridRepositories;
using RealEstate_Dapper_API.Repositories.CategoryRepositories;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_API.Repositories.ProductRepositories;
using RealEstate_Dapper_API.Repositories.ServiceRepositories;
using RealEstate_Dapper_API.Repositories.TestimonialRepositories;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepositories;
using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Repositories.EmployeeRepositories;

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
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
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
