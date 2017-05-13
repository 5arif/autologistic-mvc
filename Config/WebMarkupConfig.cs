using System.Collections.Generic;
using System.IO.Compression;
using Microsoft.Extensions.DependencyInjection;
using WebMarkupMin.AspNet.Common.Compressors;
using WebMarkupMin.AspNet.Common.UrlMatchers;
using WebMarkupMin.AspNetCore1;
using WebMarkupMin.Core;
using WebMarkupMin.NUglify;

namespace AutoLogistic.Config
{
    public static class WebMarkupConfig
    {
        public static void  Register(IServiceCollection services) {
            services.AddWebMarkupMin(options =>
            {
                options.AllowMinificationInDevelopmentEnvironment = true;
                options.AllowCompressionInDevelopmentEnvironment = true;
            })
           .AddHtmlMinification(options =>
           {
               options.ExcludedPages = new List<IUrlMatcher>
               {
                    new WildcardUrlMatcher("/minifiers/x*ml-minifier")
               };

               HtmlMinificationSettings settings = options.MinificationSettings;
               settings.RemoveRedundantAttributes = true;
               settings.RemoveHttpProtocolFromAttributes = true;
               settings.RemoveHttpsProtocolFromAttributes = true;

               options.CssMinifierFactory = new NUglifyCssMinifierFactory();
               options.JsMinifierFactory = new NUglifyJsMinifierFactory();
           })
           .AddXhtmlMinification(options =>
           {
               options.IncludedPages = new List<IUrlMatcher>
               {
                    new WildcardUrlMatcher("/minifiers/x*ml-minifier"),
                    new ExactUrlMatcher("/contact")
               };

               XhtmlMinificationSettings settings = options.MinificationSettings;
               settings.RemoveRedundantAttributes = true;
               settings.RemoveHttpProtocolFromAttributes = true;
               settings.RemoveHttpsProtocolFromAttributes = true;

               options.CssMinifierFactory = new KristensenCssMinifierFactory();
               options.JsMinifierFactory = new CrockfordJsMinifierFactory();
           })
           .AddXmlMinification(options =>
           {
               XmlMinificationSettings settings = options.MinificationSettings;
               settings.CollapseTagsWithoutContent = true;
           })
           .AddHttpCompression(options =>
           {
               options.CompressorFactories = new List<ICompressorFactory>
               {
                    new GZipCompressorFactory(new GZipCompressionSettings
                    {
                        Level = CompressionLevel.Fastest
                    }),
                    new DeflateCompressorFactory(new DeflateCompressionSettings
                    {
                        Level = CompressionLevel.Fastest
                    })
               };
           });

        }
    }
}
