using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public int schore;
    [SerializeField] TextAlignment schoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            schore++;
        }
    }
     void Update()
    {
        schoreText.text = schore.ToString();
    }
}
