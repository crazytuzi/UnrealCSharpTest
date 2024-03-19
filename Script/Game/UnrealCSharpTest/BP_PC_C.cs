using System;
using Script.CoreUObject;

namespace Script.Game.UnitTest.Dynamic
{
    [Override]
    public partial class BP_PC_C
    {
        [Override]
        public virtual void Server_Test_Implementation(int Value = 0)
        {
            Console.WriteLine($"C# HasAuthority {HasAuthority()} GetLocalRole {GetLocalRole()} Value {Value}");
        }
    }
}