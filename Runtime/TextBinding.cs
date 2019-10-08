﻿using UnityEngine;
using UnityEngine.UI;

namespace Gameframe.Bindings
{
  public class TextBinding : BindingBehaviour
  {
    [SerializeField] 
    private Text text;

    [SerializeField] 
    private string format;
    
    protected override void SetupBindingTarget(Binding binding)
    {
      binding.Converter = FormatText;
      binding.SetTarget(text,"text", false);
    }

    private object FormatText(object sourceValue)
    {
      if (sourceValue == null)
      {
        return null;
      }
      return string.IsNullOrEmpty(format) ? sourceValue.ToString() : string.Format(format, sourceValue);
    }

    [ContextMenu("Refresh")]
    public override void Refresh()
    {
      base.Refresh();
    }
  }
}
