using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_puzzles
{
    internal class Diamond
    {
        public int Size {  get; private set; }

        public Diamond(int size) {
            Size = size;
        }

        public void generateDiamond(bool reverse = false)
        {
            int tempSize = Size;
            for(int i = 0; i < Size; i++)
            {
                tempSize--;

                if(!reverse)
                {
                    generateLine(i, tempSize);
                }
                else
                {
                    generateLine(tempSize, i);
                }
            }
        }

        public void generateLine(int spaces, int hashtags)
        {
            int Spaces = spaces;
            int Hashtags = hashtags * 2;

            generateChars(Spaces, ' ');
            generateChars(Hashtags, '#');
            generateChars(Spaces, ' ');
            
            Console.WriteLine();
        }

        public void generateChars(int val, char character)
        {
            for (int i = 0; i < val; i++)
            {
                Console.Write(character);
            }
        }

        public void setSize(int size) { Size = size; }

    }
}
