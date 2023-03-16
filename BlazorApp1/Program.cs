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
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhlXVpAaV5AQmFJfFBmRmldeVR0dEUmHVdTRHRcQl5iSn9WckJiWn1deHY=;Mgo+DSMBPh8sVXJ0S0J+XE9Bd1RGQmJLYVF2R2BJfFR0cl9CYEwxOX1dQl9gSX1SdURmXXhfc3ZQQmI=;ORg4AjUWIQA/Gnt2VVhkQlFac15JWXxIfEx0RWFab116cFNMZFxBJAtUQF1hSn5Qd0ZiXHtZcXdXQGle;MTMxNTIxMEAzMjMwMmUzNDJlMzBXL2k4czVWRnpxdzJLUTVtbUVIRXJReUVTV1hpS0lFZGJFcVh0OGRhMDhrPQ==;MTMxNTIxMUAzMjMwMmUzNDJlMzBsWExGSkxDUU1SSndOSVF2R0NFcVd4V0NvZjgxM3lzOUlaaXZCTWpaTVpNPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFpDVmdWf1FpR2NbfE5zflFAalhRVBYiSV9jS31TdURgWHpad3VWRWNVUw==;MTMxNTIxM0AzMjMwMmUzNDJlMzBCVDR5RDl4Q0M5RXdndWttSmJiYndkdHhUWDdsNEw4OWYyTWVNbTA3V0RvPQ==;MTMxNTIxNEAzMjMwMmUzNDJlMzBhQVBiT3JheUk3UGJ1UzdBNE5INC95bHZ3N2thNVdxazZTMnlzU2ZxL0VvPQ==;Mgo+DSMBMAY9C3t2VVhkQlFac15JWXxIfEx0RWFab116cFNMZFxBJAtUQF1hSn5Qd0ZiXHtZcXdRRmFe;MTMxNTIxNkAzMjMwMmUzNDJlMzBqd2l4YVYwVVJjbHZRc2pkZHNFREpHeTRrSSsvUEMrNzRMN0EvODR1bDBVPQ==;MTMxNTIxN0AzMjMwMmUzNDJlMzBqUkgrVG1nSlhDaTJMSXhaQ2xFMHUxaTA3c1VrM0RGeWZmR1lGSUR4cUhrPQ==;MTMxNTIxOEAzMjMwMmUzNDJlMzBCVDR5RDl4Q0M5RXdndWttSmJiYndkdHhUWDdsNEw4OWYyTWVNbTA3V0RvPQ==");

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
