//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//2019年12月15日-11:28
//CabinIcarus.IcSkillSystem.xNodeIc.Base

using NPBehave;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Nodes.Runtime.Tasks.GroupValueNode
{
    [CreateNodeMenu("CabinIcarus/IcSkillSystem/Behave Nodes/Task/Graph variable/Set Or Add")]
    public class SetOrAddGraphVariableNode:AActionNode
    {
        [SerializeField,Input(ShowBackingValue.Always,ConnectionType.Override,TypeConstraint.Strict)]
        private string _key;

        [Input(ShowBackingValue.Never,ConnectionType.Override)]
        private object _newValue;
        
        protected override Action CreateOutValue()
        {
            return new Action(_setValue);
        }

        private void _setValue()
        {
            var value = GetInputValue(nameof(_newValue), _newValue);
            
            SkillGraph.SetOrAddVariable(GetInputValue(nameof(_key),_key),value);
        }
    }
}