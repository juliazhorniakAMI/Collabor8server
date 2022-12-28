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

builder.Services.AddTransient<IUserService,UserService>();
builder.Services.AddTransient<IUserRepository,UserRepository>();
builder.Services.AddTransient<IC8orService,C8orService>();
builder.Services.AddTransient<IC8orRepository,C8orRepository>();
builder.Services.AddTransient<ISkillService,SkillService>();
builder.Services.AddTransient<ISkillRepository,SkillRepository>();
builder.Services.AddTransient<IC8orSkillService,C8orSkillService>();
builder.Services.AddTransient<IC8orSkillRepository,C8orSkillRepository>();
builder.Services.AddTransient<IFounderService,FounderService>();
builder.Services.AddTransient<IFounderRepository,FounderRepository>();
builder.Services.AddTransient<IProjectService,ProjectService>();
builder.Services.AddTransient<IProjectRepository,ProjectRepository>();
builder.Services.AddTransient<IProjectSkillService,ProjectSkillService>();
builder.Services.AddTransient<IProjectSkillRepository,ProjectSkillRepository>();
builder.Services.AddTransient<IC8orProjectService,C8orProjectService>();
builder.Services.AddTransient<IC8orProjectRepository,C8orProjectRepository>();
builder.Services.AddTransient<IProjectSupportInfoService,ProjectSupportInfoService>();
builder.Services.AddTransient<IProjectSupportInfoRepository,ProjectSupportInfoRepository>();
builder.Services.AddTransient<IC8orAccepted4ProjectService,C8orAccepted4ProjectService>();
builder.Services.AddTransient<IC8orAccepted4ProjectRepository,C8orAccepted4ProjectRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();