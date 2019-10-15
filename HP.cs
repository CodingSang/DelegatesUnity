using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HP : MonoBehaviour
{
       public Text HpText;
    int hp = 10;

    // Start is called before the first frame update
  void Start()
    {
        Fish fish = GameObject.FindGameObjectWithTag("Fish").GetComponent<Fish>();
        fish.HpAddedListener(OnHit);
    }

    // Update is called once per frame
     public void OnHit()
    {
        hp = hp - 1;
        Debug.Log(hp);
        HpText.text = "HP : "+hp;
    }
}
