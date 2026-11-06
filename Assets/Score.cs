using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    public int CurrentScore { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }


}
