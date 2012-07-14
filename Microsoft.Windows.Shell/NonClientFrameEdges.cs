/**************************************************************************\
    Copyright Microsoft Corporation. All Rights Reserved.
\**************************************************************************/

namespace Microsoft.Windows.Shell
{
    using System;

    [Flags]
    public enum NonClientFrameEdges
    {
        Bottom = 8,
        Left = 1,
        None = 0,
        Right = 4,
        Top = 2
    }
}