using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SeatBookingSimulator.Classes;
using System.Diagnostics;


namespace SeatBookingSimulator
{
    public partial class Form_normalMode : Form
    {

        SeatManager _seatManager = new SeatManager();
        DoubleLinkedList _doubleLinkedList = new DoubleLinkedList();
        public Form_normalMode()
        {
            InitializeComponent();
        }

        private void ResetFormState()
        {
            int maxRow = 6;
            int maxColumn = 12;
            int seatWidth = 45;
            int seatHeight = 45;
            int x, y = 0;

            for (x = 1; x <= maxColumn; x++)
            {
                for (y = 1; y <= maxRow; y++)
                {
                    _seatManager.GenerateSeats(x, y);
                    Seat seat = _seatManager.DisplaySeats(x, y);
                    Label labelSeat = seat.SeatLabel;

                    if (y > 2)
                    {
                        labelSeat.Top = 10 + ((y + 1) * (seatHeight + 5)) + 15;

                        if (y > 5)
                        {
                            labelSeat.Top = 10 + ((y + 2) * (seatHeight + 5)) + 15;
                        }
                    }

                    else
                    {
                        labelSeat.Top = 10 + (y * (seatHeight + 5)) + 15;
                    }

                    if (x > 4)
                    {
                        labelSeat.Left = 175 + ((x + 1) * (seatWidth + 5)) + 15;

                        if (x > 9)
                        {
                            labelSeat.Left = 175 + ((x + 2) * (seatWidth + 5)) + 15;
                        }
                    }

                    else
                    {
                        labelSeat.Left = 175 + (x * (seatWidth + 5)) + 15;
                    }

                    labelSeat.Width = seatWidth;
                    labelSeat.Height = seatHeight;
                    labelSeat.BorderStyle = BorderStyle.FixedSingle;
                    labelSeat.BackColor = Color.LightGray;
                    labelSeat.Name = "labelSeat_" + y.ToString() + "_" + x.ToString();

                    labelSeat.Click += new EventHandler(HandleLabelClick);
                    seat = _seatManager.InsertOneSeat(x, y);

                    labelSeat.Tag = seat;
                    labelSeat.Text = seat.ComputeSeatLabel();

                    panelSeats.Controls.Add(labelSeat);
                    panelSeats.Controls.Add(labelScreen);

                    buttonPersonA.Enabled = true;
                    buttonPersonB.Enabled = true;
                    buttonPersonC.Enabled = true;
                    buttonPersonD.Enabled = true;
                }
            }
        }

        private void HandleLabelClick(object sender, EventArgs e)
        {
            string labelName = "";
            Label labelSeat = (Label)sender;
            Seat seat = (Seat)labelSeat.Tag;

            if (buttonPersonA.Enabled == false && buttonPersonB.Enabled == false && buttonPersonC.Enabled == false && buttonPersonD.Enabled == false)
            {
                return;
            }

            else
            {

                if (seat.BookStatus == false)
                {
                    seat = _seatManager.FindOneSeatToBook(seat.Row, seat.SeatNumber);
                    richTextBoxMessage.Text = String.Format("Selected Seat {0}\n", labelSeat.Text);
                }

                else
                {
                    seat = _seatManager.FindOneSeatToUnbook(seat.Row, seat.SeatNumber);
                    richTextBoxMessage.Text = String.Format("Unselected Seat {0}\n", labelSeat.Text);
                }

                if (seat.BookStatus == false)
                {
                    labelSeat.BackColor = Color.LightGray;
                    
                }

                else
                {
                    labelSeat.BackColor = Color.Yellow;
                    
                }

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            panelSeats.Controls.Clear();

            int maxRow = 6;
            int maxColumn = 12;
            int x, y = 0;

            for (x = 1; x <= maxColumn; x++)
            {
                for (y = 1; y <= maxRow; y++)
                {
                    _seatManager.RegenerateSeats(x, y);
                }

            }

            ResetFormState();
            richTextBoxMessage.Text = String.Format("Resetting Simualtion\n");
        }

        private void Form_normalMode_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Normal Mode Loaded");
            ResetFormState();
            _doubleLinkedList.DisplayListOfSeats();

        }

        private void buttonPersonA_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = String.Format("Person A Booking\n");

            if (buttonPersonB.Enabled == true || buttonPersonC.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonA.Enabled = false;
            }

            else
            {
                buttonPersonA.Enabled = false;
            }

            //_seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "person A");
        }

        private void buttonPersonB_Click(object sender, EventArgs e)
        {

            richTextBoxMessage.Text = String.Format("Person B Booking\n");

            if (buttonPersonA.Enabled == true || buttonPersonC.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonB.Enabled = false;
            }
            else
            {
                buttonPersonB.Enabled = false;
            }

            //_seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person B");

        }

        private void buttonPersonC_Click(object sender, EventArgs e)
        {

            richTextBoxMessage.Text = String.Format("Person C Booking\n");

            if (buttonPersonA.Enabled == true || buttonPersonB.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonC.Enabled = false;
            }

            else
            {
                buttonPersonC.Enabled = false;
            }

            //_seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person C");
        }

        private void buttonPersonD_Click(object sender, EventArgs e)
        {

            richTextBoxMessage.Text = String.Format("Person D Booking\n");
            if (buttonPersonA.Enabled == true || buttonPersonB.Enabled == true || buttonPersonC.Enabled == true)
            {
                buttonPersonD.Enabled = false;
            }

            else
            {
                buttonPersonD.Enabled = false;
            }

            //_seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person D");


        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

    }
}
