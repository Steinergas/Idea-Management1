﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Idea_Management.Startup))]
namespace Idea_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
