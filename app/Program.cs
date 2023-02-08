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
//builder.Services.AddCors();
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
builder.Services.AddTransient<ISphereSkillService,SphereSkillService>();
builder.Services.AddTransient<ISphereSkillRepository,SphereSkillRepository>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// wch - Added following code
// https://learn.microsoft.com/en-us/answers/questions/1026379/access-to-fetch-been-blocked-by-cors-policy-react
builder.Services.AddCors(options =>  
    {  
    options.AddDefaultPolicy(  
        policy =>  
        {  
            policy.WithOrigins("http://localhost:3000")  
                .AllowAnyHeader()  
                .AllowAnyMethod();  
        });  
}); 
// wch - Added previous code
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
 app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();

// wch - Added following code
app.UseCors();  
// wch - Added pervious code

app.MapControllers();

app.Run();