using System;
namespace dream_team
{
public class Jacob : iPerson
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string specialty { get; set; }
    public string fullName { get => $"{firstName} {lastName}"; }
    public Jacob(string first, string last, string special)
    {
        this.firstName = first;
        this.lastName = last;
        this.specialty = special;
    }
    public void Work(){
        Console.WriteLine($"{this.fullName} is working on some {this.specialty} fam");
    }
}
}