using System;
using System.Collections.Generic;
using System.Text;
using SeatBookingSimulator.Classes;

namespace SeatBookingSimulator.Classes
{
    class SeatManager
    {
        DoubleLinkedList _seats;
        //SeatManager _seatManager = new SeatManager();
        public SeatManager()
        {
            _seats = new DoubleLinkedList();
        }
        public Seat InsertOneSeat(int row, int column)
        {
            Seat newSeat = new Seat();
            //Setup the Seat object
            newSeat.Row = row;
            newSeat.SeatNumber = column;
            newSeat.CanBook = true;
            //Console.WriteLine("Added Seat {0}", newSeat.Row + newSeat.SeatNumber);
            //Insert the Seat object into the double linked list.
            _seats.AddSeat(newSeat);
            return newSeat;
        } // End of InsertOneSeat
        public Seat FindOneSeatToBook(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            seat.BookStatus = true;
            seat.CanBook = false;
            return seat;
        }// End of FindOneSeatToBook
        public Seat FindOneSeatToUnbook(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            seat.BookStatus = false;
            seat.CanBook = true;
            return seat;
        }// End of FindOneSeatToUnbook

        public Seat DisplaySeats(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            seat.SeatLabel.Text = "Seat" + row + column;
            return seat;
        }

        public void GenerateSeats(int row, int column)
        {

            int x, y = 0;
            for (x = 1; x <= column; x++)
            {
                for (y = 1; y <= row; y++)
                {
                    Seat generateSeat = new Seat();
                    generateSeat.Row = row;
                    generateSeat.SeatNumber = column;
                    generateSeat.BookStatus = false;
                    generateSeat.CanBook = true;
                    generateSeat.PersonBooking = "";

                    _seats.AddSeat(generateSeat);
                }
            }
        }
        public void RegenerateSeats(int row, int column)
        {

            int x, y = 0;
            for (x = 1; x <= column; x++)
            {
                for (y = 1; y <= row; y++)
                {

                    Seat seat = _seats.SearchByRowAndColumn(x, y);
                    _seats.DeleteNode(seat);
                }
            }
        }

        /*public Seat GetSeats()
        {
            //Seat seat = ;
            //return seat;
        }*/

        public void PersonBookingSeats(int row, int column, string person)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            if (seat.BookStatus == true)
            {
                seat.PersonBooking = person;
            }
        }

    }
}
