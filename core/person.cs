using System;
using System.Security.Cryptography;
using System.Text;

namespace FG.Core.Models;

public enum Gender {
    Male,
    Female,
}

public class Person {
    public Guid id = Guid.NewGuid();
    public string name { get; set; }
    public Gender gender { get; set; }
    public DateOnly? birthDate { get; set; }
    public DateOnly? deathDate { get; set; }

    public string represent;

    public byte[] hash {get;}


    public Person(
        string name,
        Gender gender,
        DateOnly? birthDate,
        DateOnly? deathDate
    ) {
        this.name = name;
        this.gender = gender;
        this.birthDate = birthDate;
        this.deathDate = deathDate;

        represent = asString();
        hash = calculateIdHash();
    }

    byte[] calculateIdHash() {
        using var sha256 = SHA256.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(represent));
    }

    public string asString() {
        return 
        $"g:{gender}_name:{name}_bd:{(birthDate?.ToString() ?? "none")}_dd:{deathDate?.ToString() ?? "none"}";
    }
}
