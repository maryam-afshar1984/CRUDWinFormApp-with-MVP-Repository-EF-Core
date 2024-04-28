using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NorthwindWinFormsApp.Models;

public partial class Customer
{
    [DisplayName("Customer Id")]
    [Required(ErrorMessage = "Customer Id is required!")]
   // [StringLength(5, ErrorMessage = "Customer Id must be 5 characters!")]
    //[RegularExpression("^[A-Z]*$", ErrorMessage = "Customer Id must contain only capital letters A-Z.")]
    [RegularExpression(@"^[A-Z]{5}$", ErrorMessage = "Customer Id must be exactly 5 capital letters A-Z.")]

    public string CustomerId { get; set; } = null!;

    [DisplayName("Company Name")]
    [Required(ErrorMessage = "The Customer Name is required!")]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "Customer Name must be between 5 and 30 characters!")]
    public string CompanyName { get; set; } = null!;

    [DisplayName("Contact Name")]
    [StringLength(30, ErrorMessage = "Contact Name cannot exceed 30 characters!")]
    [RegularExpression(@"^[A-Za-zöäüßÖÄÜ\séÉáÁúÚèÈ´ñÁÉÍÓÚáéíóú`]*$", ErrorMessage = "Contact Name can only contain letters, spaces, and specific special characters.")]
    public string? ContactName { get; set; }

    [DisplayName("Contact Title")]
    [StringLength(30, ErrorMessage = "Contact Title cannot exceed 30 characters!")]
    public string? ContactTitle { get; set; }

    [DisplayName("Customer Address")]
    [StringLength(60, ErrorMessage = "Address cannot exceed 60 characters!")]
    public string? Address { get; set; }

    [DisplayName("Customer City")]
    [StringLength(15, ErrorMessage = "City cannot exceed 15 characters!")]
    [RegularExpression(@"^[A-Za-zöäüßÖÄÜ\séÉáÁúÚèÈ´ñÁÉÍÓÚáéíóú`]*$", ErrorMessage = "City can only contain letters, spaces, and specific special characters.")]
    public string? City { get; set; }

    [DisplayName("Customer Region")]
    [StringLength(15, ErrorMessage = "Region cannot exceed 15 characters!")]
    [RegularExpression(@"^[A-Za-zöäüßÖÄÜ\séÉáÁúÚèÈ´ñÁÉÍÓÚáéíóú`]*$", ErrorMessage = "Region can only contain letters, spaces, and specific special characters.")]
    public string? Region { get; set; }

    [DisplayName("Customer PostalCode")]
    [StringLength(10, ErrorMessage = "PostalCode cannot exceed 10 characters!")]
    public string? PostalCode { get; set; }

    [DisplayName("Customer Country")]
    [StringLength(15, ErrorMessage = "Country cannot exceed 15 characters!")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Country can only contain alphabetical characters.")]
    public string? Country { get; set; }

    [DisplayName("Customer Phone")]
    [StringLength(24, ErrorMessage = "Phone number exceed 24 characters!")]
    [RegularExpression(@"^[\d()\-\.]+$", ErrorMessage = "Phone number can contain only digits, parentheses (), hyphens (-), and periods (.).")]
    public string? Phone { get; set; }

    [DisplayName("Customer Fax")]
    [StringLength(24, ErrorMessage = "Fax exceed 24 characters!")]
    [RegularExpression(@"^[\d()\-\.]+$", ErrorMessage = "Fax can contain only digits, parentheses (), hyphens (-), and periods (.).")]
    public string? Fax { get; set; }

}
