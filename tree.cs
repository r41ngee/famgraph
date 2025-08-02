namespace FG.Core.Tree;

using FG.Core.Models;
using System.Collections.Generic;

public class Tree {
    Dictionary<Guid, Person> people { get; } = [];
    List<Relation> relations { get; } = [];

    public ulong Version { get; private set; } = 0;

    public bool AddPerson(Person person) {
        bool validation = !people.ContainsKey(person.id);
        if (validation) {
            people.Add(person.id, person);
        }
        return validation;
    }

    public bool addRelationship(Relation relation) {
        bool validation = !people.ContainsKey(relation.fromId) || !people.ContainsKey(relation.toId);
        if (validation) {
            relations.Add(relation);
            Version++;
        }
        return false;
    } 
}