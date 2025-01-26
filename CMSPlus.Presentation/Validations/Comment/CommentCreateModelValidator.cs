using CMSPlus.Domain.Models.CommentModels;
using FluentValidation;

namespace CMSPlus.Presentation.Validations.Comment;

public class CommentCreateModelValidator : AbstractValidator<CommentCreateModel>
{
    public CommentCreateModelValidator()
    {
        RuleFor(comment => comment.Body)
            .NotEmpty().WithMessage("Body must not be empty");
    }
}

