using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public abstract class State
    {
        protected Player character;
        protected StateMachine stateMachine;

        protected State(Player character, StateMachine stateMachine)
        {
            this.character = character;
            this.stateMachine = stateMachine;
        }

        public virtual void Enter()
        {
            //DisplayOnUI(UIManager.Alignment.Left);
        }

        public virtual void HandleInput()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate(float fixedDeltaTime)
        {

        }

        public virtual void Exit()
        {

        }

        //protected void DisplayOnUI(UIManager.Alignment alignment)
        //{
        //    //UIManager.Instance.Display(this, alignment);
        //}
    }
}
