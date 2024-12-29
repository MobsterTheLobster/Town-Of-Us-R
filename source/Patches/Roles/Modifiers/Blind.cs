namespace TownOfUs.Roles.Modifiers
{
    public class Blind : Modifier
    {
        public Blind(PlayerControl player) : base(player)
        {
            Name = "Blind";
            TaskText = () => "y";
            Color = Patches.Colors.Blind;
            ModifierType = ModifierEnum.Blind;
        }
    }
}