using System;
using AutoMapper;
using server.Models;
namespace server.DataTransfers.PostDataTransfers {
    public class PostRequest : BaseDataTransfers<Post, PostRequest> {
        public string Title { get; set; }
        public string Content { get; set; }
        // public static implicit operator PostRequest (Post post) => Mapper.Map<Post, PostRequest> (post);
    }
}