using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 newPos = new Vector2(1, 1);

    private void Start()
    {
        Application.targetFrameRate = 6;
    }
    // Update is called once per frame
    void Update()
    {
        newPos = new Vector2(Input.GetAxisRaw("Horizontal") + this.transform.position.x,
            Input.GetAxisRaw("Vertical") + this.transform.position.y);

        if(newPos.x < 1f || newPos.x > 10f || newPos.y < 1f || newPos.y > 10f)
        {
            Die();
            Debug.Log("You Died");
        }

        newPos = new Vector2(Mathf.Clamp(newPos.x, 1f, 10f),
            Mathf.Clamp(newPos.y, 1f, 10f));

        transform.position = newPos;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //collision.Die();
        
    }

    void Die()
    {
        Score.Instance.CurrentScore = 0;
    }
}
