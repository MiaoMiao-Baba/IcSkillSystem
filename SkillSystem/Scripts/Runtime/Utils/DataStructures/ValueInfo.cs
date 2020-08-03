using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CabinIcarus.IcSkillSystem.xNodeIc.Editor")]
namespace CabinIcarus.IcSkillSystem.SkillSystem.Runtime.Utils
{
    public abstract class AValueInfo
    {
        public object GetValue()
        {
            return ObjValue;
        }

        internal abstract void SetValue(object value);

        public void SetValue(AValueInfo value)
        {
            UpdateValue(value);
        }

        protected abstract void UpdateValue(AValueInfo value);
        
        protected abstract object ObjValue { get; }

        public abstract Type ValueType { get; }
    }
    
    [Serializable]
    public class ValueInfo<T>:AValueInfo
    {
        public T Value;
        
        public static implicit operator T(ValueInfo<T> valueInfo)
        {
            return valueInfo.Value;
        }

        public static implicit operator ValueInfo<T>(T value)
        {
            return new ValueInfo<T> {Value = value};
        }

        internal override void SetValue(object value)
        {
            Value = (T) value;
        }

        protected override void UpdateValue(AValueInfo value)
        {
            if (value is ValueInfo<T> valueInfo)
            {
                Value = valueInfo.Value;
            }
        }

        protected override object ObjValue => Value;
        
        public override Type ValueType => Value?.GetType();

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}