using Cake.Core.IO;
using Cake.Core;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cake.Common;
using Cake.Common.IO;

public class LocalBuildContext : BuildContext
{
    public LocalBuildContext(ICakeContext context)
        : base(context)
    {
    }

    protected override string GetSolutionName()
    {
        return "EasyGISDesktop.sln";
    }
	
    protected override string GetSvnInfo(string path, string item, string defValue)
    {
        if (item == "last-changed-revision")
        {
            return DateTime.Now.ToString("yyyyMMdd");
        }

        return "https://github.com/katterfelto/XPTable";
    }
}
