using System;
using System.Collections.Generic;
using System.Linq;

namespace ListShuffler
{
    public class Collections
    {
        private static Random rnd;

        static Collections()
        {
            rnd = new Random();
        }

        public List<T> Shuffle<T>(List<T> l)
        {
            List<T> newList = new List<T>();
            int count = l.Count;
            List<int> indes = new List<int>();
            indes.Add(rnd.Next(0, count));

            if (count > 0)
            {
                int j = 0;
                while (j != l.Count - 1)
                {
                    bool isIndexExist = false;
                    int generated_index = rnd.Next(0, count);

                    for (int i = 0; i < indes.Count; i++)
                    {
                        if (indes.ElementAt(i) == generated_index)
                        {
                            isIndexExist = true;
                            break;
                        }
                    }

                    if (!isIndexExist)
                    {
                        indes.Add(generated_index);
                        j++;
                    }
                }
            }

            foreach (int z in indes)
            {
                newList.Add(l.ElementAt(z));

            }


            return newList;
        }

    }
}
