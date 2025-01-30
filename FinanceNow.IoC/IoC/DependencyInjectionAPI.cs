

using FinanceNow.Data;
using FinanceNow.Mappings;
using FinanceNow.Services;
using FinanceNow.Services.Interfaces;
using FinanceNow.UOW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;


namespace FinanceNow.IoC.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddMyDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(
                            swagger =>
                            {
                                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "FinanceNOW", Description = "FinanceNOW is an API for Credit Analysis", Version = "v1" });
                                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                                {
                                    Name = "Authorization",
                                    Type = SecuritySchemeType.ApiKey,
                                    Scheme = "Bearer",
                                    In = ParameterLocation.Header,
                                    Description = "This is a JWT Bearer Token Authentication, Insert your Token with 'Bearer' at the begininng \\\n" +
                                    "Example: Bearer ywowknqwqytt12816gstar",
                                });
                                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                     });
                            }
                 );
            services.AddDbContext<FinanceNowContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("DB")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddAutoMapper(typeof(MappingToDTO));
            services.AddAuthentication(opt =>
            {

                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["jwt:issuer"],
                    ValidAudience = configuration["jwt:audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:secretkey"])

                    )

                };
            });
            return services;
        }


    }
}
