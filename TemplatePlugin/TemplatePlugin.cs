/*
 * 
 * Welcome to this template plugin.
 * Level: All Levels
 * Purpose: To get a working model for new plugins to be built off.  This plugin will
 * compile immediately, all you have to do is rename TemplatePlugin to reflect 
 * the purpose of the plugin.
 * 
 * You may need to delete the references to TerrariaServer and TShockAPI.  They 
 * could be pointing to my current folder.  Just remove them and then right-click the
 * references folder, go to browse go to the dll folder, and select both.
 * 
 */

using System;
using Terraria;

namespace TemplatePlugin
{
    [APIVersion(1, 11)]
    public class TemplatePlugin : TerrariaPlugin
    {
        public override Version Version
        {
            get { return new Version("Whatever version your plugin is"); }
        }

        public override string Name
        {
            get { return "This should be the name of your plugin"; }
        }

        public override string Author
        {
            get { return "Who are you?"; }
        }

        public override string Description
        {
            get { return "This should tell someone what your plugin does."; }
        }

        public TemplatePlugin(Main game)
            : base(game)
        {
        }

        public override void Initialize()
        {
        }
    }
}
