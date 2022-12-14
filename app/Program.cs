using app.Context;
using app.DLL.Repositories.Abstract;
using app.DLL.Repositories.Impl;
using app.Sevices.Abstract;
using app.Sevices.Impl;
using app.DLL.Repositories.Abstract.Skill;
using app.Sevices.Abstract.Skill;
using app.DLL.Repositories.Impl.Skill;
using app.Sevices.Impl.Skill;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IC8orService,C8orService>();
builder.Services.AddScoped<IC8orRepository,C8orRepository>();
builder.Services.AddScoped<ISkillService,SkillService>();
builder.Services.AddScoped<ISkillRepository,SkillRepository>();
builder.Services.AddScoped<IC8orSkillService,C8orSkillService>();
builder.Services.AddScoped<IC8orSkillRepository,C8orSkillRepository>();
builder.Services.AddScoped<IFounderService,FounderService>();
builder.Services.AddScoped<IFounderRepository,FounderRepository>();
builder.Services.AddScoped<IProjectService,ProjectService>();
builder.Services.AddScoped<IProjectRepository,ProjectRepository>();
builder.Services.AddScoped<IProjectFounderService,ProjectFounderService>();
builder.Services.AddScoped<IProjectFounderRepository,ProjectFounderRepository>();
builder.Services.AddScoped<IPMService,PMService>();
builder.Services.AddScoped<IPMRepository,PMRepository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();