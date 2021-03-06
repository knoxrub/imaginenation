using Server.Spells.Sixth;

namespace Server.Items
{
    public class DispelWand : BaseWand
    {
        [Constructable]
        public DispelWand(): base(7)
        {
            ItemID = 0xdf2;
            Name = "Dispel";
        }

        public DispelWand(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void OnWandUse(Mobile from)
        {
            Cast(new DispelSpell(from, this));
        }
    }
}