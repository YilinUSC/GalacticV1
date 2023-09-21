using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyNumber : MonoBehaviour
{
    //public GameObject FloatingTextPrefab;
    public TextMeshPro textnumber;
    public int number;
    
    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(0, 9);

    }

    // Update is called once per frame
    void Update()
    {
        
        textnumber.text = number.ToString();
        

        
    }
    
}
