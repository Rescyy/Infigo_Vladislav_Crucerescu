using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSPlus.Domain.Entities;

namespace CMSPlus.Services.Interfaces;
public interface ICommentService
{
    public Task<IEnumerable<CommentEntity>> GetByTopicId(int topicId);
    public Task<IEnumerable<CommentEntity>> GetAll();
    public Task<CommentEntity> GetById(int id);
    public Task Create(CommentEntity entity);
    public Task Update(CommentEntity entity);
    public Task Delete(int id);
}

