﻿using System;

public abstract class SupportHandler
{
    protected SupportHandler? nextHandler;

    public void SetNext(SupportHandler nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public abstract void HandleRequest(string request);
}
