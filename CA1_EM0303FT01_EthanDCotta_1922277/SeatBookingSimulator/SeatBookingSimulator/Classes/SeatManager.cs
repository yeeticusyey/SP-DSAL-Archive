using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
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

        public Seat GetSeat(int row, int column)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            //seat.SeatLabel.Text = "Seat " + row + column;
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
        public void DeleteSeats(int row, int column)
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

/*        public Seat GetSeats()
        {
            Seat seat = _seats.SearchByRowAndColumn();
            return seat;
        }*/

        public void PersonBookingSeats(int row, int column, string person)
        {
            Seat seat = _seats.SearchByRowAndColumn(row, column);
            if (seat.BookStatus == true)
            {
                seat.PersonBooking = person;
            }
        }

        public void SaveToFile()
        {
            string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\data.txt";
            BinaryFormatter f = new BinaryFormatter();
            Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Write);
            f.Serialize(stream, _seats);
            stream.Close();
        }

        public void ReadFromFile()
        {
            string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\data.txt";
            Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();

            if (stream.Length != 0)
            {
                _seats = (DoubleLinkedList)f.Deserialize(stream);
            }

            stream.Close();
        }

    }
}
