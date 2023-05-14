using AutoMapper;
using Order.DAL.Models;
using Order.DAL.ViewModels;
using Order.DAL.ViewModelsWithId;

namespace Order.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<CategoryViewModel, Category>();
        CreateMap<CategoryViewModelWithId, Category>();

        CreateMap<ProductViewModel, Product>();
        CreateMap<ProductViewModelWithId, Product>();

    }
}