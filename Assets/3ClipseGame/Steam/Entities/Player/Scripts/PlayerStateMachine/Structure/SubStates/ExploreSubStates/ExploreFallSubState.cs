using _3ClipseGame.Steam.Entities.Player.Scripts.GlobalScripts;
using _3ClipseGame.Steam.Entities.Player.Scripts.PlayerStateMachine.Structure.States;
using UnityEngine;

namespace _3ClipseGame.Steam.Entities.Player.Scripts.PlayerStateMachine.Structure.SubStates.ExploreSubStates
{
    public class ExploreFallSubState : SubState
    {
        public ExploreFallSubState(PlayerStateMachine context, SubStateFactory factory) : base(context, factory) =>
            _factory = (ExploreSubStatesFactory) factory;
        
        private ExploreSubStatesFactory _factory;

        public override void OnStateEnter()
        {
            Context.PlayerGravity.RestartGravity();
            var lastMove = Context.PlayerMover.GetLastMove(MoveType.StateMove);
            lastMove.y = 0;
            Context.PlayerMover.ChangeMove(MoveType.StateMove,lastMove, true);
        }

        public override void OnStateUpdate(){}

        public override void OnStateExit(){}

        public override bool TrySwitchState(out State newState)
        {
            newState = null;

            if ((Context.PlayerController.collisionFlags & CollisionFlags.Below) != 0) newState = _factory.Idle();

                return newState != null;
        }
    }
}