using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BusinessLogicLayer.Filters.ModelValidationFilter
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var apiError = new Messages();

                var erros = context.ModelState.AsEnumerable();
                foreach (var error in erros)
                {
                    foreach (var inner in error.Value!.Errors)
                    {
                        apiError.message.Add(inner.ErrorMessage);
                    }
                }
                context.Result = new BadRequestObjectResult(apiError);
            }
            base.OnActionExecuting(context);
        }
    }
    public class Messages
    {
        public List<string> message { get; set; }
        public bool isSuccess { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
