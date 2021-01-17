using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using Forte.EpiResponsivePicture.ResizedImage;

namespace ResponsivePictureSample.Features.Pages.ProjectPage
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString ImagePropertyFor<T, TValue>(this HtmlHelper<T> html,
            Expression<Func<T, TValue>> propExpr,
            PictureProfile pictureProfile)
        {
            return html.PropertyFor(propExpr,
                new {PictureProfile = pictureProfile});
        }
    }
}