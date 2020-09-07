﻿using CabinIcarus.IcSkillSystem.xNode_Group;

namespace CabinIcarus.IcSkillSystem
{
    public interface IIcSkillSystemNode
    {
        IcSkillGraph SkillGraph { get; set; }

        void OnInit();

        void OnSetOwner();
        
        void OnStart();
        
        void OnStop();
    }
}