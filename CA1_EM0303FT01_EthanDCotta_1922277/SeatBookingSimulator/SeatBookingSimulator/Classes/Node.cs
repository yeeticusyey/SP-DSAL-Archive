using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using SeatBookingSimulator.Classes;

namespace SeatBookingSimulator.Classes
{
    [Serializable]
    class Node
    {
        private Node _prev;
        private Node _next;
        private Seat _seat;

        public Node Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }
        public Node(Seat pSeat)
        {
            _seat = pSeat;
        }//Constructor
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
        public Seat Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }

    }// End of Node class
}
