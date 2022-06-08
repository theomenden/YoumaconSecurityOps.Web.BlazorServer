﻿namespace YoumaconSecurityOps.Core.Shared.Models.Readers;

[Table("Staff")]
[Index(nameof(IncidentId), Name = "IX_Staff_IncidentId")]
[Index(nameof(RoomId), Name = "IX_Staff_RoomId")]
public partial class StaffReader : IEntity
{
    [Key]
    public Guid Id { get; set; }
    
    public bool IsOnBreak { get; set; }
    
    [Required]
    public bool? NeedsCrashSpace { get; set; }
    
    public bool IsBlackShirt { get; set; }
    
    public bool IsRaveApproved { get; set; }
    
    public DateTime? BreakStartAt { get; set; }
    
    public DateTime? BreakEndAt { get; set; }

    [StringLength(6)]
    public string? ShirtSize { get; set; }
    public Guid? IncidentId { get; set; }
    public Guid? RoomId { get; set; }

    [NotMapped]
    public StaffRole? StaffRole => StaffTypesRoles.Max()?.StaffRole;

    [NotMapped]
    public StaffType? StaffType => StaffTypesRoles.Max()?.StaffType;

    [InverseProperty(nameof(ContactReader.Staff))]
    public virtual ContactReader ContactInformation { get; set; }
    
    [InverseProperty(nameof(IncidentReader.OpsManager))]
    public virtual ICollection<IncidentReader> IncidentOpsManagers { get; set; } = new HashSet<IncidentReader>();

    [InverseProperty(nameof(IncidentReader.RecordedBy))]
    public virtual ICollection<IncidentReader> IncidentRecordedBies { get; set; } = new HashSet<IncidentReader>();

    [InverseProperty(nameof(RadioScheduleReader.LastStaffToHave))]
    public virtual ICollection<RadioScheduleReader> RadioSchedules { get; set; } = new HashSet<RadioScheduleReader>();

    [InverseProperty(nameof(ShiftReader.StaffMember))]
    public virtual ICollection<ShiftReader> Shifts { get; set; } = new HashSet<ShiftReader>();

    [InverseProperty(nameof(StaffTypesRole.Staff))]
    public virtual ICollection<StaffTypesRole> StaffTypesRoles { get; set; } = new HashSet<StaffTypesRole>();
}