using UnityEngine;

public class LevelExit : MonoBehaviour
{
    public EndScreenAnimation winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"));
        {
            //TURNS PLAEY OFF
            other.gameObject.SetActive(false);
            winScreen.StartFade();
        }
    }
}
