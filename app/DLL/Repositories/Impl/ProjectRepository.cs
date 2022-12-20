using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Context;
using app.DLL.Models;
using app.DLL.Repositories.Abstract;
using app.ModelsDTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace app.DLL.Repositories.Impl
{
    public class ProjectRepository : GenericKeyRepository<int, Project, DataContext>, IProjectRepository
    {
         private readonly IMapper _mapper;
          public ProjectRepository(DataContext context, IMapper mapper) : base(context)
        {
           _mapper = mapper  ;
        }
        public async Task<bool> AddProject(ProjectDTO project)
        {
           Project r= _mapper.Map<ProjectDTO, Project>(project);
            return await Add(r);         
        }
        public async Task<bool> DeleteProject(int id)
        {
             var p = await GetById(id);
            return await Delete(p);
        }
        public async Task<bool> UpdateProject(ProjectDTO project)
        {
            var existingProject = Context.Projects.First(x => x.Id == project.Id);
            existingProject.Name = project.Name;
            existingProject.Purpose = project.Purpose;
            existingProject.Ideas = project.Ideas;
            existingProject.Contracts = project.Contracts;
            return await Update(existingProject);
        }
    }
}