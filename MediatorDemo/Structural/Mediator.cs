﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Structural
{
  public abstract class Mediator
  {
    public abstract void Send(string message, Colleague colleague);
  }
}
