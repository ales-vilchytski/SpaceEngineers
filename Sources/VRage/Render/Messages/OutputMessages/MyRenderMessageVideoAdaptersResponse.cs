﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRageRender
{
    public class MyRenderMessageVideoAdaptersResponse : MyRenderMessageBase
    {
        public MyAdapterInfo[] Adapters;

        public override MyRenderMessageType MessageClass { get { return MyRenderMessageType.StateChangeOnce; } }
        public override MyRenderMessageEnum MessageType { get { return MyRenderMessageEnum.VideoAdaptersResponse; } }
    }
}
