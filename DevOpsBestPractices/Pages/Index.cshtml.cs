using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DevOpsBestPractices.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    private readonly TelemetryClient _telemetry;
    private readonly Random _random;

    public int RandomNumber;

    public IndexModel(ILogger<IndexModel> logger, TelemetryClient telemetry)
    {
      _logger = logger;
      _telemetry = telemetry;
      _random = new Random();
    }

    public void OnGet()
    {
      RandomNumber = _random.Next(100);

      _telemetry.GetMetric("randomNumber").TrackValue(RandomNumber);

      _logger.LogWarning("A user has visited the front page!");
    }
  }
}
