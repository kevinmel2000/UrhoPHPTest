﻿using System;
using Urho;
using Urho.Gui;
using Urho.Shapes;

namespace Urho
{
    public static class UtilityFunctions
    {
        public static Sphere CreateSphereComponent(Node node)
        {
            return node.CreateComponent<Sphere>();
        }
    }
}