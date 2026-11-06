using UnityEngine;

namespace Patterns.Creational.Factory
{
    public class FruitType1 : MonoBehaviour, IFruit
    {
        public void Die()
        {
            Score.Instance.CurrentScore += 10;
            Destroy(gameObject);
        }
    }
}