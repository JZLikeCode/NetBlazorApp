namespace NetBlazorApp.Tests;

using NetBlazorApp.Data;

[TestClass]
public sealed class WeatherForecastTests
{
    [TestMethod]
    public async Task GetForecastAsync_ReturnsFiveItems_WithExpectedRanges()
    {
        // Arrange
        var service = new WeatherForecastService();
        var startDate = new DateOnly(2025, 1, 1);

        // Act
        var result = await service.GetForecastAsync(startDate);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(5, result.Length);

        for (int i = 0; i < result.Length; i++)
        {
            var item = result[i];
            // Dates should be startDate + (i + 1)
            Assert.AreEqual(startDate.AddDays(i + 1), item.Date);

            // TemperatureC is generated via Random.Shared.Next(-20, 55), upper bound exclusive
            Assert.IsTrue(item.TemperatureC >= -20 && item.TemperatureC < 55,
                $"TemperatureC out of range: {item.TemperatureC}");

            // Summary should be one of the predefined values and not null
            Assert.IsFalse(string.IsNullOrWhiteSpace(item.Summary));
        }
    }

    [TestMethod]
    public void TemperatureF_ComputesExpectedValues()
    {
        var forecast = new WeatherForecast();

        forecast.TemperatureC = 0;
        Assert.AreEqual(32, forecast.TemperatureF);

        forecast.TemperatureC = 20; // 20C -> 68F exactly with this formula
        Assert.AreEqual(68, forecast.TemperatureF);

        forecast.TemperatureC = -40; // -40C -> -40F
        Assert.AreEqual(-40, forecast.TemperatureF);
    }
}
