using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolenler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BolenleriBul(22, 42);
    }

    void BolenleriBul(int ilksayi, int ikincisayi)
    {
        string ikiyebolenler = "";
        string ucebolenler = "";
        string dordebolenler = "";
        string besebolenler = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 2 == 0)
            {
                ikiyebolenler += " " + i;
            }
            if (i % 3 == 0)
            {
                ucebolenler += " " + i;
            }
            if (i % 4 == 0)
            {
                dordebolenler += " " + i;
            }
            if (i % 5 == 0)
            {
                besebolenler += " " + i;
            }
        }
        Debug.Log("ikiye b�lenler : " + ikiyebolenler);
        Debug.Log("uce b�lenler : " + ucebolenler);
        Debug.Log("dorde b�lenler : " + dordebolenler);
        Debug.Log("bese b�lenler : " + besebolenler);
    }
}
