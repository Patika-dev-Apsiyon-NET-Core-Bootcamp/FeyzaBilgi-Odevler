using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;
        public TagService(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }
        public Task<bool> Add(TagViewModel tag)
        {
            //tag.Blog = tag.SelectedBlogs.Select(x => new BlogViewModel { Id = x }).ToList();
            //_tagRepository.Add(new Domain.Models.Tag {
            //    CreatedAt = DateTime.Now,
            //    Name =tag.Name,
            //    Type=tag.Type,
            //    BlogId=tag.BlogId,
            //    Blog= _mapper.Map<List<BlogViewModel>>(tag.Blog)
            //}); 
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TagViewModel> GetAll()
        {
            return _mapper.Map<List<TagViewModel>>(_tagRepository.GetAll());
        }

        public TagViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Tag GetTagByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<BlogViewModel> GetWithBlog()
        {
            throw new NotImplementedException();
        }

        public bool Update(TagViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
