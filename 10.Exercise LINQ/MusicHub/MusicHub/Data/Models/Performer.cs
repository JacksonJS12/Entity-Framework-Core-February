﻿namespace MusicHub.Data.Models;

using System.ComponentModel.DataAnnotations;
using Castle.Components.DictionaryAdapter;

public class Performer
{
    public Performer()
    {
        this.PerformerSongs = new HashSet<SongPerformer>();
    }
    [System.ComponentModel.DataAnnotations.Key]
    public int Id { get; set; }

    [MaxLength(ValidationConstants.PerformerFirstNameMaxLength)]
    public string FirstName { get; set; } = null!;

    [MaxLength(ValidationConstants.PerformerLastNameMaxLength)]
    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public decimal NetWorth { get; set; }
    public virtual ICollection<SongPerformer> PerformerSongs { get; set; }

}

