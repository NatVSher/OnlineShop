using AutoMapper;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.PathsToImages, opt => opt.MapFrom(y=>y.Images.Select(x => x.ImagePath).ToList()));
            
            CreateMap<Product, EditProductViewModel>()
                .ForMember(x => x.PathsToImages, opt => opt.MapFrom(y => y.Images.Select(x => x.ImagePath).ToList()))
                .ReverseMap()
                .ForMember(x => x.Images, opt => opt.MapFrom(y => y.PathsToImages.Select(x => new ImageProduct{ ImagePath = x }).ToList()));
            
            CreateMap<CreateProductViewModel, Product>(); 
            CreateMap<BasketItem, BasketItemViewModel>().ReverseMap();
            CreateMap<Basket, BasketViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>();
            CreateMap<ContactDetails, ContactDetailsViewModel>().ReverseMap();
            
            CreateMap<User, UserViewModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(y => y.UserName));

            CreateMap<CreateUserViewModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(y => y.UserName));
            CreateMap<User, UserAvatarViewModel>().ReverseMap();
        }       
    }
}
