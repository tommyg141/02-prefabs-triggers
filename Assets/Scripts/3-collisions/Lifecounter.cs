using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecounter : MonoBehaviour
{
[SerializeField] int life= 3;
  public void Damage(){

 
    life--;
    if(life<1){
        Debug.Log("Game over!");
        Destroy(this.gameObject);
    }
  }
}
