using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries) {
        long[] arr = new long[n];
        
        //for (int i=0; i<n; i++)
        //arr[i]=0;
        int tam= queries.Count();
        long mayor=0;
        for (int i=0;i<tam;i++)
        {
            //int ini=queries[i][0]-1;
            //int fin=queries[i][1]-1;
            //int cant=queries[i][2];
            //for (int j=ini;j<=fin;j++)
            for (int j=queries[i][0]-1;j<=queries[i][1]-1;j++)
            {
                 arr[j]=arr[j]+queries[i][2];
                 if (arr[j]>mayor)
                    mayor=arr[j];
            }
        }
        return mayor;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++) {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
