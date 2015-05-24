
using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnhancedRoadHeight
{
    public class ToolAnarchyMod : IUserMod
    {
        public string Name
        {
            get
            {
                return "Enhanced Road Heights";
            }
        }
        public string Description
        {
            get
            {
                return "Changes road heights from 12m to 3m";
            }
        }
    }
}
