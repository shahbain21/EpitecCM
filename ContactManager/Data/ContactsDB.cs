using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Data;

// Create a contacts class
public class Contacts
{
    // Make Id a primary key
    [Key] public Guid Id { get; set; }
    [MaxLength(250)] public string? FirstName { get; set; }
    [MaxLength(250)] public string? LastName { get; set; }
    [MaxLength(15)] public string? PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
}

