using System;

namespace WinFormsApp1
{
    [Flags]
    public enum MaterialStatus
    {
        None = 0,
        Expected = 1,
        InStock = 2,
        InProduction = 4,
        Defective = 8
    }
}