using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ByPassingFilters.Filters
{
    public class SecurityActionFilterAttribute : ActionFilterAttribute
    {
        private readonly SecurityOptions _settings;

        public SecurityActionFilterAttribute(IOptions<SecurityOptions> options)
        {
            _settings = options.Value;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
           
            if (!String.IsNullOrEmpty(_settings.FilterRegex))
            {
                foreach (string name in context.HttpContext.Request.Query.Keys)
                {
                    string value = context.HttpContext.Request.Query[name];

                    if (Regex.IsMatch(value, _settings.FilterRegex))
                    {
                        context.Result = new RedirectResult("/Home/Error");
                        return;
                    }
                }

                foreach (string name in context.HttpContext.Request.Form.Keys)
                {
                    string value = context.HttpContext.Request.Form[name];

                    if (Regex.IsMatch(value, _settings.FilterRegex))
                    {
                        context.Result = new RedirectResult("/Home/Error");
                        return;
                    }
                }

            }
        }
    }
}
