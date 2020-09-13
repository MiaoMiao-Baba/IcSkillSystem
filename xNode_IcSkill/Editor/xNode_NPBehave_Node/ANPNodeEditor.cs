﻿using System;
using CabinIcarus.IcSkillSystem.Nodes.Runtime;
using UnityEngine;
using XNodeEditor;

namespace CabinIcarus.IcSkillSystem.Nodes.Editor
{
    public abstract class ANPNodeEditor<T,AT>:BaseNodeEditor where T : ANPNode<AT>
    {
        protected T TNode;

        protected bool Error;
        protected bool Warning;

        public void _check()
        {
            try
            {
                if (TNode == null)
                    TNode = (T) target;

            }
#pragma warning disable 168
            catch (Exception e)
#pragma warning restore 168
            {
                Debug.LogError(target);
            }           
        }

        public override Color GetTint()
        {
            if (Error)
            {
                return new Color(205 / 255f,20 / 255f,25 / 255f);
            }

            if (Warning)
            {
                return Color.yellow;
            }

            return base.GetTint();
        }

        public sealed override void OnCreate()
        {
            base.OnCreate();
            
            _check();

            On_Create();
        }

        protected virtual void On_Create()
        {
            
        }

        public sealed override void OnInit()
        {
            Init();
        }

        protected virtual void Init()
        {
        }

        public sealed override void OnBodyGUI()
        {
            serializedObject.Update();
            {
                _reSetColor();
                ColorCheck();
                {
                    DrawBody();
                }
            }
            serializedObject.ApplyModifiedProperties();
        }

        protected virtual void DrawBody()
        {
            base.OnBodyGUI();
        }

        protected abstract void ColorCheck();

        private void _reSetColor()
        {
            Error = false;
            Warning = false;
        }
    }
}