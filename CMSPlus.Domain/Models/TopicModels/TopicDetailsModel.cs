namespace CMSPlus.Domain.Models.TopicModels;

using CMSPlus.Domain.Models.CommentModels;

public class TopicDetailsModel : BaseTopicModel
{
    public TopicDetailsModel()
    {
        UpdatedOnUtc = CreatedOnUtc = DateTime.UtcNow;
    }

    public int Id { get; set; }
    public string SystemName { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime? CreatedOnUtc { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
    public IEnumerable<CommentDetailsModel> Comments { get; set; } = null!;
}