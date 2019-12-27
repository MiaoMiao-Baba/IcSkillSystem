using System;

namespace CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils
{
    [Serializable]
    public abstract class AValueInfo
    {
        public abstract object GetValue();
    }
    
    [Serializable]
    public class ValueInfo<T>:AValueInfo
    {
        public T Value;
        
        public static implicit operator T(ValueInfo<T> valueInfo)
        {
            return valueInfo.Value;
        }

        public override object GetValue() => Value;
    }
}