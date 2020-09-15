//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月21日-23:01
//Assembly-CSharp

using System.Collections.Generic;
using CabinIcarus.IcSkillSystem.Nodes.Runtime.Attributes;
using NPBehave;

namespace CabinIcarus.IcSkillSystem.Nodes.Runtime.Composite
{
    public abstract class ACompositeNode<T>:ANPBehaveNode<T> where T : NPBehave.Composite
    {
        [Input(typeConstraint = TypeConstraint.Inherited)]
        [PortTooltip("节点,可多个")]
        private Node _nodes;
        
        protected override T CreateOutValue()
        {
            var nodes = GetInputValues(nameof(_nodes), _nodes);
            
            if (nodes == null) 
                return null;
            
            return GetNode(nodes);
        }

        protected abstract T GetNode(IEnumerable<Node> inputNodes);
    }
}