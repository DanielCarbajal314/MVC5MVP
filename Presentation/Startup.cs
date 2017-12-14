using AutoMapper;
using DataAccess.Models;
using Microsoft.Owin;
using Owin;
using ServicesInterface.Product.Requests;
using ServicesInterface.Product.Responses;

[assembly: OwinStartupAttribute(typeof(Presentation.Startup))]
namespace Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Mapper.Initialize(configuration => {
                configuration.CreateMap<Product, GeneralProduct>();
                configuration.CreateMap<NewProduct, Product>();
            });
            ConfigureAuth(app);
        }
    }
}
