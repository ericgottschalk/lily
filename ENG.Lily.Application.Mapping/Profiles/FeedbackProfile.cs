using AutoMapper;
using ENG.Lily.Application.Mapping.Model;
using ENG.Lily.Domain.Entities;

namespace ENG.Lily.Application.Mapping.Profiles
{
    internal class FeedbackProfile : Profile
    {
        internal FeedbackProfile()
        {
            this.CreateMap<Feedback, FeedbackModel>();
            this.CreateMap<FeedbackModel, Feedback>();
        }
    }
}
