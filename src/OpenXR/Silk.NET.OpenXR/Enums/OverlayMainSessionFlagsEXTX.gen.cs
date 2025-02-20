// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrOverlayMainSessionFlagsEXTX")]
    public enum OverlayMainSessionFlagsEXTX : int
    {
        [NativeName("Name", "XR_OVERLAY_MAIN_SESSION_ENABLED_COMPOSITION_LAYER_INFO_DEPTH_BIT_EXTX")]
        OverlayMainSessionEnabledCompositionLayerInfoDepthBitExtx = 1,
    }
}
