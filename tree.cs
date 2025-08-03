namespace FG.Core.Tree;

using FG.Core.Models;
using System.Collections.Generic;

public class Tree {
    Dictionary<Guid, Person> people { get; } = [];
    Dictionary<Guid, Relation> relations { get; } = [];

    public ulong version {get; private set;}

    
}