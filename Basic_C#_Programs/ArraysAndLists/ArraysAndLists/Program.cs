﻿using System;
using System.Collections.Generic;




    class Program
    {
    static void Main()
    {
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 1010, 2020 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 6, 2300 };

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("hello");
        stringList.Add("goodbye");

        Console.WriteLine(intList[0]);
        Console.WriteLine(stringList[0]);
        Console.ReadLine();

        

    }
    }

