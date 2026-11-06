using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Input.GetAxisRaw("Horizontal");
        Input.GetAxisRaw("Vertical");

        this.transform.position = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void Die()
    {
        Score.Instance.CurrentScore = 0;
    }
}
