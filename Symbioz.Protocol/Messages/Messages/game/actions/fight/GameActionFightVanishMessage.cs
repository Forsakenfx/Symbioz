


















// Generated on 06/04/2015 18:44:09
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameActionFightVanishMessage : AbstractGameActionMessage
{

public const ushort Id = 6217;
public override ushort MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameActionFightVanishMessage()
{
}

public GameActionFightVanishMessage(ushort actionId, int sourceId, int targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            

}


}


}