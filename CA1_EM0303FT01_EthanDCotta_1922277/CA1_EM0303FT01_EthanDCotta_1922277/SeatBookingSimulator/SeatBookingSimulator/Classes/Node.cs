using System;
using System.Collections.Generic;
using System.Text;
using SeatBookingSimulator.Classes;

namespace SeatBookingSimulator.Classes
{
    class Node
    {
        private Node _next;
        private Seat _seat;
        private Node _prev;
        public Node(Seat pSeat)
        {
            _seat = pSeat;
        }//Constructor
        public Node Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }
        public Seat Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }// End of Node class
}
