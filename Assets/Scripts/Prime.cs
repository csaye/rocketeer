using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prime : MonoBehaviour
{

int current = 2;

List<int> primes = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        primes.Add(2);
    }

    // Update is called once per frame
    void Update()
    {

        current++;

        if (isPrime(current)) {
        primes.Add(current);
        Debug.Log(current);
        }
    }

    private bool isPrime(int num) {
        foreach(int prime in primes) {
            if (num % prime == 0) {
                return false;
            }
        }
        return true;
    }
}
