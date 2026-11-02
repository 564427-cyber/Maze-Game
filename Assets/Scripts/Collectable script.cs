using UnityEngine;

public class Collectablescript : MonoBehaviour
{

    public GameObject ui;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Rigidbody2D>())
        {
            Destroy(gameObject);
        }

        ui.SetActive(true);

        Time.timeScale = 0;
    }
}
