using System.ComponentModel;

namespace Betman.Client
{
    public enum eMatchType
    {
        [Description("일반")]
        Normal,
        [Description("H")]
        Handicap,
        [Description("U/O")]
        UnderOver,
    }
}
