using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinCollection : MonoBehaviour
{
    private string CoinCounterString;
    private int CoinCounterInt;

    [SerializeField] Text coinCounterText;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            CoinCounterInt += 1;

            CoinCounterString = CoinCounterInt.ToString();
            coinCounterText.text = "Coin Count: " + CoinCounterString;

        }
    }
}

