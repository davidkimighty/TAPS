using UnityEngine;

namespace TARS
{
    [CreateAssetMenu(menuName = "TAPS/ProceduralAnimation/Leg", fileName = "Leg")]
    public class LegPreset : ScriptableObject
    {
        public float WalkStepLength = 0.9f;
        public float RunStepLength = 3f;
        public float StepThreshold = 0.1f;
        public float StepHeight = 0.8f;
        public AnimationCurve StepHeightCurve;
        public AnimationCurve StepSpeedCurve;
        
        public float RayLength = 2.5f;
        public LayerMask GroundMask;
        public float FootHeightOffset = 0.1f;
        public float SwingFootAngle = 60f;
    }
}
