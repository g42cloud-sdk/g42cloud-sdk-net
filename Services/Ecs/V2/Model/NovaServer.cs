using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class NovaServer 
    {
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum _BUILD for value:  BUILD
            /// </summary>
            public static readonly StatusEnum _BUILD = new StatusEnum(" BUILD");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum HARD_REBOOT for value: HARD_REBOOT
            /// </summary>
            public static readonly StatusEnum HARD_REBOOT = new StatusEnum("HARD_REBOOT");

            /// <summary>
            /// Enum MIGRATING for value: MIGRATING
            /// </summary>
            public static readonly StatusEnum MIGRATING = new StatusEnum("MIGRATING");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly StatusEnum REBOOT = new StatusEnum("REBOOT");

            /// <summary>
            /// Enum RESIZE for value: RESIZE
            /// </summary>
            public static readonly StatusEnum RESIZE = new StatusEnum("RESIZE");

            /// <summary>
            /// Enum REVERT_RESIZE for value: REVERT_RESIZE
            /// </summary>
            public static readonly StatusEnum REVERT_RESIZE = new StatusEnum("REVERT_RESIZE");

            /// <summary>
            /// Enum SHELVED for value: SHELVED
            /// </summary>
            public static readonly StatusEnum SHELVED = new StatusEnum("SHELVED");

            /// <summary>
            /// Enum SHELVED_OFFLOADED for value: SHELVED_OFFLOADED
            /// </summary>
            public static readonly StatusEnum SHELVED_OFFLOADED = new StatusEnum("SHELVED_OFFLOADED");

            /// <summary>
            /// Enum SHUTOFF for value: SHUTOFF
            /// </summary>
            public static readonly StatusEnum SHUTOFF = new StatusEnum("SHUTOFF");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly StatusEnum UNKNOWN = new StatusEnum("UNKNOWN");

            /// <summary>
            /// Enum VERIFY_RESIZE for value: VERIFY_RESIZE
            /// </summary>
            public static readonly StatusEnum VERIFY_RESIZE = new StatusEnum("VERIFY_RESIZE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { " BUILD", _BUILD },
                { "DELETED", DELETED },
                { "ERROR", ERROR },
                { "HARD_REBOOT", HARD_REBOOT },
                { "MIGRATING", MIGRATING },
                { "REBOOT", REBOOT },
                { "RESIZE", RESIZE },
                { "REVERT_RESIZE", REVERT_RESIZE },
                { "SHELVED", SHELVED },
                { "SHELVED_OFFLOADED", SHELVED_OFFLOADED },
                { "SHUTOFF", SHUTOFF },
                { "UNKNOWN", UNKNOWN },
                { "VERIFY_RESIZE", VERIFY_RESIZE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OSDCFdiskConfigEnum>))]
        public class OSDCFdiskConfigEnum
        {
            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly OSDCFdiskConfigEnum AUTO = new OSDCFdiskConfigEnum("AUTO");

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly OSDCFdiskConfigEnum MANUAL = new OSDCFdiskConfigEnum("MANUAL");

            private static readonly Dictionary<string, OSDCFdiskConfigEnum> StaticFields =
            new Dictionary<string, OSDCFdiskConfigEnum>()
            {
                { "AUTO", AUTO },
                { "MANUAL", MANUAL },
            };

            private string _value;

            public OSDCFdiskConfigEnum()
            {

            }

            public OSDCFdiskConfigEnum(string value)
            {
                _value = value;
            }

            public static OSDCFdiskConfigEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OSDCFdiskConfigEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSDCFdiskConfigEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OSEXTSTStaskStateEnum>))]
        public class OSEXTSTStaskStateEnum
        {
            /// <summary>
            /// Enum SHOUTOFF for value: SHOUTOFF
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum SHOUTOFF = new OSEXTSTStaskStateEnum("SHOUTOFF");

            /// <summary>
            /// Enum _RESIZE for value:  RESIZE
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _RESIZE = new OSEXTSTStaskStateEnum(" RESIZE");

            /// <summary>
            /// Enum _REBUILD for value:  REBUILD
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _REBUILD = new OSEXTSTStaskStateEnum(" REBUILD");

            /// <summary>
            /// Enum _VERIFY_RESIZE for value:  VERIFY_RESIZE
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _VERIFY_RESIZE = new OSEXTSTStaskStateEnum(" VERIFY_RESIZE");

            /// <summary>
            /// Enum _REVERT_RESIZE for value:  REVERT_RESIZE
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _REVERT_RESIZE = new OSEXTSTStaskStateEnum(" REVERT_RESIZE");

            /// <summary>
            /// Enum _PAUSED for value:  PAUSED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _PAUSED = new OSEXTSTStaskStateEnum(" PAUSED");

            /// <summary>
            /// Enum _MIGRATING for value:  MIGRATING
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _MIGRATING = new OSEXTSTStaskStateEnum(" MIGRATING");

            /// <summary>
            /// Enum _SUSPENDED for value:  SUSPENDED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _SUSPENDED = new OSEXTSTStaskStateEnum(" SUSPENDED");

            /// <summary>
            /// Enum _RESCUE for value:  RESCUE
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _RESCUE = new OSEXTSTStaskStateEnum(" RESCUE");

            /// <summary>
            /// Enum _ERROR for value:  ERROR
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _ERROR = new OSEXTSTStaskStateEnum(" ERROR");

            /// <summary>
            /// Enum _DELETED for value:  DELETED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum _DELETED = new OSEXTSTStaskStateEnum(" DELETED");

            /// <summary>
            /// Enum SOFT_DELETED for value: SOFT_DELETED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum SOFT_DELETED = new OSEXTSTStaskStateEnum("SOFT_DELETED");

            /// <summary>
            /// Enum SHELVED for value: SHELVED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum SHELVED = new OSEXTSTStaskStateEnum("SHELVED");

            /// <summary>
            /// Enum SHELVED_OFFLOADED for value: SHELVED_OFFLOADED
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum SHELVED_OFFLOADED = new OSEXTSTStaskStateEnum("SHELVED_OFFLOADED");

            private static readonly Dictionary<string, OSEXTSTStaskStateEnum> StaticFields =
            new Dictionary<string, OSEXTSTStaskStateEnum>()
            {
                { "SHOUTOFF", SHOUTOFF },
                { " RESIZE", _RESIZE },
                { " REBUILD", _REBUILD },
                { " VERIFY_RESIZE", _VERIFY_RESIZE },
                { " REVERT_RESIZE", _REVERT_RESIZE },
                { " PAUSED", _PAUSED },
                { " MIGRATING", _MIGRATING },
                { " SUSPENDED", _SUSPENDED },
                { " RESCUE", _RESCUE },
                { " ERROR", _ERROR },
                { " DELETED", _DELETED },
                { "SOFT_DELETED", SOFT_DELETED },
                { "SHELVED", SHELVED },
                { "SHELVED_OFFLOADED", SHELVED_OFFLOADED },
            };

            private string _value;

            public OSEXTSTStaskStateEnum()
            {

            }

            public OSEXTSTStaskStateEnum(string value)
            {
                _value = value;
            }

            public static OSEXTSTStaskStateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OSEXTSTStaskStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTSTStaskStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSEXTSTStaskStateEnum a, OSEXTSTStaskStateEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OSEXTSTStaskStateEnum a, OSEXTSTStaskStateEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OSEXTSTSvmStateEnum>))]
        public class OSEXTSTSvmStateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum ACTIVE = new OSEXTSTSvmStateEnum("ACTIVE");

            /// <summary>
            /// Enum BUILDING for value: BUILDING
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum BUILDING = new OSEXTSTSvmStateEnum("BUILDING");

            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum STOPPED = new OSEXTSTSvmStateEnum("STOPPED");

            /// <summary>
            /// Enum RESIZED for value: RESIZED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum RESIZED = new OSEXTSTSvmStateEnum("RESIZED");

            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum PAUSED = new OSEXTSTSvmStateEnum("PAUSED");

            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SUSPENDED = new OSEXTSTSvmStateEnum("SUSPENDED");

            /// <summary>
            /// Enum RESCUED for value: RESCUED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum RESCUED = new OSEXTSTSvmStateEnum("RESCUED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum ERROR = new OSEXTSTSvmStateEnum("ERROR");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum DELETED = new OSEXTSTSvmStateEnum("DELETED");

            /// <summary>
            /// Enum SOFT_DELETED for value: SOFT_DELETED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SOFT_DELETED = new OSEXTSTSvmStateEnum("SOFT_DELETED");

            /// <summary>
            /// Enum SHELVED for value: SHELVED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SHELVED = new OSEXTSTSvmStateEnum("SHELVED");

            /// <summary>
            /// Enum SHELVED_OFFLOADED for value: SHELVED_OFFLOADED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SHELVED_OFFLOADED = new OSEXTSTSvmStateEnum("SHELVED_OFFLOADED");

            private static readonly Dictionary<string, OSEXTSTSvmStateEnum> StaticFields =
            new Dictionary<string, OSEXTSTSvmStateEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILDING", BUILDING },
                { "STOPPED", STOPPED },
                { "RESIZED", RESIZED },
                { "PAUSED", PAUSED },
                { "SUSPENDED", SUSPENDED },
                { "RESCUED", RESCUED },
                { "ERROR", ERROR },
                { "DELETED", DELETED },
                { "SOFT_DELETED", SOFT_DELETED },
                { "SHELVED", SHELVED },
                { "SHELVED_OFFLOADED", SHELVED_OFFLOADED },
            };

            private string _value;

            public OSEXTSTSvmStateEnum()
            {

            }

            public OSEXTSTSvmStateEnum(string value)
            {
                _value = value;
            }

            public static OSEXTSTSvmStateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OSEXTSTSvmStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTSTSvmStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSEXTSTSvmStateEnum a, OSEXTSTSvmStateEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OSEXTSTSvmStateEnum a, OSEXTSTSvmStateEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<HostStatusEnum>))]
        public class HostStatusEnum
        {
            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            public static readonly HostStatusEnum UP = new HostStatusEnum("UP");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly HostStatusEnum UNKNOWN = new HostStatusEnum("UNKNOWN");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly HostStatusEnum DOWN = new HostStatusEnum("DOWN");

            /// <summary>
            /// Enum MAINTENANCE for value: MAINTENANCE
            /// </summary>
            public static readonly HostStatusEnum MAINTENANCE = new HostStatusEnum("MAINTENANCE");

            private static readonly Dictionary<string, HostStatusEnum> StaticFields =
            new Dictionary<string, HostStatusEnum>()
            {
                { "UP", UP },
                { "UNKNOWN", UNKNOWN },
                { "DOWN", DOWN },
                { "MAINTENANCE", MAINTENANCE },
            };

            private string _value;

            public HostStatusEnum()
            {

            }

            public HostStatusEnum(string value)
            {
                _value = value;
            }

            public static HostStatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as HostStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostStatusEnum a, HostStatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HostStatusEnum a, HostStatusEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public NovaServerFlavor Flavor { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public NovaServerImage Image { get; set; }

        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("hostId", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<NovaNetwork>> Addresses { get; set; }

        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerSecurityGroup> SecurityGroups { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaLink> Links { get; set; }

        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public OSDCFdiskConfigEnum OSDCFdiskConfig { get; set; }
        [JsonProperty("OS-EXT-AZ:availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTAZavailabilityZone { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhost { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:hypervisor_hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhypervisorHostname { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRinstanceName { get; set; }

        [JsonProperty("OS-EXT-STS:power_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSEXTSTSpowerState { get; set; }

        [JsonProperty("OS-EXT-STS:task_state", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTSTStaskStateEnum OSEXTSTStaskState { get; set; }
        [JsonProperty("OS-EXT-STS:vm_state", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTSTSvmStateEnum OSEXTSTSvmState { get; set; }
        [JsonProperty("OS-SRV-USG:launched_at", NullValueHandling = NullValueHandling.Ignore)]
        public string OSSRVUSGlaunchedAt { get; set; }

        [JsonProperty("OS-SRV-USG:terminated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string OSSRVUSGterminatedAt { get; set; }

        [JsonProperty("os-extended-volumes:volumes_attached", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerVolume> OsExtendedVolumesvolumesAttached { get; set; }

        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public NovaServerFault Fault { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("host_status", NullValueHandling = NullValueHandling.Ignore)]
        public HostStatusEnum HostStatus { get; set; }
        [JsonProperty("OS-EXT-SRV-ATTR:hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhostname { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRreservationId { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:launch_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSEXTSRVATTRlaunchIndex { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:kernel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRkernelId { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:ramdisk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRramdiskId { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:root_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRrootDeviceName { get; set; }

        [JsonProperty("OS-EXT-SRV-ATTR:user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRuserData { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        [JsonProperty("accessIPv4", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv4 { get; set; }

        [JsonProperty("accessIPv6", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv6 { get; set; }

        [JsonProperty("config_drive", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigDrive { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        [JsonProperty("os:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public NovaServerSchedulerHints OsschedulerHints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaServer {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  oSEXTAZavailabilityZone: ").Append(OSEXTAZavailabilityZone).Append("\n");
            sb.Append("  oSEXTSRVATTRhost: ").Append(OSEXTSRVATTRhost).Append("\n");
            sb.Append("  oSEXTSRVATTRhypervisorHostname: ").Append(OSEXTSRVATTRhypervisorHostname).Append("\n");
            sb.Append("  oSEXTSRVATTRinstanceName: ").Append(OSEXTSRVATTRinstanceName).Append("\n");
            sb.Append("  oSEXTSTSpowerState: ").Append(OSEXTSTSpowerState).Append("\n");
            sb.Append("  oSEXTSTStaskState: ").Append(OSEXTSTStaskState).Append("\n");
            sb.Append("  oSEXTSTSvmState: ").Append(OSEXTSTSvmState).Append("\n");
            sb.Append("  oSSRVUSGlaunchedAt: ").Append(OSSRVUSGlaunchedAt).Append("\n");
            sb.Append("  oSSRVUSGterminatedAt: ").Append(OSSRVUSGterminatedAt).Append("\n");
            sb.Append("  osExtendedVolumesvolumesAttached: ").Append(OsExtendedVolumesvolumesAttached).Append("\n");
            sb.Append("  fault: ").Append(Fault).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  hostStatus: ").Append(HostStatus).Append("\n");
            sb.Append("  oSEXTSRVATTRhostname: ").Append(OSEXTSRVATTRhostname).Append("\n");
            sb.Append("  oSEXTSRVATTRreservationId: ").Append(OSEXTSRVATTRreservationId).Append("\n");
            sb.Append("  oSEXTSRVATTRlaunchIndex: ").Append(OSEXTSRVATTRlaunchIndex).Append("\n");
            sb.Append("  oSEXTSRVATTRkernelId: ").Append(OSEXTSRVATTRkernelId).Append("\n");
            sb.Append("  oSEXTSRVATTRramdiskId: ").Append(OSEXTSRVATTRramdiskId).Append("\n");
            sb.Append("  oSEXTSRVATTRrootDeviceName: ").Append(OSEXTSRVATTRrootDeviceName).Append("\n");
            sb.Append("  oSEXTSRVATTRuserData: ").Append(OSEXTSRVATTRuserData).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  accessIPv4: ").Append(AccessIPv4).Append("\n");
            sb.Append("  accessIPv6: ").Append(AccessIPv6).Append("\n");
            sb.Append("  configDrive: ").Append(ConfigDrive).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  osschedulerHints: ").Append(OsschedulerHints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaServer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.OSDCFdiskConfig == input.OSDCFdiskConfig ||
                    (this.OSDCFdiskConfig != null &&
                    this.OSDCFdiskConfig.Equals(input.OSDCFdiskConfig))
                ) && 
                (
                    this.OSEXTAZavailabilityZone == input.OSEXTAZavailabilityZone ||
                    (this.OSEXTAZavailabilityZone != null &&
                    this.OSEXTAZavailabilityZone.Equals(input.OSEXTAZavailabilityZone))
                ) && 
                (
                    this.OSEXTSRVATTRhost == input.OSEXTSRVATTRhost ||
                    (this.OSEXTSRVATTRhost != null &&
                    this.OSEXTSRVATTRhost.Equals(input.OSEXTSRVATTRhost))
                ) && 
                (
                    this.OSEXTSRVATTRhypervisorHostname == input.OSEXTSRVATTRhypervisorHostname ||
                    (this.OSEXTSRVATTRhypervisorHostname != null &&
                    this.OSEXTSRVATTRhypervisorHostname.Equals(input.OSEXTSRVATTRhypervisorHostname))
                ) && 
                (
                    this.OSEXTSRVATTRinstanceName == input.OSEXTSRVATTRinstanceName ||
                    (this.OSEXTSRVATTRinstanceName != null &&
                    this.OSEXTSRVATTRinstanceName.Equals(input.OSEXTSRVATTRinstanceName))
                ) && 
                (
                    this.OSEXTSTSpowerState == input.OSEXTSTSpowerState ||
                    (this.OSEXTSTSpowerState != null &&
                    this.OSEXTSTSpowerState.Equals(input.OSEXTSTSpowerState))
                ) && 
                (
                    this.OSEXTSTStaskState == input.OSEXTSTStaskState ||
                    (this.OSEXTSTStaskState != null &&
                    this.OSEXTSTStaskState.Equals(input.OSEXTSTStaskState))
                ) && 
                (
                    this.OSEXTSTSvmState == input.OSEXTSTSvmState ||
                    (this.OSEXTSTSvmState != null &&
                    this.OSEXTSTSvmState.Equals(input.OSEXTSTSvmState))
                ) && 
                (
                    this.OSSRVUSGlaunchedAt == input.OSSRVUSGlaunchedAt ||
                    (this.OSSRVUSGlaunchedAt != null &&
                    this.OSSRVUSGlaunchedAt.Equals(input.OSSRVUSGlaunchedAt))
                ) && 
                (
                    this.OSSRVUSGterminatedAt == input.OSSRVUSGterminatedAt ||
                    (this.OSSRVUSGterminatedAt != null &&
                    this.OSSRVUSGterminatedAt.Equals(input.OSSRVUSGterminatedAt))
                ) && 
                (
                    this.OsExtendedVolumesvolumesAttached == input.OsExtendedVolumesvolumesAttached ||
                    this.OsExtendedVolumesvolumesAttached != null &&
                    input.OsExtendedVolumesvolumesAttached != null &&
                    this.OsExtendedVolumesvolumesAttached.SequenceEqual(input.OsExtendedVolumesvolumesAttached)
                ) && 
                (
                    this.Fault == input.Fault ||
                    (this.Fault != null &&
                    this.Fault.Equals(input.Fault))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostStatus == input.HostStatus ||
                    (this.HostStatus != null &&
                    this.HostStatus.Equals(input.HostStatus))
                ) && 
                (
                    this.OSEXTSRVATTRhostname == input.OSEXTSRVATTRhostname ||
                    (this.OSEXTSRVATTRhostname != null &&
                    this.OSEXTSRVATTRhostname.Equals(input.OSEXTSRVATTRhostname))
                ) && 
                (
                    this.OSEXTSRVATTRreservationId == input.OSEXTSRVATTRreservationId ||
                    (this.OSEXTSRVATTRreservationId != null &&
                    this.OSEXTSRVATTRreservationId.Equals(input.OSEXTSRVATTRreservationId))
                ) && 
                (
                    this.OSEXTSRVATTRlaunchIndex == input.OSEXTSRVATTRlaunchIndex ||
                    (this.OSEXTSRVATTRlaunchIndex != null &&
                    this.OSEXTSRVATTRlaunchIndex.Equals(input.OSEXTSRVATTRlaunchIndex))
                ) && 
                (
                    this.OSEXTSRVATTRkernelId == input.OSEXTSRVATTRkernelId ||
                    (this.OSEXTSRVATTRkernelId != null &&
                    this.OSEXTSRVATTRkernelId.Equals(input.OSEXTSRVATTRkernelId))
                ) && 
                (
                    this.OSEXTSRVATTRramdiskId == input.OSEXTSRVATTRramdiskId ||
                    (this.OSEXTSRVATTRramdiskId != null &&
                    this.OSEXTSRVATTRramdiskId.Equals(input.OSEXTSRVATTRramdiskId))
                ) && 
                (
                    this.OSEXTSRVATTRrootDeviceName == input.OSEXTSRVATTRrootDeviceName ||
                    (this.OSEXTSRVATTRrootDeviceName != null &&
                    this.OSEXTSRVATTRrootDeviceName.Equals(input.OSEXTSRVATTRrootDeviceName))
                ) && 
                (
                    this.OSEXTSRVATTRuserData == input.OSEXTSRVATTRuserData ||
                    (this.OSEXTSRVATTRuserData != null &&
                    this.OSEXTSRVATTRuserData.Equals(input.OSEXTSRVATTRuserData))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.AccessIPv4 == input.AccessIPv4 ||
                    (this.AccessIPv4 != null &&
                    this.AccessIPv4.Equals(input.AccessIPv4))
                ) && 
                (
                    this.AccessIPv6 == input.AccessIPv6 ||
                    (this.AccessIPv6 != null &&
                    this.AccessIPv6.Equals(input.AccessIPv6))
                ) && 
                (
                    this.ConfigDrive == input.ConfigDrive ||
                    (this.ConfigDrive != null &&
                    this.ConfigDrive.Equals(input.ConfigDrive))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.OsschedulerHints == input.OsschedulerHints ||
                    (this.OsschedulerHints != null &&
                    this.OsschedulerHints.Equals(input.OsschedulerHints))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.OSDCFdiskConfig != null)
                    hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.OSEXTAZavailabilityZone != null)
                    hashCode = hashCode * 59 + this.OSEXTAZavailabilityZone.GetHashCode();
                if (this.OSEXTSRVATTRhost != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhost.GetHashCode();
                if (this.OSEXTSRVATTRhypervisorHostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhypervisorHostname.GetHashCode();
                if (this.OSEXTSRVATTRinstanceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRinstanceName.GetHashCode();
                if (this.OSEXTSTSpowerState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSpowerState.GetHashCode();
                if (this.OSEXTSTStaskState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTStaskState.GetHashCode();
                if (this.OSEXTSTSvmState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSvmState.GetHashCode();
                if (this.OSSRVUSGlaunchedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGlaunchedAt.GetHashCode();
                if (this.OSSRVUSGterminatedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGterminatedAt.GetHashCode();
                if (this.OsExtendedVolumesvolumesAttached != null)
                    hashCode = hashCode * 59 + this.OsExtendedVolumesvolumesAttached.GetHashCode();
                if (this.Fault != null)
                    hashCode = hashCode * 59 + this.Fault.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostStatus != null)
                    hashCode = hashCode * 59 + this.HostStatus.GetHashCode();
                if (this.OSEXTSRVATTRhostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhostname.GetHashCode();
                if (this.OSEXTSRVATTRreservationId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRreservationId.GetHashCode();
                if (this.OSEXTSRVATTRlaunchIndex != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRlaunchIndex.GetHashCode();
                if (this.OSEXTSRVATTRkernelId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRkernelId.GetHashCode();
                if (this.OSEXTSRVATTRramdiskId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRramdiskId.GetHashCode();
                if (this.OSEXTSRVATTRrootDeviceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRrootDeviceName.GetHashCode();
                if (this.OSEXTSRVATTRuserData != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRuserData.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.AccessIPv4 != null)
                    hashCode = hashCode * 59 + this.AccessIPv4.GetHashCode();
                if (this.AccessIPv6 != null)
                    hashCode = hashCode * 59 + this.AccessIPv6.GetHashCode();
                if (this.ConfigDrive != null)
                    hashCode = hashCode * 59 + this.ConfigDrive.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.OsschedulerHints != null)
                    hashCode = hashCode * 59 + this.OsschedulerHints.GetHashCode();
                return hashCode;
            }
        }
    }
}
