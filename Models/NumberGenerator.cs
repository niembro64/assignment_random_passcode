using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment_random_passcode.Models
{

  public class NumberGenerator
  {

    [Required]
    [MinLength(3)]
    public string Name { get; set; }


  }

}