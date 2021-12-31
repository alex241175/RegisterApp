using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using RegisterApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

// Add basic functionality to the container.
builder.Services.AddControllersWithViews();   // web api controller
builder.Services.AddRazorPages(); 
//builder.Services.AddServerSideBlazor();
builder.Services.AddServerSideBlazor().AddCircuitOptions(option => { option.DetailedErrors = true; });

// add database support
builder.Services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlite(builder.Configuration.GetConnectionString("Register")));

// add cors for allowing other url to use the api resources
builder.Services.AddCors(opt =>  {   
    opt.AddDefaultPolicy(builder => {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// builder.Services.AddHttpContextAccessor();
// builder.Services.AddScoped<HttpContextAccessor>();
// builder.Services.AddHttpClient();
// builder.Services.AddScoped<HttpClient>();

// add google authentication
builder.Services.AddAuthentication("Cookies").AddCookie(opt =>
{
    opt.Cookie.Name = "GoogleOAuth";
    opt.LoginPath = "/Login";
})
.AddGoogle(opt => 
{
    opt.ClientId = builder.Configuration["Google:ClientId"];
    opt.ClientSecret = builder.Configuration["Google:ClientSecret"];
    opt.Scope.Add("profile");
});

// below policy not working when rendered authorizeview policy = IsAdmin
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IsAdmin", policyBuilder => {
        policyBuilder.RequireAuthenticatedUser();
        policyBuilder.RequireClaim("role", "Admin");
    });
});

// add new claim - role
builder.Services.AddScoped<IClaimsTransformation, UserInfoClaims>();

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCookiePolicy();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors();

app.UseDeveloperExceptionPage();
app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
