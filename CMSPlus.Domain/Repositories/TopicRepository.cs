using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistance;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class TopicRepository:Repository<TopicEntity>,ITopicRepository
{
    public TopicRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<TopicEntity?> GetBySystemName(string systemName)
    {
        var result = await _dbSet.SingleOrDefaultAsync(topic => topic.SystemName == systemName);
        return result;
    }

    public async Task<TopicEntity?> GetBySystemNameWithComments(string systemName)
    {
        var result = await _dbSet.Include(topic => topic.Comments.OrderByDescending(comment => comment.CreatedOnUtc)).SingleOrDefaultAsync(topic => topic.SystemName == systemName);
        return result;
    }
}