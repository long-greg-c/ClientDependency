﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.AspNet.Mvc.Rendering;

namespace ClientDependency.Mvc
{
    /// <summary>
    /// IHtmlHelper extensions
    /// </summary>
    public static class HtmlHelperExtensions
    {

        ///// <summary>
        ///// Dynamically registers a path alias
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="pathAlias"></param>
        ///// <param name="virtualPath"></param>
        //public static void RegisterPathAlias(this IHtmlHelper html, string pathAlias, string virtualPath)
        //{
        //    html.ViewContext.GetLoader().AddPath(pathAlias, virtualPath);
        //}

        ///// <summary>
        ///// Dynamically registers a path alias
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="path"></param>
        //public static void RegisterPathAlias(this IHtmlHelper html, IClientDependencyPath path)
        //{
        //    html.ViewContext.GetLoader().AddPath(path);
        //}


        //#region RequiresJsResource Extensions
        //public static IHtmlHelper RequiresJsResource(this IHtmlHelper html, Type resourceType, string resourcePath, int priority, int group)
        //{
        //    var page = new Page();
        //    var resourceUrl = page.ClientScript.GetWebResourceUrl(resourceType, resourcePath);
        //    if (string.IsNullOrEmpty(resourceUrl))
        //    {
        //        throw new NullReferenceException("Could not find embedded resource " + resourcePath + " in assembly " + resourceType.Assembly.FullName);
        //    }

        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, resourceUrl, ClientDependencyType.Javascript);
        //    return html;
        //}

        //public static IHtmlHelper RequiresJsResource(this IHtmlHelper html, Type resourceType, string resourcePath, int priority)
        //{
        //    return html.RequiresJsResource(resourceType, resourcePath, priority, Constants.DefaultGroup);
        //}

        //public static IHtmlHelper RequiresJsResource(this IHtmlHelper html, Type resourceType, string resourcePath)
        //{
        //    return html.RequiresJsResource(resourceType, resourcePath, Constants.DefaultPriority);
        //} 
        //#endregion

        //#region RequiresCssResource Extensions
        //public static IHtmlHelper RequiresCssResource(this IHtmlHelper html, Type resourceType, string resourcePath, int priority, int group)
        //{
        //    var page = new Page();
        //    var resourceUrl = page.ClientScript.GetWebResourceUrl(resourceType, resourcePath);
        //    if (string.IsNullOrEmpty(resourceUrl))
        //    {
        //        throw new NullReferenceException("Could not find embedded resource " + resourcePath + " in assembly " + resourceType.Assembly.FullName);
        //    }

        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, resourceUrl, ClientDependencyType.Css);
        //    return html;
        //}

        //public static IHtmlHelper RequiresCssResource(this IHtmlHelper html, Type resourceType, string resourcePath, int priority)
        //{
        //    return html.RequiresCssResource(resourceType, resourcePath, priority, Constants.DefaultGroup);
        //}

        //public static IHtmlHelper RequiresCssResource(this IHtmlHelper html, Type resourceType, string resourcePath)
        //{
        //    return html.RequiresCssResource(resourceType, resourcePath, Constants.DefaultPriority);
        //} 
        //#endregion

        //#region RequiresJs Extensions
        //public static IHtmlHelper RequiresJsBundle(this IHtmlHelper html, string bundleName)
        //{
        //    html.ViewContext.GetLoader().EnsureJsBundleRegistered(bundleName);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, IClientDependencyFile file, object htmlAttributes = null)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(file, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, ClientDependencyType.Javascript);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, pathNameAlias, ClientDependencyType.Javascript);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias, int priority)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, pathNameAlias, ClientDependencyType.Javascript);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, int group)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, pathNameAlias, ClientDependencyType.Javascript);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, int priority)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, ClientDependencyType.Javascript);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, int priority, int group)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, ClientDependencyType.Javascript);
        //    return html;
        //}


        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, pathNameAlias, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, pathNameAlias, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, int group, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, pathNameAlias, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, int priority, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresJs(this IHtmlHelper html, string filePath, int priority, int group, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, ClientDependencyType.Javascript, htmlAttributes);
        //    return html;
        //} 

        //#endregion

        //#region RequiresCss Extensions
        //public static IHtmlHelper RequiresCssBundle(this IHtmlHelper html, string bundleName)
        //{
        //    html.ViewContext.GetLoader().EnsureCssBundleRegistered(bundleName);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, IClientDependencyFile file, object htmlAttributes = null)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(file, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, ClientDependencyType.Css);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, pathNameAlias, ClientDependencyType.Css);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias, int priority)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, pathNameAlias, ClientDependencyType.Css);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, int group)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, pathNameAlias, ClientDependencyType.Css);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, int priority)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, ClientDependencyType.Css);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, int priority, int group)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, ClientDependencyType.Css);
        //    return html;
        //}

        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(filePath, pathNameAlias, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, pathNameAlias, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, string pathNameAlias, int priority, int group, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, pathNameAlias, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //}
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, int priority, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(priority, filePath, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //} 
        //public static IHtmlHelper RequiresCss(this IHtmlHelper html, string filePath, int priority, int group, object htmlAttributes)
        //{
        //    html.ViewContext.GetLoader().RegisterDependency(group, priority, filePath, ClientDependencyType.Css, htmlAttributes);
        //    return html;
        //} 
        //#endregion

        #region RenderJsHere Extensions
        public static HtmlString RenderJsHere(this IHtmlHelper html)
        {
            return new HtmlString("Hellooooooooooooooooo CDF!");

            //return new HtmlString(
            //    html.ViewContext.GetLoader().RenderPlaceholder(
            //        ClientDependencyType.Javascript, new List<IClientDependencyPath>()));
        }
        //public static IHtmlString RenderJsHere(this IHtmlHelper html, params IClientDependencyPath[] path)
        //{
        //    return new HtmlString(
        //        html.ViewContext.GetLoader().RenderPlaceholder(
        //            ClientDependencyType.Javascript, path));
        //}
        //public static IHtmlString RenderJsHere(this IHtmlHelper html, IEnumerable<IClientDependencyPath> paths)
        //{
        //    return new HtmlString(
        //        html.ViewContext.GetLoader().RenderPlaceholder(
        //            ClientDependencyType.Javascript, paths));
        //}
        //public static IHtmlString RenderJsHere(this IHtmlHelper html, string rendererName, IEnumerable<IClientDependencyPath> paths)
        //{
        //    return new HtmlString(
        //        html.ViewContext.GetLoader().RenderPlaceholder(
        //            ClientDependencyType.Javascript, rendererName, paths));
        //}
        //public static IHtmlString RenderJsHere(this IHtmlHelper html, string rendererName)
        //{
        //    return new HtmlString(
        //        html.ViewContext.GetLoader().RenderPlaceholder(
        //            ClientDependencyType.Javascript, rendererName, Enumerable.Empty<IClientDependencyPath>()));
        //} 
        #endregion
        
        //#region RenderCssHere Extensions
        //public static IHtmlString RenderCssHere(this IHtmlHelper html)
        //{
        //    return new HtmlString(html.ViewContext.GetLoader().RenderPlaceholder(
        //        ClientDependencyType.Css, new List<IClientDependencyPath>()));
        //}
        //public static IHtmlString RenderCssHere(this IHtmlHelper html, params IClientDependencyPath[] path)
        //{
        //    return new HtmlString(html.ViewContext.GetLoader().RenderPlaceholder(
        //        ClientDependencyType.Css, path));
        //}
        //public static IHtmlString RenderCssHere(this IHtmlHelper html, IEnumerable<IClientDependencyPath> paths)
        //{
        //    return new HtmlString(html.ViewContext.GetLoader().RenderPlaceholder(
        //        ClientDependencyType.Css, paths));
        //}
        //public static IHtmlString RenderCssHere(this IHtmlHelper html, string rendererName, IEnumerable<IClientDependencyPath> paths)
        //{
        //    return new HtmlString(html.ViewContext.GetLoader().RenderPlaceholder(
        //        ClientDependencyType.Css, rendererName, paths));
        //}
        //public static IHtmlString RenderCssHere(this IHtmlHelper html, string rendererName, params IClientDependencyPath[] paths)
        //{
        //    return new HtmlString(html.ViewContext.GetLoader().RenderPlaceholder(
        //        ClientDependencyType.Css, rendererName, paths));
        //} 
        //#endregion

        //#region RequiresJsFolder/RequiresCssFolder

        //#region RequiresJsFolder

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter)
        //{
        //    return html.RequiresFolder(folderPath, 100, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri));        
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, int group)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri, group));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, int group, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri, group, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, string searchFilter, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, 100, searchFilter, (absPath, pri) => html.RequiresJs(absPath, pri, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath)
        //{
        //    return html.RequiresJsFolder(folderPath, 100);
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, int priority)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.js", (absPath, pri) => html.RequiresJs(absPath, pri));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, int priority, int group)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.js", (absPath, pri) => html.RequiresJs(absPath, pri, group));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, int priority, int group, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.js", (absPath, pri) => html.RequiresJs(absPath, pri, group, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, int priority, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.js", (absPath, pri) => html.RequiresJs(absPath, pri, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresJsFolder(this IHtmlHelper html, string folderPath, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, 100, "*.js", (absPath, pri) => html.RequiresJs(absPath, pri, htmlAttributes));
        //} 

        //#endregion

        //#region RequireCssFolder
        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter)
        //{
        //    return html.RequiresFolder(folderPath, 100, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, int group)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri, group));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, int group, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri, group, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="priority"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter, int priority, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="searchFilter"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, string searchFilter, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, 100, searchFilter, (absPath, pri) => html.RequiresCss(absPath, pri, htmlAttributes));
        //} 

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath)
        //{
        //    return html.RequiresCssFolder(folderPath, 100);
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, int priority)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.css", (absPath, pri) => html.RequiresCss(absPath, pri));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, int priority, int group)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.css", (absPath, pri) => html.RequiresCss(absPath, pri, group));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="group"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, int priority, int group, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.css", (absPath, pri) => html.RequiresCss(absPath, pri, group, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="priority"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, int priority, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, priority, "*.css", (absPath, pri) => html.RequiresCss(absPath, pri, htmlAttributes));
        //}

        ///// <summary>
        ///// Puts a dependency on an entire folder
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="folderPath"></param>
        ///// <param name="htmlAttributes"></param>
        ///// <returns></returns>
        //public static IHtmlHelper RequiresCssFolder(this IHtmlHelper html, string folderPath, object htmlAttributes)
        //{
        //    return html.RequiresFolder(folderPath, 100, "*.css", (absPath, pri) => html.RequiresCss(absPath, pri, htmlAttributes));
        //} 
        //#endregion

        //private static IHtmlHelper RequiresFolder(this IHtmlHelper html, string folderPath, int priority, string fileSearch, Action<string, int> requiresAction)
        //{
        //    var httpContext = html.ViewContext.HttpContext;
        //    var systemRootPath = httpContext.Server.MapPath("~/");
        //    var folderMappedPath = httpContext.Server.MapPath(folderPath);

        //    if (folderMappedPath.StartsWith(systemRootPath))
        //    {
        //        var files = Directory.GetFiles(folderMappedPath, fileSearch, SearchOption.TopDirectoryOnly);
        //        foreach (var file in files)
        //        {
        //            var absoluteFilePath = "~/" + file.Substring(systemRootPath.Length).Replace("\\", "/");
        //            requiresAction(absoluteFilePath, priority);
        //            html.RequiresJs(absoluteFilePath, priority);
        //        }
        //    }

        //    return html;
        //}

        //#endregion
    }
}
