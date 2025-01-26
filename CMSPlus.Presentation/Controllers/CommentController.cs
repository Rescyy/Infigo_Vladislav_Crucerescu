using AutoMapper;
using CMSPlus.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Services.Services;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMSPlus.Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly IValidator<CommentCreateModel> _createModelValidator;

        public CommentController(ICommentService commentService, IMapper mapper, IValidator<CommentCreateModel> createModelValidator)
        {
            _commentService = commentService;
            _mapper = mapper;
            _createModelValidator = createModelValidator;
        }

        // GET: CommentController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int topicId, string systemName, CommentCreateModel comment)
        {
            var validationResult = await _createModelValidator.ValidateAsync(comment);
            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);
                return View(comment);
            }
            var commentEntity = _mapper.Map<CommentCreateModel, CommentEntity>(comment);
            commentEntity.TopicId = topicId;
            await _commentService.Create(commentEntity);
            return RedirectToAction("Details", "Topic", new { systemname = systemName });
        }
    } 
}
