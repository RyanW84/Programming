using System;

class Merge 
{
    public static int[] merge(int[] a1, int[] a2) 
    {
        // Write code here
        int[] a3 = new int [a1.Length + a2.Length];
        int a1Pointer=0;
        int a2Pointer=0;
        int a3Pointer=0;
            if(a1.Length == 0)
            {
                return a2;
            }
            else if (a2.Length ==0)
            {
                return a1;
            }
                while(a1Pointer<= a1.Length-1 && a2Pointer<= a2.Length-1)
                {
                    
                    if (a1[a1Pointer] < a2[a2Pointer])
                    {
                        a3[a3Pointer] = a1[a1Pointer];
                        a1Pointer++;
                        a3Pointer++;
                    }
                    else if (a1[a1Pointer] > a2[a2Pointer] )
                    {
                    a3[a3Pointer] = a2[a2Pointer];
                    a2Pointer++;
                    a3Pointer++;
                    }
                    else if(a1[a1Pointer] == a2[a2Pointer])
                    {
                      a3[a3Pointer] = a1[a1Pointer];
                      a3Pointer++;
                      a3[a3Pointer]=a2[a2Pointer];
                    a1Pointer++;
                    a2Pointer++;
                    a3Pointer++;  
                    }
                }
                if (a2Pointer<a2.Length)
                {
                for (; a2Pointer < a2.Length; a2Pointer++)
                {
                    a3[a3Pointer] = a2[a2Pointer];
                    a3Pointer++;
                }
                }
                else if (a1Pointer<a1.Length)
                {
                    for (; a1Pointer < a1.Length; a1Pointer++)
                {
                    a3[a3Pointer] = a1[a1Pointer];
                    a3Pointer++;
                }
                }
                
                return a3;
        }
}