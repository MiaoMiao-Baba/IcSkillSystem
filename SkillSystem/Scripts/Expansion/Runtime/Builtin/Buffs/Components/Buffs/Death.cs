//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月28日-15:14
//Assembly-CSharp

using CabinIcarus.IcSkillSystem.Runtime.Buffs.Components;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Buffs.Components
{
    public struct DeathStruct:IBuffData,IMakerEntity
    {
        public ECSResources<IIcSkSEntity> Entity { get; set; }
    }
}