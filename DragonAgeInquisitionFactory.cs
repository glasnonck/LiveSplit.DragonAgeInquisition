using System.Reflection;
using LiveSplit.DragonAgeInquisition;
using LiveSplit.UI.Components;
using System;
using LiveSplit.Model;

[assembly: ComponentFactory(typeof(DragonAgeInquisitionFactory))]

namespace LiveSplit.DragonAgeInquisition
{
    class DragonAgeInquisitionFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "DragonAgeInquisition"; }
        }

        public string Description
        {
            get { return "Automates load removal for Dragon Age Inquisition."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new DragonAgeInquisitionComponent(state);
        }

        public string UpdateName
        {
            get { return this.ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/glasnonck/LiveSplit.DragonAgeInquisition/master/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.DragonAgeInquisition.xml"; }
        }
    }
}
