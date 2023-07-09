using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace Korexio.Prototype.Tests;

public class MainServiceConfiguration_Tests
{
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
