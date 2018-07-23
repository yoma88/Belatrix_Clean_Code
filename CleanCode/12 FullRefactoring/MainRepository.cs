using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode._12_FullRefactoring
{
    public class MainRepository
    {
        private PostDbContext _postDbContext;

        public Post GetPostById(int postId)
        {
            return _postDbContext.Posts.SingleOrDefault(p => p.Id == postId);
        }

        public void SaveChanges(Post post)
        {
            _postDbContext.Posts.Add(post);
            _postDbContext.SaveChanges();
        }

    }
}
