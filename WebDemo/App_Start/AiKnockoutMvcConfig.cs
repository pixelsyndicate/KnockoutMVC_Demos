using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(
typeof(WebDemo.AiKnockoutMvcConfig), "RegisterBundles")]

namespace WebDemo
{
    public static class AiKnockoutMvcConfig
    {
           public static void RegisterBundles()
        {
            var bundles = BundleTable.Bundles;
            bundles.Add(new ScriptBundle("~/bundles/knockoutMVC").Include(
                "~/scripts/knockout-{version}.js",
                "~/scripts/knockoutMVC/utilities/*.js",
               "~/scripts/knockoutMVC/*.js",
               "~/scripts/knockoutMVC/viewModels/*.js"
               ));

            var bundleOrder = new BundleFileSetOrdering("KnockoutMVCBundleOrder");
            bundleOrder.Files.Add("knockout-{version}.js");
            bundleOrder.Files.Add("namespace*");
            bundleOrder.Files.Add("utilities.*");
            bundleOrder.Files.Add("knockoutMvc");
            bundleOrder.Files.Add("viewModels.*");
            

            BundleTable.Bundles.FileSetOrderList.Add(bundleOrder);
        }
    }
}