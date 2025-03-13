using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScreenAnimation : MonoBehaviour
{
    private IEnumerator FadeInOutRoutine()
    {
        yield return new WaitForSeconds(0.25F);
        //fade in

        yield return new WaitForSeconds(1f);
        //fade out
        yield return new WaitForSeconds(1f);
        //reset
        SceneManager.LoadScene("sampleScene");
    }
}
