using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp.Models;

namespace WebApp.Infrastructure;

public class ChestPainQueryOptionsBinder: IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var createDocTimeBegin = bindingContext.ActionContext.HttpContext.Request.Query["CreateDocTimeBegin"];
        if (DateTime.TryParse(createDocTimeBegin, out var ctb))
        {
            var result = new ChestPainQueryOptions();
            result.CreateDocTimeBegin = ctb;
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
        return Task.CompletedTask;
    }
}