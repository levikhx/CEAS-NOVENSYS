﻿// Decompiled with JetBrains decompiler
// Type: Novensys.eCard.SDK.Entities.IdentificatorDrepturi
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using System;

namespace Novensys.eCard.SDK.offline.Entities
{
  [Serializable]
  public class IdentificatorDrepturi
  {
    public string NumarContract { get; set; }

    public DateTime DataContract { get; set; }

    public string CasaAsigurare { get; set; }

    public string TipFurnizor { get; set; }

    public string CUI { get; set; }
  }
}
