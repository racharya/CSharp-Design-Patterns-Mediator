﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Structural
{
  public abstract class Colleague
  {
    protected Mediator mediator;

    public Colleague(Mediator mediator)
    {
      this.mediator = mediator;
    }

    public virtual void Send(string message)
    {
      this.mediator.Send(message, this);
    }

    public abstract void HandleNotification(string message);
  }
}
