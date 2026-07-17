using System.Linq;
using Cake.Common.Diagnostics;
using Cake.Common.IO;
using Cake.Common.Tools.NuGet;
using Cake.Common.Tools.NuGet.Delete;
using Cake.Common.Tools.NuGet.List;
using Cake.Frosting;

[TaskName("Clean")]
public sealed class CleanTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.CleanDirectory("../EGIS.Controls/bin");
        context.CleanDirectory("../EGIS.Projections/bin");
        context.CleanDirectory("../EGIS.ShapeFileLib/bin");
    }
}