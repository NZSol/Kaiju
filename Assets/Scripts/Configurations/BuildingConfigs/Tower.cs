using UnityEngine;
using Combat.AttackTypes;
using System.Collections;


namespace Combat.Tower
{
    [CreateAssetMenu(fileName = "Tower", menuName = "Scriptable Objects/Tower")]
    public class Tower : ScriptableObject
    {

        [SerializeField]
        public MeshFilter healthyMesh;
        [SerializeField]
        public Material healthyMat;

        [SerializeField]
        public MeshFilter dmgMesh;
        [SerializeField]
        public Material dmgMat;

        [SerializeField]
        public MeshFilter wreckMesh;
        [SerializeField]
        public Material wreckMat;

        [SerializeField]
        [Tooltip("Damage Type eg. Kinetic, Energy, etc.")]
        AttackElement element;

        [SerializeField]
        [Tooltip("Attack Pattern eg. Targeted, Splash, cluster")]
        AttackDistribution distribution;

        [SerializeField]
        [Tooltip("Effective Range")]
        AttackProximity proximity;




        //TODO: Make value modular based on research and upgrades
        (int, int) attackRange
        {
            get
            {
                switch (proximity)
                {
                    case AttackProximity.Short: return (0, 10);
                    case AttackProximity.Medium: return (8, 18);
                    case AttackProximity.Far: return (15, 30);
                }
                return (0, 0);
            }
        }




        //For display purpose only. Remove when done with
        [SerializeField]
        int rangeFloor
        {
            get { return attackRange.Item1; }
        }
        [SerializeField]
        int rangeMax
        {
            get { return attackRange.Item2; }
        }
    }
}
