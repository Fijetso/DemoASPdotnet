using AutoMapper;
using server.DataTransfers.PostDataTransfers;
using server.Models;

namespace server.DataTransfers {
    public class MappingProfile : Profile {
        public MappingProfile () {
            MappingPost ();
        }
        public void MappingPost () {
            CreateMap<Post, PostResponse> ();
            CreateMap<PostRequest, Post> ();
        }
    }
}