using System.Web.Optimization;

namespace GoCompark
{
    public static class BundleConfig
    {
        public static void Register(BundleCollection bundleCollection)
        {
            bundleCollection.Add(new Bundle("~/Scripts/Home.js"));
        }
    }
}