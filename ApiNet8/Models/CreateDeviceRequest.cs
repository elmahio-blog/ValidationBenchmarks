using System.ComponentModel.DataAnnotations;

namespace ApiNet8.Models;

public sealed class CreateDeviceRequest
{
    [Required]
    public string DeviceId { get; set; } = default!;

    [Range(-40, 85)]
    public double Temperature { get; set; }

    [Range(0, 100)]
    public int BatteryLevel { get; set; }

    [Required]
    public DateTime Timestamp { get; set; }
}