using UnityEngine;

namespace Asteroids
{
    public class ShiftState : GroundedState
    {
        private bool crouchHeld;

        public ShiftState(Player character, StateMachine stateMachine, MoveTransform moveTransform) : base(character, stateMachine, moveTransform)
        {
        }

        public override void Enter()
        {
            base.Enter();
            speed = character.shiftSpeed;
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
            crouchHeld = Input.GetButton("Fire3");
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
            if (!crouchHeld)
            {
                stateMachine.ChangeState(character.standing);
            }
        }

        public override void PhysicsUpdate(float fixedDeltaTime)
        {
            base.PhysicsUpdate(fixedDeltaTime);
        }
    }
}
