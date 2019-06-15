using System;
using AutoMapper;
using server.Models;
namespace server.DataTransfers.PostDataTransfers {
    public class PostResponse {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset Created { get; set; }
        public static implicit operator PostResponse (Post post) => Mapper.Map<Post, PostResponse> (post);
    }
}