using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogic
{
    public class Board
    {
        public int[] Grid { get; set; }
        public Board() {
            //inailazie the board
            for (int i = 0; i < 9; i++)
            {
                Grid[i] = 0;
            }
        }
    }
}
