using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Realms;
using server.Models;

namespace server.Controllers {
    public class PostController : BaseController {
        private Realm realm => Realm.GetInstance ();
        private IQueryable<Post> list => realm.All<Post> ();
        private int nextId => list.Count () == 0 ?
            1 : list.AsEnumerable ().Max (p => p.Id) + 1;

        /// <summary>
        /// Get A Post List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Post>> getAll () => list.ToList ();
        /// <summary>
        /// Get Post By I
        /// </summary>
        /// <param name="id">Post ID</param>
        /// <returns></returns>
        [HttpGet ("{int:id}")]
        public ActionResult<Post> GetById (int id) {
            Post foundPost = realm.Find<Post> (id);
            if (foundPost == null) {
                return null;
            }
            return foundPost;
        }
        /// <summary>
        /// Add new Post
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Post>> add () {
            Post p = new Post () {
                Id = nextId,
                Title = "My title",
                Content = "My content",
                Created = new DateTimeOffset ()
            };
            await realm.WriteAsync (r => p = r.Add (p));
            return p;
        }
    }
}