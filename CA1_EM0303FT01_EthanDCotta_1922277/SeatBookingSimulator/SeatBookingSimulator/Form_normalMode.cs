using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Linq;
using SeatBookingSimulator.Classes;
using System.Diagnostics;


namespace SeatBookingSimulator
{
    public partial class Form_normalMode : Form
    {

        SeatManager _seatManager = new SeatManager();
        DoubleLinkedList _doubleLinkedList = new DoubleLinkedList();

        int NumOfRows = 6;
        int NumOfcolumns = 12;
        int x, y = 0;
        public Form_normalMode()
        {
            InitializeComponent();
        }
        private void ResetFormState()
        {
            //DrawLabel(8, 12);
            DrawLabel2(NumOfRows, NumOfcolumns);

            richTextBoxMessage.Text = "";
            panelSeats.Controls.Add(labelScreen);
            buttonPersonA.Enabled = true;
            buttonPersonB.Enabled = true;
            buttonPersonC.Enabled = true;
            buttonPersonD.Enabled = true;
        }

        private void DrawLabel(int x, int y)
        {
            int labelsize = 45;
            int[] rowaisle = { 2, 6 };
            int[] columnaisle = { 4, 10 };
            int columnname = 1;

            // loop through each column (1,2,3...)
            for (int i = 0; i < x; i++)
            {
                if (!columnaisle.Contains(i))
                {
                    char rowname = 'A';

                    // loop through each row (a,b,c,d...)
                    for (int j = 0; j < y; j++)
                    {
                        if (!rowaisle.Contains(j))
                        {

                            var labelname = rowname + columnname.ToString();

                            var xpos = (j * (labelsize + 15)) + 100;
                            var ypos = (i * (labelsize + 15)) + 200;

                            var labelSeat = new Label
                            {
                                Text = labelname,
                                Width = labelsize,
                                Height = labelsize,
                                Top = xpos,
                                Left = ypos,
                                BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.LightGray
                            };

                            panelSeats.Controls.Add(labelSeat);

                            rowname++;
                        }
                    }

                    columnname++;
                }
            }
        }

        private void DrawLabel2(int maxRow, int maxColumn) 
        {
            int seatWidth = 45;
            int seatHeight = 45;

            for (y = 1; y <= maxRow; y++)
            {
                for (x = 1; x <= maxColumn; x++)
                {
                    _seatManager.GenerateSeats(y, x);
                    Seat seat = _seatManager.GetSeat(y, x);
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
                    labelSeat.BackColor = Color.White;
                    labelSeat.Name = "labelSeat_" + y.ToString() + "_" + x.ToString();

                    //seat = _seatManager.InsertOneSeat(y, x);
                    labelSeat.Click += new EventHandler(HandleLabelClick);
                    labelSeat.Tag = seat;
                    labelSeat.Text = seat.ComputeSeatLabel();

                    panelSeats.Controls.Add(labelSeat);
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

                if (seat.BookStatus == false && seat.CanBook == true)
                {
                    seat = _seatManager.FindOneSeatToBook(seat.Row, seat.SeatNumber);
                    richTextBoxMessage.Text = String.Format("Selected Seat {0}\n", labelSeat.Text);
                }

                else
                {
                    seat = _seatManager.FindOneSeatToUnbook(seat.Row, seat.SeatNumber);
                    richTextBoxMessage.Text = String.Format("Unselected Seat {0}\n", labelSeat.Text);
                }

                if (seat.BookStatus == false && seat.CanBook == true)
                {
                    labelSeat.BackColor = Color.White;
                    
                }

                else
                {
                    labelSeat.BackColor = Color.Yellow;
                    
                }
            }
        }
        private void Form_normalMode_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Normal Mode Loaded");
            ResetFormState();
            buttonSaveToFile.Click += new EventHandler(buttonSaveToFile_Click);
            //LoadData();
            //_doubleLinkedList.DisplayListOfSeats();

        }
        private void buttonPersonA_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = "";

            for (y = 1; y <= NumOfRows; y++)
            {
                for (x = 1; x <= NumOfcolumns; x++)
                {
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    if (seat.BookStatus == true && seat.CanBook == false && seat.PersonBooking == "")
                    {
                        _seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person A");
                        seat.SeatLabel.BackColor = Color.Red;
                        labelSeat.Click -= new EventHandler(HandleLabelClick);
                        richTextBoxMessage.Text += String.Format("Person A Booking Seat:  {0}\n", labelSeat.Text);
                    }
                }
            }

            if (buttonPersonB.Enabled == true || buttonPersonC.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonA.Enabled = false;
            }

            else
            {
                buttonPersonA.Enabled = false;
            }
        }

        private void buttonPersonB_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = "";

            for (x = 1; x <= NumOfcolumns; x++)
            {
                for (y = 1; y <= NumOfRows; y++)
                {
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    if (seat.BookStatus == true && seat.CanBook == false && seat.PersonBooking == "")
                    {
                        _seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person B");
                        seat.SeatLabel.BackColor = Color.Red;
                        labelSeat.Click -= new EventHandler(HandleLabelClick);
                        richTextBoxMessage.Text += String.Format("Person B Booking Seat:  {0}\n", labelSeat.Text);
                    }

                }

            }

            if (buttonPersonA.Enabled == true || buttonPersonC.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonB.Enabled = false;
            }
            else
            {
                buttonPersonB.Enabled = false;
            }
        }

        private void buttonPersonC_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = "";

            for (x = 1; x <= NumOfcolumns; x++)
            {
                for (y = 1; y <= NumOfRows; y++)
                {
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    if (seat.BookStatus == true && seat.CanBook == false && seat.PersonBooking == "")
                    {
                        _seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person C");
                        seat.SeatLabel.BackColor = Color.Red;
                        labelSeat.Click -= new EventHandler(HandleLabelClick);
                        richTextBoxMessage.Text += String.Format("Person C Booking Seat:  {0}\n", labelSeat.Text);
                    }

                }

            }

            if (buttonPersonA.Enabled == true || buttonPersonB.Enabled == true || buttonPersonD.Enabled == true)
            {
                buttonPersonC.Enabled = false;
            }

            else
            {
                buttonPersonC.Enabled = false;
            }
        }

        private void buttonPersonD_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = "";

            for (x = 1; x <= NumOfcolumns; x++)
            {
                for (y = 1; y <= NumOfRows; y++)
                {
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    if (seat.BookStatus == true && seat.CanBook == false && seat.PersonBooking == "")
                    {
                        _seatManager.PersonBookingSeats(seat.Row, seat.SeatNumber, "Person D");
                        seat.SeatLabel.BackColor = Color.Red;
                        labelSeat.Click -= new EventHandler(HandleLabelClick);
                        richTextBoxMessage.Text += String.Format("Person D Booking Seat:  {0}\n", labelSeat.Text);
                    }

                }

            }

            if (buttonPersonA.Enabled == true || buttonPersonB.Enabled == true || buttonPersonC.Enabled == true)
            {
                buttonPersonD.Enabled = false;
            }

            else
            {
                buttonPersonD.Enabled = false;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            panelSeats.Controls.Clear();

            int maxRow = 6;
            int maxColumn = 12;

            for (y = 1; y <= maxRow; y++)
            {
                for (x = 1; x <= maxColumn; x++)
                {
                    _seatManager.DeleteSeats(y, x);
                }

            }

            ResetFormState();
            richTextBoxMessage.Text = String.Format("Resetting Simulation\n");
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
/*            ListViewItem lvi;
            this.toDoList.ReadFromFile();
            List<ToDo> toDoListData = toDoList.GetToDoList();

            foreach (var toDoItem in toDoListData)
            {
                lvi = new ListViewItem(toDoItem.Title);
                lvi.SubItems.Add(toDoItem.PriorityLevel.ToString());
                lvi.SubItems.Add(toDoItem.Status.ToString());
                lvi.Tag = toDoItem;

                listviewToDoList.Items.Add(lvi);
            }*/
        }
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
            this._seatManager.SaveToFile();
            ResetFormState();
        }

        private void LoadData()
        {
            

            for (x = 1; x <= NumOfcolumns; x++)
            {
                for (y = 1; y <= NumOfRows; y++)
                {
                    
                    this._seatManager.ReadFromFile();
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    panelSeats.Controls.Add(labelSeat);
                }
            }
        }

        private void buttonShowLog_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = "";

            for (y = 1; y <= NumOfRows; y++)
            {
                for (x = 1; x <= NumOfcolumns; x++)
                {
                    Seat seat = _seatManager.GetSeat(y, x);
                    Label labelSeat = seat.SeatLabel;

                    if (seat.PersonBooking == "Person A")
                    {
                        richTextBoxMessage.Text += String.Format("Person A has booked Seat:  {0}\n", labelSeat.Text);
                    }

                    if (seat.PersonBooking == "Person B")
                    {
                        richTextBoxMessage.Text += String.Format("Person B has booked Seat:  {0}\n", labelSeat.Text);
                    }

                    if (seat.PersonBooking == "Person C")
                    {
                        richTextBoxMessage.Text += String.Format("Person C has booked Seat:  {0}\n", labelSeat.Text);
                    }

                    if (seat.PersonBooking == "Person D")
                    {
                        richTextBoxMessage.Text += String.Format("Person D has booked Seat:  {0}\n", labelSeat.Text);
                    }
                }
            }
        }
    }
}
