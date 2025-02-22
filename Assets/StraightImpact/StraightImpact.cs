using Game;
using Physics;
using UnityEngine;

namespace StraightImpact
{
    public class StraightImpact : MonoBehaviour
    {
        [SerializeField] private PhysicsSettings physicsSettings;
        [SerializeField] private GameObject ballPrefab;
        
        private PhysicsObject[] _table;
        private BilliardBall[] _balls;
        private GameObject[] _visualizations;
        private void Start()
        {
            _balls = new BilliardBall[2];
            _visualizations = new GameObject[2];
            for (int x = 0; x < 2; x++)
            {
                _balls[x] = new BilliardBall(1,transform.position + transform.right * (x % 2 == 0 ? 0.75f : -0.75f), System.Numerics.Vector3.Zero, physicsSettings.BallMass);
                _visualizations[x] = Instantiate(ballPrefab, _balls[x].Transform.UnityPosition, Quaternion.identity);
                _visualizations[x].transform.localScale = new Vector3(_balls[x].Diameter, _balls[x].Diameter, _balls[x].Diameter);
            }
        }

        private void Update()
        {
            for (int x = 0; x < _balls.Length; x++)
            {
                _visualizations[x].transform.position = _balls[x].Transform.UnityPosition;
            }
        }
    }
}
