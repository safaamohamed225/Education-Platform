using AutoMapper;
using EduSpark.Core.Entities;
using EduSpark.Core.Models;

namespace EduSpark.API.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VideoRequest, VideoRequestModel>()
             .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => $"{src.User.FirstName}, {src.User.LastName}"));

            CreateMap<VideoRequestModel, VideoRequest>()
                .ForMember(dest => dest.User, opt => opt.Ignore());
        }
    }
}