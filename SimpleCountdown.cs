using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleCountdown : MonoBehaviour
{
    public Text text;

    public int max = 10;
    public int count;

    private void Start()
    {
        resetCountDown();
    }

    void Update()
    {
        text.text = count.ToString();
    }

    public void resetCountDown()
    {
        count = max;
    }

    public void beginCountdown()
    {
        count = max;

        CancelInvoke("countDownByOne");
        InvokeRepeating("countDownByOne", 0, 1);
    }

    public void forceToNum(int num)
    {
        count = num;

        CancelInvoke("countDownByOne");
        InvokeRepeating("countDownByOne", 0, 1);
    }

    public void forceToZero()
    {
        count = 0;

        CancelInvoke("countDownByOne");
    }

    void countDownByOne()
    {
        if (count > 0)
        {
            count--;
        }
        else
        {
            CancelInvoke("countDownByOne");
        }
    }
}
