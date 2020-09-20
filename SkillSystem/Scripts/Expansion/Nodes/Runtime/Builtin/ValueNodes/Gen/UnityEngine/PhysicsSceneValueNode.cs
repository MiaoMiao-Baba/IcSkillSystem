using System;
using UnityEngine;
using CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/PhysicsModule/PhysicsScene Value")]
    public partial class PhysicsSceneValueNode:ValueNode<ValueInfo<UnityEngine.PhysicsScene>>
    {
        [SerializeField]
        private UnityEngine.PhysicsScene _value;
   
        private ValueInfo<UnityEngine.PhysicsScene> _variableValue;
   
        protected override ValueInfo<UnityEngine.PhysicsScene> GetTValue()
        {
            _variableValue.Value = _value;
            
            return _variableValue;
        }

        public override void OnStart()
        {
            base.OnStart();

            _variableValue = _value;
        }

        public override void OnStop()
        {
            base.OnStop();
            
            _variableValue.Release();

            _variableValue = null;
        }
    }
}