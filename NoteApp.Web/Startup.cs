using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoteApp.Web.Startup))]
namespace NoteApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
