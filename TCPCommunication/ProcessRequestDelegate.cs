﻿// Decompiled with JetBrains decompiler
// Type: Novensys.eCard.SDK.TCPCommunication.ProcessRequestDelegate
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using Novensys.eCard.SDK.offline.ISO8583;

namespace Novensys.eCard.SDK.offline.TCPCommunication
{
  public delegate Iso8583Message ProcessRequestDelegate(Iso8583Message requestMsg);
}
