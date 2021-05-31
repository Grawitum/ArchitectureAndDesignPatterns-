using UnityEngine;

namespace Asteroids
{
    public class GroundedState : State
    {
        protected float speed;

        private float horizontalInput;
        private float verticalInput;
        private MoveTransform _moveTransform;

        public GroundedState(Player character, StateMachine stateMachine, MoveTransform moveTransform) : base(character, stateMachine)
        {
            _moveTransform = moveTransform;
        }

        public override void Enter()
        {
            base.Enter();
            horizontalInput = verticalInput = 0.0f;
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
        }

        public override void PhysicsUpdate(float fixedDeltaTime)
        {
            base.PhysicsUpdate(fixedDeltaTime);
            _moveTransform.Move(horizontalInput * speed, verticalInput * speed, fixedDeltaTime);
        }
    }
}