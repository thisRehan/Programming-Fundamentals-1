using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] array = new int[3, 2] {
         { 1,2},
         { 3,4 },
         { 5,6 },
       };
        int[,] array1 = new int[3, 2] { { 1,2 },{ 3,4},{5,6 } };
        Matrix object1 = new Matrix(array);
        Matrix object2 = new Matrix(array1);
    }
}
