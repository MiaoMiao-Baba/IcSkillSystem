﻿using System;
using System.Collections.Generic;
using CabinIcarus.IcSkillSystem.Runtime.Buffs.Components;
using CabinIcarus.IcSkillSystem.Nodes.Runtime.SkillSystems.Buff;
using UnityEngine;
using XNode;
using XNodeEditor;
using Node = NPBehave.Node;

namespace CabinIcarus.IcSkillSystem.Nodes.Editor
{
    public abstract class ABuffNodeEditor:AQNameSelectEditor<ABuffNode,Node>
    {
        protected override Type GetBaseType()
        {
            return typeof(IBuffData);
        }
        
        protected override string GetAQNamePropertyName()
        {
            return "_buffAQName";
        }
        
        protected override void Init()
        {
            base.Init();
            
            UpdateDynamicPort();
        }
        
        protected override void DrawBody()
        {
            DrawSelectPop(new GUIContent("Buff: "));

            base.DrawBody();
        }
    }
    
    [CustomNodeEditor(typeof(AddOrRemoveBuffNode))]
    public class AddOrRemoveBuffNodeEditor:ABuffNodeEditor
    {
    }
    
    [CustomNodeEditor(typeof(HasBuffConditionNode))]
    public class HasBuffNodeNodeEditor:ABuffNodeEditor
    {
    }
}