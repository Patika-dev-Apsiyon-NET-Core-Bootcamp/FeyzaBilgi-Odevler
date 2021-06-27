using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.WebUI.Filters;
using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Filters
{
    public class CacheControl : IActionFilter
    {
        private IDistributedCache _cache;
        private string _userKey = "USER";
        public CacheControl(IDistributedCache cache)
        {
            _cache = cache;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user= _cache.Get<User>(_userKey);
            if (user == null)
            {
                //context.Result = new NotFoundResult();
                context.Result = new RedirectToActionResult("Index","Filter",null);
                return;
            }            
        }
    }
}
