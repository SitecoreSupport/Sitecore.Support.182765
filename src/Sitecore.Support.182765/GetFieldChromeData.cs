using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sitecore.Data.Fields;
using Sitecore.Pipelines.GetChromeData;

namespace Sitecore.Support.Pipelines.GetChromeData
{
    public class GetFieldChromeData : Sitecore.Pipelines.GetChromeData.GetFieldChromeData
    {
        public override void Process(GetChromeDataArgs args)
        {
            base.Process(args);
            /* ALEX20170907 Calling back the same IF checking and value assignment for DisplayName as base class
               The fix is only to modify the quote replacement when assigning the following:
               args.ChromeData.DisplayName = HttpUtility.HtmlEncode(argument.DisplayName);
             */
            if ("field".Equals(args.ChromeType, StringComparison.OrdinalIgnoreCase))
            {
                args.ChromeData.DisplayName = args.ChromeData.DisplayName.Replace("&quot;", "\"");
            }
        }
    }
}

