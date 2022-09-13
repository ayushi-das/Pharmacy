using PharmacyManagementWebAPI.Repository;
using PharmacyManagementWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IMedicineRepository, MedicineServices>();
builder.Services.AddTransient<IDoctorRepository, DoctorServices>();
builder.Services.AddTransient<IOrderRepository, OrderServices>();
builder.Services.AddTransient<ISupplierRepository, SupplierServices>();

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
