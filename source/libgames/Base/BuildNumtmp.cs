using System;
using System.Text;

namespace GAME
{
    public static class GBuildNumber
    {
        public static uint GetBuildNumber()
        {
            return $WCDATE=%y%m%d$$WCREV$;
        }
    }
}