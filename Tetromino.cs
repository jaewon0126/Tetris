using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Tetris
{
    internal class Tetromino
    {
        Hashtable hashTetromino = new Hashtable();

        byte[,] o = new byte[2, 2]
        {
                { 1, 1 },
                { 1, 1 }
        };
        byte[,] i1 = new byte[4, 1]
        {
                { 1 },
                { 1 },
                { 1 },
                { 1 }
        };
        byte[,] i2 = new byte[1, 4]
        {
                { 1,1,1,1 }
        };
        byte[,] s1 = new byte[2, 3]
        {
                { 0, 1, 1 },
                { 1, 1, 0 }
        };
        byte[,] s2 = new byte[3, 2]
        {
                { 1, 0 },
                { 1, 1 },
                { 0, 1 }
        };
        byte[,] z1 = new byte[2, 3]
        {
                { 1, 1, 0 },
                { 0, 1, 1 }
        };
        byte[,] z2 = new byte[3, 2]
        {
                { 0, 1 },
                { 1, 1 },
                { 1, 0 }
        };
        byte[,] l1 = new byte[3, 2]
        {
                { 1, 0 },
                { 1, 0 },
                { 1, 1 }
        };
        byte[,] l2 = new byte[2, 3]
        {
                { 0, 0, 1 },
                { 1, 1, 1 }
        };
        byte[,] l3 = new byte[3, 2]
        {
                { 1, 1 },
                { 0, 1 },
                { 0, 1 }
        };
        byte[,] l4 = new byte[2, 3]
        {
                { 1, 0, 0 },
                { 1, 1, 1 }
        };
        byte[,] j1 = new byte[3, 2]
        {
                { 0, 1 },
                { 0, 1 },
                { 1, 1 }
        };
        byte[,] j2 = new byte[2, 3]
        {
                { 1, 1, 1 },
                { 0, 0, 1 }
        };
        byte[,] j3 = new byte[3, 2]
        {
                { 1, 1 },
                { 1, 0 },
                { 1, 0 }
        };
        byte[,] j4 = new byte[2, 3]
        {
                { 1, 0, 0 },
                { 1, 1, 1 }
        };
        byte[,] t1 = new byte[2, 3]
        {
                { 1, 1, 1 },
                { 0, 1, 0 }
        };
        byte[,] t2 = new byte[3, 2]
        {
                { 1, 0 },
                {1, 1 },
                {1,0 }
        };
        byte[,] t3 = new byte[2, 3]
        {
                { 0, 1, 0 },
                { 1, 1, 1 }
        };
        byte[,] t4 = new byte[3, 2]
        {
                { 0, 1 },
                { 1, 1 },
                { 0, 1 }
        };
    }
}
