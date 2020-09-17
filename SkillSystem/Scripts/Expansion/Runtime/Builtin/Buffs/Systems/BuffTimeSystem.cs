//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月23日-23:00
//CabinIcarus.IcSkillSystem.Expansion.Runtime

using CabinIcarus.IcSkillSystem.Expansion.Runtime.Buffs.Components;
using CabinIcarus.IcSkillSystem.Runtime.Buffs;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Components;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Systems.Interfaces;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Expansion.Runtime.Builtin.Buffs.Systems
{
    public class BuffTimeSystem<T>:IBuffUpdateSystem where T:struct,IBuffData,IBuffTimeDataComponent
    {
        private readonly IStructBuffManager  _buffManager;

        public BuffTimeSystem(IStructBuffManager  buffManager)
        {
            this._buffManager = buffManager;
        }
        public void Execute()
        {
            foreach (var entity in _buffManager.Entitys)
            {
                var buffs = _buffManager.GetBuffs<T>(entity);

                for (var i = 0; i < buffs.Count; i++)
                {
                    var buff = buffs[i];
                    
                    buff.Duration -= Time.deltaTime;
                    
                    if (buff.Duration <= 0)
                    {
                        _buffManager.RemoveBuff(entity, buff);
                    }
                }
            }
        }
    }
}