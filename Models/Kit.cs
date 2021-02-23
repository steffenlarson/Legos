using System;
using System.ComponentModel.DataAnnotations;



namespace legos.Models
{
  public class Kit
  {
    public string Name { get; set; }
    public string Instruction { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public float Price { get; set; }
  }
}


