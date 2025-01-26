using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSPlus.Services.Interfaces;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Entities;

namespace CMSPlus.Services.Services;
public class CommentService:ICommentService
{
    private readonly ICommentRepository _commentRepository;

    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public async Task Create(CommentEntity entity)
    {
        await _commentRepository.Create(entity);
    }

    public async Task Delete(int id)
    {
        await _commentRepository.Delete(id);
    }

    public async Task<IEnumerable<CommentEntity>> GetAll()
    {
        return await _commentRepository.GetAll();
    }

    public async Task<CommentEntity> GetById(int id)
    {
        return await _commentRepository.GetById(id);
    }

    public async Task<IEnumerable<CommentEntity>> GetByTopicId(int topicId)
    {
        return await _commentRepository.GetByTopicId(topicId);
    }

    public async Task Update(CommentEntity entity)
    {
        await _commentRepository.Update(entity);
    }
}

