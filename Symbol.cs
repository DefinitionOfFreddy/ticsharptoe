using System;
using System.ComponentModel;

namespace TicSharpToe
{
    public enum Symbol
    {
        [Description(" ")]
        None,
        [Description("X")]
        Cross,
        [Description("O")]
        Circle
    }
}