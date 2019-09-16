//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月14日-19:19
//CabinIcarus.SkillSystem.Runtime

using CabinIcarus.SkillSystem.Runtime.Buffs.Systems.Interfaces;

namespace Cabin_Icarus.SkillSystem.Scripts.Runtime.Buffs.Systems
{
    public abstract class ABuffDestroySystem:IBuffDestroySystem
    {
        protected IBuffManagerMessageSystem MessageSystem;
        
        protected ABuffDestroySystem(IBuffManagerMessageSystem messageSystem)
        {
            MessageSystem = messageSystem;
        }

        public abstract void Destroy();
    }
}