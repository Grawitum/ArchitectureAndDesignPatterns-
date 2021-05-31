using UnityEngine;

namespace Asteroids
{
    public class StandingState : GroundedState
    {
        private bool crouch;

        public StandingState(Player character, StateMachine stateMachine, MoveTransform moveTransform) : base(character, stateMachine, moveTransform)
        {
        }

        public override void Enter()
        {
            base.Enter();
            speed = character.speed;
            crouch = false;
        }

        public override void HandleInput()
        {
            base.HandleInput();
            crouch = Input.GetButtonDown("Fire3");
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            if (crouch)
            {
                stateMachine.ChangeState(character.shift);
            }
        }
    }
}
