using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HackerRank;

public class NotesStore
{
    private readonly List<(string, string)> _notes = new();
    private readonly string[] _states = ["completed", "active", "others"];
    
    public void AddNote(string state, string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }

        if (!_states.Contains(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        _notes.Add((state, name));
    }

    public List<string> GetNotes(string state)
    {
        if (!_states.Contains(state))
        {
            throw new Exception($"Invalid state {state}");
        }

        var foundNotes = new List<string>();

        foreach (var note in _notes)
        {
            if (note.Item1.Equals(state))
            {
                foundNotes.Add(note.Item2);
            }
        }

        return foundNotes;
    }
}