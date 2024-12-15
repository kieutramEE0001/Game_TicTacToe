using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_TicTacToe
{
    internal class Const
    {
        //Khai báo biến chiều rộng và chiều cao của mỗi ô trong bàn cờ 
        public static int Chess_W = 30;
        public static int Chess_H = 30;

        //Khai báo biến chiều rộng và chiều cao của bàn cờ
        public static int ChessBoard_W = 18;
        public static int ChessBoard_H = 18;

        //Khai báo biến step của progress bar và thời gian của mỗi nước cờ 
        public static int CoolDown_Step = 100;
        //Thời gian mỗi nước cờ là 10s = 10000 ms (milisecond)
        public static int CoolDown_Time = 10000;
        public static int CoolDown_Interval = 100;
    }
}
