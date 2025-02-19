﻿// Decompiled with JetBrains decompiler
// Type: Novensys.eCard.SDK.ASN1.EHCDG7.DG7
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using Novensys.ASN1.Type;
using System;
using System.ComponentModel;

namespace Novensys.eCard.SDK.offline.ASN1.EHCDG7
{
  [Serializable]
  public class DG7 : Asn1SequenceType
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string TypeName
    {
      get
      {
        return "DG7";
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ReferenceTypeName
    {
      get
      {
        return base.TypeName;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override void __initialize()
    {
      this.__initializeComponents(0);
    }

    public void SetValue(DG7 typeInstance)
    {
      this.__setTypeValue((Asn1Type) typeInstance);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override Asn1Type __instantiateTypeByIndex(int index)
    {
      return (Asn1Type) null;
    }

    public override bool Equals(object anObject)
    {
      if (!(anObject is DG7))
        return false;
      else
        return base.Equals(anObject);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
