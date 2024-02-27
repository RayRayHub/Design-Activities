using System;
using System.Collections.Generic;

public class ParkingTicket
{
    public Guid TicketNumber {get; set;}
    public DateTime TimeIn {get; set;}
    public Datetime TimeOut {get; set;}
    public int Space {get; set;}
    public decimal Fee {get; set;}
}