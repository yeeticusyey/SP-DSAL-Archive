using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using SeatBookingSimulator.Classes;

namespace SeatBookingSimulator.Classes
{
    [Serializable]
    class Seat
    {

        private int _rowNumber; // The _row field is 2 if the object is modelling a seat at row B.
        private int _seatNumber; // _seatNumber field is 3 if the object is modelling a seat at column 3.
        private bool _bookStatus = false; //booked or not 
        private bool _canBook = true; //available
        private string _personBooking;
        private Label _seatlabel;

        private bool _topIsLane;
        private bool _bottomIsLane;
        private bool _leftIsLane;
        private bool _rightIsLane;

        public Seat()

        {
            _seatlabel = new Label();
            _bookStatus = false;
            _canBook = true;
            _personBooking = "";

            _topIsLane = false;
            _bottomIsLane = false;
            _leftIsLane = false;
            _rightIsLane = false;
        }


        public int Row // property
        {
            get { return _rowNumber; } // get method
            set
            {
                _rowNumber = value;
            } // set method
        }
        public int SeatNumber // property
        {
            get { return _seatNumber; } // get method
            set { _seatNumber = value; } // set method
        }
        public bool CanBook // property
        {
            get { return _canBook; } // get method
            set
            {
                _canBook = value;
            } // set method
        }
        public bool BookStatus // property
        {
            get { return _bookStatus; } // get method
            set
            {
                if (value == true && _bookStatus == false)
                {
                    _bookStatus = value;
                    _seatlabel.BackColor = Color.LightGray;
                }

                if (value == false && _bookStatus == true)
                {
                    _bookStatus = value;
                    _seatlabel.BackColor = Color.Red;
                }
            }
        }
        public string ComputeSeatLabel()
        {
            return ((char)(_rowNumber + 64)).ToString() + _seatNumber.ToString();
        }

        public string PersonBooking
        {
            get { return _personBooking; }
            set { _personBooking = value; }
        }

        public Label SeatLabel
        {
            get { return _seatlabel; }
            set { _seatlabel = value; }
        }

        public bool TopIsLane
        {
            get { return _topIsLane; }
            set { _topIsLane = value; }
        }

        public bool BottomIsLane
        {
            get { return _bottomIsLane; }
            set { _bottomIsLane = value; }
        }

        public bool LeftIsLane
        {
            get { return _leftIsLane; }
            set { _leftIsLane = value; }
        }

        public bool RightIsLane
        {
            get { return _rightIsLane; }
            set { _rightIsLane = value; }
        }

    }// End of Seat class
}
