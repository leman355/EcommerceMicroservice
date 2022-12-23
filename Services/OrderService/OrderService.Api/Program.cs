using OrderService.Business.Abstract;
using OrderService.Business.Concrete;
using OrderService.DataAccess.Abstract;
using OrderService.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<OrderDbContext>();

builder.Services.AddScoped<IOrderDal, OrderDal>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<IOrderItemDal, OrderItemDal>();
builder.Services.AddScoped<IOrderItemService, OrderItemManager>();


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
