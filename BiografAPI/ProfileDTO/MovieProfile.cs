using AutoMapper;

namespace BiografAPI.ProfileDTO;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<Movie, MovieDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.ImgURL, opt => opt.MapFrom(src => src.ImgURL))
            .ForMember(dest => dest.Themes, opt => opt.MapFrom(src => src.Themes.Select(t => t.Name)))
            .ForAllMembers(opt => opt.MapFrom(src => src.ReleaseDate));
    }
}
