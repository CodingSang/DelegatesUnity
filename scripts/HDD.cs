using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fish fish = GameObject.FindGameObjectWithTag("Fish").GetComponent<Fish>();
        fish.AddPointAddedListener(OnPrint);
    }

    // Update is called once per frame
     public void OnPrint(int score)
    {
        print("point = "+score);
    }
}
