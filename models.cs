using System;

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
    }
}

public class Relationship {
    public Guid fromId;
    public Guid toId;
    public RelationshipType type;
    public DateOnly? startDate;
    public DateOnly? endDate;
}

public enum RelationshipType {
    Parent,
    Child,
    Spouse,
    Sibling
}
