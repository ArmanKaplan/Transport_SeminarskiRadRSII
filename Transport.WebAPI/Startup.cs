using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Transport.Model;
using Transport.WebAPI.Database;
using Transport.WebAPI.Security;
using Transport.WebAPI.Services;

namespace Transport.WebAPI
{
    //public class BasicAuthDocumentFilter : IDocumentFilter
    //{
    //    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    //    {
    //        var securityRequirements = new Dictionary<string, IEnumerable<string>>()
    //    {
    //        { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
    //    };

    //        //swaggerDoc.SecurityRequirements = new[] { securityRequirements }
    //    }

    //}

    public class Startup
    {


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddAutoMapper(typeof(Startup));

                services.AddAuthentication("BasicAuthentication")
           .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });


            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            //    //c.AddSecurityDefinition("basic", new OpenApiSecurityScheme() { Type = "basic" });
            //    c.DocumentFilter<BasicAuthDocumentFilter>();
            //});


            services.AddControllers();

            var connection = Configuration.GetConnectionString("Transport");
            services.AddDbContext<TransportContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IVozaciService, VozaciService>();
            services.AddScoped<IKlijentiService, KlijentiService>();
            services.AddScoped<IZahtjeviService, ZahtjeviService>();
            services.AddScoped<IPreporukaService, PreporukaService>();
            services.AddScoped<IService<Model.Vozila, VozilaSearchRequest>, VozilaService>();
            services.AddScoped<IAdministratorService, AdministratoriService>();
            services.AddScoped<ICRUDService<Model.Vozila, VozilaSearchRequest, VozilaInsertRequest, VozilaUpdateRequest>, VozilaService>();
            //services.AddScoped<ICRUDService<Model.Obavijesti, object, ObavijestiPosaljiRequest, object>, ObavijestiService>();
            services.AddScoped<ICRUDService<Model.Obavijesti, object, ObavijestiPosaljiRequest, object>, BaseCRUDService<Model.Obavijesti, object, ObavijestiPosaljiRequest, object, Database.Obavijesti>>();
            services.AddScoped<ICRUDService<Model.Kvarovi, KvaroviSearchRequest, KvaroviInsertRequest, object>,KvaroviService>();
            services.AddScoped<ICRUDService<Model.Klijenti, KlijentiSearchRequest, KlijentiInsertRequest, KlijentiUpdateRequest>, KlijentiService>();
            services.AddScoped<IService<Model.Gradovi, object>, BaseService<Model.Gradovi, object, Database.Gradovi>>();
            
            services.AddScoped<ICRUDService<Model.Voznje, VoznjeSearchRequest, VoznjeInsertRequest, VoznjeUpdateRequest>, VoznjeService>();
            services.AddScoped<ICRUDService<Model.Lociranja, LociranjaSerachRequest, LociranjaInsertRequest, LociranjaUpdateRequest>,LociranjaService>();

            services.AddScoped<ICRUDService<Model.Zahtjevi, ZahtjeviSearchRequest, ZahtjevInsertRequest, ZahtjeviOdgovorRequest>, ZahtjeviService>();
            services.AddScoped<IService<Model.TipVozila, object>, BaseService<Model.TipVozila, object, Database.TipoviVozila>>();
            services.AddScoped<IService<Model.TipoviRoba, object>, BaseService<Model.TipoviRoba, object, Database.TipoviRoba>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(builder => {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {


                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");


            });

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

