using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] int ticks = 0;
    [SerializeField] Text textField;

    void Start()
    {
        Tick();
    }

    async void Tick() {
        while (true) {
            ticks++;
            textField.text = ticks.ToString();
            await Task.Delay(1000);  // wait 1 second
        }
    }
}
