using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace Korexio.Prototype.Tests;

/// <summary>
/// Defines tests for the <see cref="MainServiceConfiguration"/> class.
/// </summary>
public class MainServiceConfiguration_Tests
{
  /// <summary>
  /// Verifies that an instance of the <see cref="MainServiceConfiguration"/> class can be validated.
  /// </summary>
  [Fact]
  public void MainServiceConfiguration_Can_Be_Validated()
  {
    var mainServiceConfiguration = new MainServiceConfiguration {
      Delay = TimeSpan.FromSeconds(1),
      Count = 3
    };

    var validationResults = mainServiceConfiguration.Validate(new ValidationContext(mainServiceConfiguration));

    Assert.Equal(ValidationResult.Success, validationResults.DefaultIfEmpty(ValidationResult.Success).Single());
  }
}
