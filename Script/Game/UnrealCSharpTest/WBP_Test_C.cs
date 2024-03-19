using Script.CoreUObject;
using Script.Engine;
using Script.Game.UnitTest.Dynamic;

namespace Script.Game.FirstPerson.UI
{
    [Override]
    public partial class WBP_Test_C
    {
        [Override]
        public virtual void Server()
        {
            var BP_PC = UGameplayStatics.GetPlayerController(this, 0) as BP_PC_C;
            
            BP_PC.Server_Test(250);
        }
    }
}