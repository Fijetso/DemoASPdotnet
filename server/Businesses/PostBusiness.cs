using System.Linq;
using System.Threading.Tasks;
using server.DataAccesses;
using server.Models;
namespace server.Businesses {
    public static class PostBusiness {
        public static IQueryable<Post> List => PostDataAccess.List;
        public static Post Get (int Id) {
            Post foundPost = PostDataAccess.Get (Id);
            if (foundPost == null) {
                throw new System.Exception ("Cannot find any Post");
            }
            return foundPost;
        }
        public static async Task<Post> Add (Post post) {
            if (post.Title.Length <= 5) {
                throw new System.Exception ("The Title must be longer than 5");
            }
            if (post.Content.Length <= 10) {
                throw new System.Exception ("The Content must be longer than 10");
            }
            return await PostDataAccess.Add (post);
        }
    }
}