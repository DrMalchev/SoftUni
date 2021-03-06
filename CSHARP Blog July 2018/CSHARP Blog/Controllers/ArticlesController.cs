﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSHARP_Blog.Data;
using CSHARP_Blog.Models;
using CSHARP_Blog.Models.ArticlesViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSHARP_Blog.Controllers
{
    public class ArticlesController : Controller
    {
		private readonly BlogDbContext dbContext;
		private readonly UserManager<User> userManager;

		public ArticlesController(BlogDbContext dbContext, UserManager<User> userManager) 
		{
			this.dbContext = dbContext;
			this.userManager = userManager;
		}

		[HttpGet]
        public IActionResult Index()
        {
			List<ArticleIndexViewModel> articles = this.dbContext
			.Articles
			.Select(a => new ArticleIndexViewModel
			{
				Id = a.Id,
				Title = a.Title,
				Summary = a.Summary,
				AuthorFullName = a.Author.FullName
			})
			.ToList();

			return View(articles);

        }

		[HttpGet]
		[Authorize]
		public IActionResult Create() 
		{
			//return null;
			return View();
		}

		[HttpPost]
		[Authorize]
		public IActionResult Create(Article article)
		{

			string userId = this.userManager.GetUserId(this.User);
			article.AuthorId = userId;

			if (ModelState.IsValid)
			{
				this.dbContext.Add(article);
				this.dbContext.SaveChanges();

				return RedirectToAction("Index");

			}
			return View(article);

		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			Article article = this.dbContext
				.Articles
				.Include(a => a.Author)
				.FirstOrDefault(a => a.Id == id);

			if (article==null)
			{
				return NotFound();
			}

			return View(article);
		}

		[HttpGet]
		[Authorize]
		public IActionResult Edit(int id)
		{
			Article article = this.dbContext.Articles.Find(id);

			string currentUserId = this.userManager.GetUserId(this.User);

			if (article == null)
			{
				return NotFound();
			}

			if (article.AuthorId!=currentUserId)
			{
				return Forbid();
			}

			return View(article);
		}

		[HttpPost]
		[Authorize]
		//[Route("/articles/edit/{id}")]
		public IActionResult Edit(Article article)
		{

			string currentUserId = this.userManager.GetUserId(this.User);
			if (article.AuthorId != currentUserId)
			{
				return Forbid();
			}
			if (ModelState.IsValid)
			{
				this.dbContext.Articles.Update(article);
				this.dbContext.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(article);
		}

		[HttpGet]
		[Authorize]
		public IActionResult Delete(int id)
		{
			Article article = this.dbContext.Articles.Find(id);
			if (article == null)
			{
				return NotFound();
			}
			string currentUserId = this.userManager.GetUserId(this.User);

			if (article.AuthorId!=currentUserId)
			{
				return Forbid();
			}


			return View(article);
		}

		[HttpPost]
		[Authorize]
		public IActionResult Delete(Article article)
		{

			bool isArticleExisting = this.dbContext.Articles.Any(a => a.Id == article.Id);
			if (!isArticleExisting)
			{
				return NotFound();
			}
			string currentUserId = this.userManager.GetUserId(this.User);
			if (article.AuthorId != currentUserId)
			{
				return Forbid();
			}
			this.dbContext.Articles.Remove(article);
			this.dbContext.SaveChanges();

			return RedirectToAction("Index");
		}


	}
}