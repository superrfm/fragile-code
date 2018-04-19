using System;
using System.Collections;

namespace fragile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running task 1 - compare bTrees.");
            var comparer = new BTNComparer();
            comparer.run();

            Console.ReadLine();
        }

    }

    class BTN
    {
        public int val;
        public BTN left;
        public BTN right;

        public override string ToString()
        {
            return string.Concat(val.ToString(), left?.ToString(), right?.ToString());
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj?.ToString());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class BTNComparer
    {
        public void run()
        {

            BTN a = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2
                },
                right = new BTN
                {
                    val = 3,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                }
            };

            BTN b = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                },
                right = new BTN
                {
                    val = 3
                }
            };

            BTN c = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2
                },
                right = new BTN
                {
                    val = 3,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                }
            };

            BTN d = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                },
                right = new BTN
                {
                    val = 3
                }
            };
            Console.WriteLine("Is a equal to b? {0}", a.Equals(b));
            Console.WriteLine("Is a equal to c? {0}", a.Equals(c));
            Console.WriteLine("Is a equal to d? {0}", a.Equals(d));
            Console.WriteLine("Is b equal to c? {0}", b.Equals(c));
            Console.WriteLine("Is b equal to d? {0}", b.Equals(d));
   
        }

    }   

}

