


















// Generated on 06/04/2015 18:44:15
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class CharacterDeletionErrorMessage : Message
{

public const ushort Id = 166;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public CharacterDeletionErrorMessage()
{
}

public CharacterDeletionErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataInput reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}