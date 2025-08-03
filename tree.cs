namespace FG.Core.Tree;

using FG.Core.Models;
using System.Collections.Generic;

public class Tree {
    public ulong version {get; private set;}

    Dictionary<Guid, Person> _people { get; } = [];
    Dictionary<byte[], Person> _hashPeople = [];
    Dictionary<Guid, Relation> _relations { get; } = [];

    public bool TryAddPerson(Person person) {
        if (_hashPeople.ContainsKey(person.hash)) return false;

        _people.Add(person.id, person);
        _hashPeople.Add(person.hash, person);
        return true;
    }

    public bool TryRemovePerson(Person person) {
        if (!_hashPeople.ContainsKey(person.hash)) return false;
        _people.Remove(person.id);
        _hashPeople.Remove(person.hash);
        return true;
    }
}