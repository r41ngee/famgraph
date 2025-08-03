using System;

namespace FG.Core.Models;


public class Relation {
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
