using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Linq;
using Trendyol.Identity;

namespace Trendyol.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICommentService _commentService;
        private UserManager<User> _userManager;
        private IQuestionsService _questionsService;

        public ProductController(IQuestionsService questionsService,IProductService productService,ICommentService commentService,UserManager<User> userManager) { 
        _productService= productService;
            _commentService= commentService;
            _userManager= userManager;
        _questionsService=questionsService;
        }
        
        public IActionResult Details(int id)
        {

            var answer=_questionsService.GetAnswerQuestions(id);
            ViewBag.answer = answer;

            var questions=_questionsService.GetQuestions(id);
            ViewBag.Questions = questions;

            var comments=  _commentService.GetComments(id);
            ViewBag.Comments = comments;
            
            var product=_productService.GetById(id);
            
            var products=_productService.GetAll().Where(i=>i.ProductClassName==product.ProductClassName);
            ViewBag.products=products;

            var benzerUrunler=_productService.GetAlls().Where(i=>i.ProductClassName!=product.ProductClassName);
            ViewBag.benzerUrunler=benzerUrunler;

            using (var db=new Context())
            {
                var like = db.CommentLikes.Where(i => i.ProductId == id).ToList();
                ViewBag.like=like;   
            }
            var userId = _userManager.GetUserId(User);
            ViewBag.UserId = userId;
            return View(product);
        }

        public IActionResult AddQuestion(string questions,int productId)
        {
            string userId=_userManager.GetUserId(User);

            var userName=User.Identity.Name;
            var date = DateTime.Now;
            _questionsService.AddQuestions(questions, userId, productId, userName, date);

            return Redirect("/product/details/" + productId);

        }

        public IActionResult AddComment(string comment,int productId)
        {
            var userId = _userManager.GetUserId(User);
            var userName=User.Identity.Name;
            var date = DateTime.Now;
            _commentService.AddComment(comment, userId, userName, productId, date);

            return Redirect("/product/details/" + productId);
        }
    }
}
