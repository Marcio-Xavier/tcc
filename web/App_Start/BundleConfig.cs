﻿using System.Web.Optimization;

namespace web
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.min.js",
                        "~/Scripts/inputmask/inputmask.min.js",
                        "~/Scripts/inputmask/jquery.inputmask.js",
                        "~/Scripts/inputmask/inputmask.extensions.js",
                        "~/Scripts/inputmask/inputmask.date.extensions.js",
                        "~/Scripts/inputmask/inputmask.numeric.extensions.js"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender com ela. Após isso, quando você estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/site.css"));
        }
    }
}
