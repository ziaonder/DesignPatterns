﻿using System;

public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }
    public override void Draw()
    {
        renderer.Render("Circle");
    }
}
