﻿using VRageRender;

namespace VRageRender
{
    public class MyRenderDebugOverrides
    {
        public bool Lighting = true;
        public bool Sun = true;
        public bool AdditionalSuns = true;
        public bool PointLights = true;
        public bool SpotLights = true;
        public bool Fog = true;

        public bool Transparent = true;
        public bool OIT = true;
        public bool BillboardsDynamic = true;
        public bool BillboardsStatic = true;
        public bool GPUParticles = true;
        public bool Atmosphere = true;
        public bool Clouds = true;

        public bool Postprocessing = true;
        public bool SSAO = true;
        public bool Bloom = true;
        public bool Fxaa = true;
        public bool Tonemapping = true;
        public bool Contrast = true;

        public bool Pause = false;

        public MyRenderDebugOverrides Clone()
        {
            return (MyRenderDebugOverrides)MemberwiseClone();
        }
    }

    public class MyRenderMessageUpdateDebugOverrides : MyRenderMessageBase
    {
        public MyRenderDebugOverrides Overrides;

        public override MyRenderMessageType MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        public override MyRenderMessageEnum MessageType { get { return MyRenderMessageEnum.UpdateDebugOverrides; } }
    }
}
