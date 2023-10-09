using System;
using System.Collections.Generic;

// Abstraktní třída pro účastníky události
public abstract class Participant
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public bool IsAttending { get; set; }

    protected Participant(string name, string email)
    {
        Name = name;
        Email = email;
        IsAttending = false;
    }

    // Abstraktní metoda pro zobrazení informací o účastníkovi
    public abstract void DisplayInfo();
}

// Třída pro hosty
public class Guest : Participant
{
    public Guest(string name, string email) : base(name, email)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Host: {Name}, Email: {Email}, Attending: {IsAttending}");
    }
}

// Třída pro vystupující
public class Performer : Participant
{
    public string Genre { get; private set; }

    public Performer(string name, string email, string genre) : base(name, email)
    {
        Genre = genre;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Performer: {Name}, Email: {Email}, Genre: {Genre}, Attending: {IsAttending}");
    }
}

// Třída pro událost
public class Event
{
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public string Location { get; private set; }
    private List<Participant> Participants { get; set; }

    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
        Participants = new List<Participant>();
    }

    public void AddParticipant(Participant participant)
    {
        Participants.Add(participant);
    }

    // Metoda pro zobrazení informací o události
    public void DisplayEventInfo()
    {
        Console.WriteLine($"Event: {Name}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine("Participants:");
        foreach (var participant in Participants)
        {
            participant.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Vytvoření události
        Event event1 = new Event("Koncert", new DateTime(2023, 10, 20), "Praha");

        // Přidání účastníků
        Guest guest1 = new Guest("Pavel Vácha", "vacha@example.com");
        Performer performer1 = new Performer("Hudební kapela", "kapela@example.com", "Country");

        event1.AddParticipant(guest1);
        event1.AddParticipant(performer1);

        // Zobrazení informací o události
        event1.DisplayEventInfo();
    }
}
