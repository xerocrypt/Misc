using Newtonsoft.Json;

[HttpGet]
[CheckAjaxRequest]
public ActionResult MyView()
{
    ...
    Controller code here
    ...
    return Json(new { success = true, view = RenderPartialViewToString("_MyPartialView", model) }, JsonRequestBehavior.AllowGet);
}


public class CheckAjaxRequestAttribute : ActionFilterAttribute
{
    private const string AJAX_HEADER = "X-Requested-With";

    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        bool isAjaxRequest = filterContext.HttpContext.Request.Headers[AJAX_HEADER] != null;
        if (!isAjaxRequest)
        {
            filterContext.Result = new ViewResult { ViewName = "Unauthorized" };
        }
    }
}


protected string RenderPartialViewToString(string viewName, object model)
{
    if (string.IsNullOrEmpty(viewName))
    viewName = ControllerContext.RouteData.GetRequiredString("action");

    ViewData.Model = model;

    using (var sw = new StringWriter())
    {
        var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
        var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
        viewResult.View.Render(viewContext, sw);
        return sw.GetStringBuilder().ToString();
    }
}