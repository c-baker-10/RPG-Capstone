using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhlXVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jTXxXdEVnWH1ZeHdVTw==;Mgo+DSMBPh8sVXJ0S0J+XE9Bd1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TckdnW39acXZST2hfUQ==;ORg4AjUWIQA/Gnt2VVhkQlFac15JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkFhXX1edHVXTmFVU0U=;MTgzMDA4NkAzMjMwMmUzNDJlMzBLY1NoaklpK0dsallBakdrd0xwamJ6OXU4Yk4zRTBQQi9FaktRQ3cvYjJnPQ==;MTgzMDA4N0AzMjMwMmUzNDJlMzBPWXZmSDlWZjU0MUxCS01hQ2JKM2gwSDVkdkVsZkFlT2tZTTJ5elpXeklBPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFpDVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVnW3tccHBURGhUUkV+;MTgzMDA4OUAzMjMwMmUzNDJlMzBJL3J0NDJ5b3MwZWxtU2xqVHA0QkUvNEljbm4yS3RMS3owcFJLQ01KRjhRPQ==;MTgzMDA5MEAzMjMwMmUzNDJlMzBUMXN0RVVHaGtOMWx5WEdJeVBETkZjY0p5dWVRcHd4SGVLMzlHRjNVOGkwPQ==;Mgo+DSMBMAY9C3t2VVhkQlFac15JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkFhXX1edHVXT2JUUUc=;MTgzMDA5MkAzMjMwMmUzNDJlMzBNWGxsYkdCK1pYYW9zZHZ6ajJXVmxEUVRwYkhMZ202a1BXWm5mOUxqYmF3PQ==;MTgzMDA5M0AzMjMwMmUzNDJlMzBaTXA4MUx3T2ZjSjVFR2VTeGRhVTBzS1hDU1hjR2JydlhONEg4UTJQeFFzPQ==;MTgzMDA5NEAzMjMwMmUzNDJlMzBJL3J0NDJ5b3MwZWxtU2xqVHA0QkUvNEljbm4yS3RMS3owcFJLQ01KRjhRPQ== ");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
