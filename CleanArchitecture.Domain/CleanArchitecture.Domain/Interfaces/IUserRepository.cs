using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
        List<CleanArchitecture.Domain.Models.OperationClaim> GetClaims(User user);
    }
}
