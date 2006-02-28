//
//
// Copyright 2005-2006 The Apache Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections;
using System.IO;

using OpenWire.Client;
using OpenWire.Client.Commands;
using OpenWire.Client.Core;
using OpenWire.Client.IO;

namespace OpenWire.Client.IO
{
  //
  //  Marshalling code for Open Wire Format for LocalTransactionId
  //
  //
  //  NOTE!: This file is autogenerated - do not modify!
  //        if you need to make a change, please see the Groovy scripts in the
  //        activemq-core module
  //
  public class LocalTransactionIdMarshaller : TransactionIdMarshaller
  {


    public override DataStructure CreateObject() 
    {
        return new LocalTransactionId();
    }

    public override byte GetDataStructureType() 
    {
        return LocalTransactionId.ID_LocalTransactionId;
    }

    // 
    // Un-marshal an object instance from the data input stream
    // 
    public override void Unmarshal(OpenWireFormat wireFormat, Object o, BinaryReader dataIn, BooleanStream bs) 
    {
        base.Unmarshal(wireFormat, o, dataIn, bs);

        LocalTransactionId info = (LocalTransactionId)o;
        info.Value = UnmarshalLong(wireFormat, dataIn, bs);
        info.ConnectionId = (ConnectionId) UnmarshalCachedObject(wireFormat, dataIn, bs);

    }


    //
    // Write the booleans that this object uses to a BooleanStream
    //
    public override int Marshal1(OpenWireFormat wireFormat, Object o, BooleanStream bs) {
        LocalTransactionId info = (LocalTransactionId)o;

        int rc = base.Marshal1(wireFormat, info, bs);
    rc += Marshal1Long(wireFormat, info.Value, bs);
    rc += Marshal1CachedObject(wireFormat, info.ConnectionId, bs);

        return rc + 0;
    }

    // 
    // Write a object instance to data output stream
    //
    public override void Marshal2(OpenWireFormat wireFormat, Object o, BinaryWriter dataOut, BooleanStream bs) {
        base.Marshal2(wireFormat, o, dataOut, bs);

        LocalTransactionId info = (LocalTransactionId)o;
    Marshal2Long(wireFormat, info.Value, dataOut, bs);
    Marshal2CachedObject(wireFormat, info.ConnectionId, dataOut, bs);

    }
  }
}
