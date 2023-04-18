using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
  [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
  

    
    private void OnTriggerEnter2D(Collider2D other) {
   
         if (other.tag == triggeringTag && enabled) {
            var temp = other.transform.GetComponent<Transform>();
        
            Destroy(this.gameObject);
        
            
         
            }  
          
    }
    

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
