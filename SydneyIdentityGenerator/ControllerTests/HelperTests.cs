﻿using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllerTests;

[TestClass]
public class HelperTests
{
    [TestMethod]
    public void NameGeneratorShouldNotBeNull()
    {
        // Arrange

        // Act

        // Assert
        Assert.IsNotNull(Helper.NameGenerator);
    }

    [TestMethod]
    public void AddressGeneratorShouldNotBeNull()
    {
        // Arrange

        // Act

        // Assert
        Assert.IsNotNull(Helper.AddressGenerator);
    }
}