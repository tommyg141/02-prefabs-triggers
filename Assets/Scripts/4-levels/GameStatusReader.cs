using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component reades the "playerScore" static variable from the GameStatus static class into this object's number field.
 */
[RequireComponent(typeof(NumberField))]
public class GameStatusReader : MonoBehaviour {
    void Start() {
        GetComponent<NumberField>().SetNumber(GameStatus.playerScore);
    }
}
