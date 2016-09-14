using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvxMusicStore.Startup))]
namespace MvxMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
