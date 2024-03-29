using UnityEngine;

namespace _3ClipseGame.Steam.GameCore.GlobalScripts.EntityScripts.CharacterMover
{
    public class NoCamRotationMove : Move
    {
        public NoCamRotationMove(MoveType moveType, Vector3 inputVector, Transform mainCameraTransform) : base(moveType, inputVector, mainCameraTransform){}

        public override Vector3 GetRotatedVector() => RawVector;
    }
}
