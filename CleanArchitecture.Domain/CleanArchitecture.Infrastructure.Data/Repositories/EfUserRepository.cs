using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Repositories;
using CleanArchitecture.Domain.Interfaces;
using NuGet.Protocol.Plugins;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Infrastructure.Data.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserRepository: Repository<User>, IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {

        }
        List<CleanArchitecture.Domain.Models.OperationClaim> IUserRepository.GetClaims(User user)
        {
            using (var context = new BlogDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new CleanArchitecture.Domain.Models.OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
