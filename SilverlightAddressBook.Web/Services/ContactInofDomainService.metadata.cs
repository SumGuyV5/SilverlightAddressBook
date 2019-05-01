/*****************************************************************
**  Program Name:   SAB (Silverlight Address Book) 				**
**  Version Number: V1.0                                        **
**  Copyright (C):  June 1, 2010 Richard W. Allen               **
**  Date Started:   June 1, 2010                                **
**  Date Ended:     June 1, 2010                                **
**  Author:         Richardn W. Allen                           **
**  Webpage:        http://richard-allen.homelinux.com/         **
**  IDE:            Visual Studio 2010                          **
**  Compiler:       C# 2010                                     **
**  Langage:        Silverlight 4 C# 2010     				    **
**  License:        GNU GENERAL PUBLIC LICENSE Version 2    	**
**		            see license.txt for for details	            **
******************************************************************/
namespace SilverlightAddressBook.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ContactMetadata as the class
    // that carries additional metadata for the Contact class.
    [MetadataTypeAttribute(typeof(Contact.ContactMetadata))]
    public partial class Contact
    {

        // This class allows you to attach custom attributes to properties
        // of the Contact class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ContactMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ContactMetadata()
            {
            }

            [StringLength(20)]
            public string Address { get; set; }

            [StringLength(20)]
            public string City { get; set; }

            [StringLength(20)]
            public string Country { get; set; }

            [StringLength(50)]
            public string Email { get; set; }

            [StringLength(20)]
            public string FirstName { get; set; }

            public int ID { get; set; }

            [StringLength(20)]
            public string LastName { get; set; }

            [RegularExpression("[0-9| |-]+", ErrorMessage="Number spaces and - only")]
            [StringLength(16)]
            public string MobileNumber { get; set; }

            public string Notes { get; set; }

            [RegularExpression("[0-9| |-]+", ErrorMessage="Number spaces and - only")]
            [StringLength(16)]
            public string PhoneNumber { get; set; }

            [StringLength(20)]
            public string PostalCode { get; set; }

            [StringLength(20)]
            public string Province { get; set; }
        }
    }
}
