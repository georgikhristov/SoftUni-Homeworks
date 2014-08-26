using System;

class Formula1
{
    static void Main()
    {
        int[] n = new int[8];
        for (int j = 0; j < 8; j++)
        {
            n[j] = byte.Parse(Console.ReadLine());    
        }
        int length = 0;
        bool no = false;
        //0 = south, 1=west(from south), 2 = north, 3 = west (from north)
        byte direction = 0;
        byte i = 0;
        byte p = 0;
        if (n[0] % 2 == 1)
            no = true;
        else
        {
            switch (direction % 4)
            {
                case 0: //south
                    {
                        if (p == 7 && i == 7)
                        {
                            length++;
                            break;
                        }
                        if (((n[i] >> p) & 1) == 1)
                        {
                            if (((n[i - 1] >> (p + 1)) & 1) == 1)
                            {
                                no = true;
                                break;
                            }
                            else
                            {
                                p++;
                                direction++;
                                i--;
                                goto case 1;
                            }
                        }
                        else
                        {
                            if (i == 7)
                            {
                                if (((n[i] >> (p + 1)) & 1) == 1)
                                {
                                    no = true;
                                    break;
                                }
                                else
                                {
                                    p++;
                                    length++;
                                    direction++;
                                    goto case 1;
                                }
                            }
                            else
                            {
                                length++;
                                i++;
                                goto case 0;
                            }
                        }
                    }
                case 1: //west from south
                    {
                        if (p == 7 && i == 7)
                        {
                            length++;
                            break;
                        }
                        if (((n[i] >> p) & 1) == 1)
                        {
                            if (((n[i - 1] >> (p - 1)) & 1) == 1)
                            {
                                no = true;
                                break;
                            }
                            else
                            {
                                p--;
                                direction++;
                                i--;
                                goto case 2;
                            }
                        }
                        else
                        {
                            if (p == 7)
                            {
                                if (((n[i - 1] >> (p)) & 1) == 1)
                                {
                                    no = true;
                                    break;
                                }
                                else
                                {
                                    i--;
                                    length++;
                                    direction++;
                                    goto case 2;
                                }
                            }
                            else
                            {
                                length++;
                                p++;
                                goto case 1;
                            }
                        }
                    }
                case 2: //north
                    {
                        if (((n[i] >> p) & 1) == 1)
                        {
                            if (((n[i + 1] >> (p + 1)) & 1) == 1)
                            {
                                no = true;
                                break;
                            }
                            else
                            {
                                p++;
                                direction++;
                                i++;
                                goto case 3;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (((n[i] >> (p + 1)) & 1) == 1)
                                {
                                    no = true;
                                    break;
                                }
                                else
                                {
                                    p++;
                                    length++;
                                    direction++;
                                    goto case 3;
                                }
                            }
                            else
                            {
                                length++;
                                i--;
                                goto case 2;
                            }
                        }
                    }
                case 3: //west from north
                    {
                        if (((n[i] >> p) & 1) == 1)
                        {
                            if (((n[i + 1] >> (p - 1)) & 1) == 1)
                            {
                                no = true;
                                break;
                            }
                            else
                            {
                                p--;
                                direction++;
                                i++;
                                goto case 0;
                            }
                        }
                        else
                        {
                            if (p == 7)
                            {
                                if (((n[i + 1] >> (p)) & 1) == 1)
                                {
                                    no = true;
                                    break;
                                }
                                else
                                {
                                    i++;
                                    direction++;
                                    length++;
                                    goto case 0;
                                }
                            }
                            else
                            {
                                length++;
                                p++;
                                goto case 3;
                            }
                        }
                    }
                default:
                    break;
            }
        }

        if (no)
        {
            Console.WriteLine("No {0}", length); 
        }
        else
        {
            Console.WriteLine(length + " " + direction);
        }

    }
}