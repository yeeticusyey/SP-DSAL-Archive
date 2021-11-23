using System;
using System.Collections.Generic;
using System.Text;
using SeatBookingSimulator.Classes;

namespace SeatBookingSimulator.Classes
{
    class DoubleLinkedList
    {
        public Node start { get; set; }
        public DoubleLinkedList()
        {
            start = null;
        }
        public void DisplayListOfSeats()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("No seats in SeatList");
            }

            else
            {
                p = this.start;
                Console.WriteLine("\nThe double linked list has:");

                while (p != null)
                {
                    Console.WriteLine("{0}", p.Seat);
                    p = p.Next;
 
                }
            }


        }
        public void InsertAtBeginning(Seat seatData)
        {

            Node newNode = new Node(seatData);
            newNode.Next = start;

            if (start != null)
            {
                start.Prev = newNode;
            }

            start = newNode;
        }
        public void AddSeat(Seat seatData)
        {
            Node newNode = new Node(seatData);
            if (this.start == null)
            {
                this.start = newNode;
                return;
            }
            Node p = this.start;
            // Traverse through the list until the p refers to
            // the last node.
            while (p.Next != null)
            {
                p = p.Next;
            }// End of while
            p.Next = newNode;
            newNode.Prev = p;
        }//End of InsertAtEnd
        public void InsertAfter(Seat seatData, Seat pSearchInfo)
        {
            Node newNode = new Node(seatData);
            Node p = this.start;

            while (p != null)
            {
                if (p.Seat == pSearchInfo)
                {
                    break;
                }

                p = p.Next;
            }

            if (p == null)
            {
                Console.WriteLine("{0} is not found in the list, ", pSearchInfo);
            }

            else
            {
                newNode.Prev = p;
                newNode.Next = p.Next;

                if (p.Next != null)
                {
                    p.Next.Prev = newNode;
                }

                p.Next = newNode;
            }
        }
        public void InsertBefore(Seat seatData, Seat pSearchInfo)
        {
            if (start == null)
            {
                Console.WriteLine("The double linked list has 0 nodes");
                return;
            }

            if (start.Seat == pSearchInfo)
            {
                Node newNode = new Node(seatData);
                newNode.Next = start;
                start.Prev = newNode;
                start = newNode;
                return;
            }

            Node p = start;

            while (p != null)
            {
                if (p.Seat == pSearchInfo)
                {
                    break;
                }

                p = p.Next;
            }

            if (p == null)
            {
                Console.WriteLine("{0} is not found in the list, ", pSearchInfo);
            }

            else
            {
                Node newNode = new Node(seatData);
                newNode.Prev = p.Prev;
                newNode.Next = p;
                p.Prev.Next = newNode;
                p.Prev = newNode;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
            {
                return;
            }

            if (start.Next == null)
            {
                start = null;
                return;
            }

            start = start.Next;
            start.Prev = null;
        }

        public void DeleteLastNode()
        {
            if (start == null)
            {
                return;
            }

            if (start.Next == null)
            {
                start = null;
                return;
            }

            Node p = start;

            while (p.Next != null)
            {
                p = p.Next;
            }

            p.Prev.Next = null;
        }

        public void DeleteNode(Seat pSearchInfo)
        {
            if (start == null)
            {
                return;
            }

            if (start.Next == null)
            {
                if (start.Seat == pSearchInfo)
                {
                    start = null;
                }

                else
                {
                    Console.WriteLine("{0} is not found in the list, ", pSearchInfo);
                }

                return;
            }

            if (start.Seat == pSearchInfo)
            {
                start = start.Next;
                start.Prev = null;
                return;
            }

            Node p = start.Next;

            while (p.Next != null)
            {
                if (p.Seat == pSearchInfo)
                {
                    break;
                }

                p = p.Next;
            }

            if (p.Next != null)
            {
                p.Prev.Next = p.Next;
                p.Next.Prev = p.Prev;
            }

            else
            {
                if (p.Seat == pSearchInfo)
                {
                    p.Prev.Next = null;
                }
                else
                {
                    Console.WriteLine("{0} is not found in the list, ", pSearchInfo);
                }
            }
        }

        public Seat SearchByRowAndColumn(int pRow, int pColumn)
        {
            Node p = this.start;
            while (p != null)
            {
                if ((p.Seat.SeatNumber == pColumn) && (p.Seat.Row == pRow))
                {
                    //If the node referenced by p satisfies the
                    //search criteria, exit the loop
                    //The p will reference the node which satisfies
                    //the search criteria before exiting the while loop.
                    break;//Exit the while loop
                }
                p = p.Next; //Continue to the next node
            }//While loop
            if (p == null)
            {
                return null;
            }
            else
            {
                return p.Seat;
            }//End of if..else block
        }//End of SearchByRowAndColumn
    }
}
