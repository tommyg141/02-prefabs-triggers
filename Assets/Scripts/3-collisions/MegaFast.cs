using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaFast : MonoBehaviour
{
      [Tooltip("fast ship ")] [SerializeField] float duration;
      [SerializeField] float dublespeed;
    float originalspeed=5f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("fast triggered by player");
        
            var mover = other.GetComponent<InputMover>();
            if (mover) {
                mover.StartCoroutine(MegaSpeedTemporarily(mover));        // co-routines
                    // NOTE: If you just call "StartCoroutine", then it will not work, 
                    //       since the present object is destroyed!
                // ShieldTemporarily(destroyComponent);                                      // async-await
                Destroy(gameObject);  // Destroy the shield itself - prevent double-use
            }
        }
         else {
             Debug.Log("MegaSpeed tach "+other.name);
         }
    }

    private IEnumerator MegaSpeedTemporarily(InputMover mover) {   // co-routines
    // private async void ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {      // async-await
       //how to cahnge the speed of the player 
        float defaultSpeed = mover.GetSpeed();
        mover.SetSpeed(dublespeed); 
        
        for (float i = duration; i > 0; i--) {
            Debug.Log("MegaSpeed: " + i + " seconds remaining!");
            yield return new WaitForSeconds(1);       // co-routines
            // await Task.Delay(1000);                // async-await
        }
        mover.SetSpeed(defaultSpeed);
        Debug.Log("back to normal gone!");
    }
}
