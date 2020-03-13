using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Storage : MonoBehaviour
{
    public float score = 0, money = 1000, health = 100;
    public Text scoreT, moneyT, healthT;
    public GameObject[] grounded; //массив с префабами башен против наземных
    public GameObject[] flying; //массив с префабами башен против воздушных
}
