using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] blacks;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            foreach (SpriteRenderer i in blacks)
            {
                i.gameObject.SetActive(false);
            }
            this.gameObject.SetActive(false);
        }
    }
}
