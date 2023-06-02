using ECommerceAPI.Application.Validators.Product;
using ECommerceAPI.Infrastructure.Filter;
using ECommerceAPI.Persistance;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistanceServices();
// Cors islemleri icin actigimiz alandir. Simdiki haliyle asagidan gelen adreslerden istegi kabul et dedik
builder.Services.AddCors(options=> options.AddDefaultPolicy(policy=>
policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200", "https://localhost:4200")));// client projesi ile iliskilendirdigimiz alandir.

builder.Services.AddControllers(options=> options.Filters.Add<ValidationFilter>())// ValidationFilter task servisini buraya cagirdik
    .AddFluentValidation(congiguration => congiguration.RegisterValidatorsFromAssemblyContaining<Create_Product_Validator>()); // Burada bir tane validation eklendi mi digerlerini kendisi otommatik algilanmasini sagliyor. RegisterValidatorsFromAssemblyContaining bu ozellik iste
   // .ConfigureApiBehaviorOptions(options=>options.SuppressModelStateInvalidFilter=true);// Burasi ise otomatokik filtrelemesini saglar.




// Burada bir tane validation eklendi mi digerlerini kendisi otommatik algilanmasini sagliyor. RegisterValidatorsFromAssemblyContaining bu ozellik iste
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
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
