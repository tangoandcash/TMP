using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIPQuest_Filip_Wypych.Startup))]
namespace NIPQuest_Filip_Wypych
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
