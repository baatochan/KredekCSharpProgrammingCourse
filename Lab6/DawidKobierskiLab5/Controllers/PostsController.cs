using DawidKobierskiLab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DawidKobierskiLab5.Controllers
{
    public class PostsController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            List<Post> posts;
            using (var ctx = new BlogContext())
            {
                posts = ctx.Posts.ToList();
            }

            return View(posts);
        }

        public ActionResult Add()
        {
            return View(new Post());
        }

        [HttpPost]
        public ActionResult Add(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            using (var ctx = new BlogContext())
            {
                ctx.Posts.Add(post);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Post post;

            using (var ctx = new BlogContext())
            {
                post = ctx.Posts.SingleOrDefault(p => p.Id == id);
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Posts.SingleOrDefault(p => p.Id == id);
                dbEntry.Title = post.Title;
                dbEntry.Body = post.Body;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var ctx = new BlogContext())
            {
                var dbEntry = ctx.Posts.SingleOrDefault(p => p.Id == id);
                ctx.Posts.Remove(dbEntry);
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult AddComment(int id)
        {
            return View(new Comment());
        }

        [HttpPost]
        public ActionResult AddComment(int id, Comment comment)
        {
            /*if (!ModelState.IsValid)
            {
                return View(comment);
            }*/

            Post post;

            using (var ctx = new BlogContext())
            {
                post = ctx.Posts.SingleOrDefault(p => p.Id == id);
                ctx.Comments.Add(comment);

                IEnumerable<Comment> newComment = new List<Comment> { comment };
                post.Comments.Concat(newComment);

                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}