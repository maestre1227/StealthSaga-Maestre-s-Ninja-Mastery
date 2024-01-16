using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectDagger : MonoBehaviour
{
    private int dagger = 0;
    [SerializeField] private Text daggerText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dagger"))
        {
            Destroy(collision.gameObject);
            dagger++;
            daggerText.text = "Daggers: " + dagger;
        }
    }
}
