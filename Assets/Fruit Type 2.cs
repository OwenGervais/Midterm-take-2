using UnityEngine;

namespace Patterns.Creational.Factory
{
    public class FruitType2 : MonoBehaviour, IFruit
    {
        public void Die()
        {
            Score.Instance.CurrentScore += 20;
            Destroy(gameObject);
        }
    }
}