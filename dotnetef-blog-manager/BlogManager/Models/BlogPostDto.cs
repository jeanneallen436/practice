using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManager.Models
{
    public record BlogPostDto(Guid Id, string Title, string Content, List<Tag> Tags, DateTime PublishedDate, string CoverImage, Author Author);
}