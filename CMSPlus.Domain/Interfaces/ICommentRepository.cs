using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSPlus.Domain.Entities;

namespace CMSPlus.Domain.Interfaces;
public interface ICommentRepository: IRepository<CommentEntity>
{
    public Task<IEnumerable<CommentEntity>> GetByTopicId(int topicId);
}

