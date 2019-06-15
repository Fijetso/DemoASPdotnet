using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Realms;
using server.Businesses;
using server.DataTransfers.PostDataTransfers;
using server.Models;

namespace server.Controllers {
    public class PostController : BaseController {
        // private Realm realm => Realm.GetInstance ();
        // private IQueryable<Post> list => realm.All<Post> ();
        // private int nextId => list.Count () == 0 ?
        //     1 : list.AsEnumerable ().Max (p => p.Id) + 1;

        /// <summary>
        /// Get A Post List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PostResponse>> getAll () => PostResponse.List (PostBusiness.List);

        /// <summary>
        /// Get Post By I
        /// </summary>
        /// <param name="id">Post ID</param>
        /// <returns></returns>
        [HttpGet ("{id:int}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (typeof (string), StatusCodes.Status404NotFound)]
        public ActionResult<PostResponse> Item (int id) =>
            (PostResponse) PostBusiness.Get (id);

        /// <summary>
        /// Add new Post
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<PostResponse>> add ([FromBody] PostRequest post) {
            var newPost = await PostBusiness.Add ((Post) post);
            return CreatedAtAction (nameof (add), (PostResponse) newPost);
        }
    }
}