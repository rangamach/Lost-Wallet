using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Light[] lights;
    private Light closest_light;

    private float max_x = 7;
    private float min_x = -7;
    private float max_y = 4;
    private float min_y = -4;

    private bool foundlight = false;
    [SerializeField] Canvas foundText;

    private void Awake()
    {
        transform.position = new Vector3(Random.Range(min_x, max_x), Random.Range(min_y, max_y), 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.SetActive(false);
            foundText.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (!foundlight)
        {
            closest_light = FindClosestLight();
            foundlight = true;
        }
        EnableCollider(closest_light);
    }

    private Light FindClosestLight()
    {
        float closest_light_distance = Mathf.Infinity;
        foreach(Light light in lights)
        {
            float distance = Vector2.Distance(transform.position, light.transform.position);
            if(distance < closest_light_distance)
            {
                closest_light_distance = distance;
                closest_light = light;
            }
        }
        return closest_light;
    }
    
    private void EnableCollider(Light closest_light)
    {
        if (!closest_light.gameObject.activeInHierarchy)
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
