using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Korexio.Prototype;

public class MainServiceConfiguration : IValidatableObject
{
  [Range(1, 10)]
  public int Count { get; init; }

  public TimeSpan Delay { get; init; }

  public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
  {
    if (Delay < TimeSpan.Zero)
    {
      yield return new ValidationResult("Delay must not be negative.", new[] { nameof(Delay) });
    }

    if (Delay == Timeout.InfiniteTimeSpan)
    {
      yield return new ValidationResult("Delay must not be set to infinity.", new[] { nameof(Delay) });
    }
  }
}
