using UnityEngine;

namespace Patterns.Creational.Factory
{
    public enum FruitType
    {
        Fruit1,
        Fruit2
    }

    public class FruitFactory : MonoBehaviour
    {
        [SerializeField] private GameObject _fruitType1;
        [SerializeField] private GameObject _fruitType2;

        public IFruit CreateFruit(FruitType type, Vector3 position)
        {
            GameObject prefab = type switch
            {
                FruitType.Fruit1 => _fruitType1,
                FruitType.Fruit2 => _fruitType2,
                _ => throw new System.ArgumentException($"Unknown type: {type}")
            };

            var instance = Instantiate(prefab, position, Quaternion.identity);
            return instance.GetComponent<IFruit>();
        }
    }
}