using System.ComponentModel;

namespace TicSharpToe
{
    public enum Position
    {
        NONE,
        [Description("NW")]
        NORTHWEST,
        [Description("N")]
        NORTH,
        [Description("NE")]
        NORTHEST,
        [Description("W")]
        WEST,
        [Description("C")]
        CENTER,
        [Description("E")]
        EST,
        [Description("SW")]
        SOUTHWEST,
        [Description("S")]
        SOUTH,
        [Description("SE")]
        SOUTHEST
    }
}