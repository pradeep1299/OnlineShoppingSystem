using OnlineShoppingSystem_Entity;

namespace OnlineShoppingSystem.Models
{
    public class Mapper
    {
        public static void Mapping()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<CustomerViewModel, CustomerDetails>().ForMember(dest => dest.Role, opt => opt.MapFrom(src => "Customer"));
                config.CreateMap<ProductViewModel, Product>();
                config.CreateMap<Product,ProductViewModel>();
                config.CreateMap<CategoryViewModel, Category>();
            }
            );
        }
    }
}