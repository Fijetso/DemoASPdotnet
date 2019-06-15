using System;
using Microsoft.AspNetCore.Mvc;
using Realms;
using server.Models.Interface;

namespace server.Models {
    public class Post : RealmObject, IModelHasId {
        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}