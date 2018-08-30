using System;
namespace dream_team
{
public interface iPerson
{
    string firstName { get; set; }
    string lastName { get; set; }
    string fullName { get; }
    string specialty { get; set; }
    void Work();
}
}
