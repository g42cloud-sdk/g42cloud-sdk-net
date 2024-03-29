using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 镜像信息响应体
    /// </summary>
    public class ImageInfo 
    {
        [JsonConverter(typeof(EnumClassConverter<ImageSourceTypeEnum>))]
        public class ImageSourceTypeEnum
        {
            /// <summary>
            /// Enum UDS for value: uds
            /// </summary>
            public static readonly ImageSourceTypeEnum UDS = new ImageSourceTypeEnum("uds");

            /// <summary>
            /// Enum SWIFT for value: swift
            /// </summary>
            public static readonly ImageSourceTypeEnum SWIFT = new ImageSourceTypeEnum("swift");

            private static readonly Dictionary<string, ImageSourceTypeEnum> StaticFields =
            new Dictionary<string, ImageSourceTypeEnum>()
            {
                { "uds", UDS },
                { "swift", SWIFT },
            };

            private string _value;

            public ImageSourceTypeEnum()
            {

            }

            public ImageSourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ImageSourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ImageSourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageSourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageSourceTypeEnum a, ImageSourceTypeEnum b)
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

            public static bool operator !=(ImageSourceTypeEnum a, ImageSourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<ImagetypeEnum>))]
        public class ImagetypeEnum
        {
            /// <summary>
            /// Enum GOLD for value: gold
            /// </summary>
            public static readonly ImagetypeEnum GOLD = new ImagetypeEnum("gold");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly ImagetypeEnum PRIVATE = new ImagetypeEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly ImagetypeEnum SHARED = new ImagetypeEnum("shared");

            private static readonly Dictionary<string, ImagetypeEnum> StaticFields =
            new Dictionary<string, ImagetypeEnum>()
            {
                { "gold", GOLD },
                { "private", PRIVATE },
                { "shared", SHARED },
            };

            private string _value;

            public ImagetypeEnum()
            {

            }

            public ImagetypeEnum(string value)
            {
                _value = value;
            }

            public static ImagetypeEnum FromValue(string value)
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

                if (this.Equals(obj as ImagetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImagetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImagetypeEnum a, ImagetypeEnum b)
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

            public static bool operator !=(ImagetypeEnum a, ImagetypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<IsregisteredEnum>))]
        public class IsregisteredEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsregisteredEnum TRUE = new IsregisteredEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsregisteredEnum FALSE = new IsregisteredEnum("false");

            private static readonly Dictionary<string, IsregisteredEnum> StaticFields =
            new Dictionary<string, IsregisteredEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsregisteredEnum()
            {

            }

            public IsregisteredEnum(string value)
            {
                _value = value;
            }

            public static IsregisteredEnum FromValue(string value)
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

                if (this.Equals(obj as IsregisteredEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsregisteredEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsregisteredEnum a, IsregisteredEnum b)
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

            public static bool operator !=(IsregisteredEnum a, IsregisteredEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OsBitEnum>))]
        public class OsBitEnum
        {
            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            public static readonly OsBitEnum _32 = new OsBitEnum("32");

            /// <summary>
            /// Enum _64 for value: 64
            /// </summary>
            public static readonly OsBitEnum _64 = new OsBitEnum("64");

            private static readonly Dictionary<string, OsBitEnum> StaticFields =
            new Dictionary<string, OsBitEnum>()
            {
                { "32", _32 },
                { "64", _64 },
            };

            private string _value;

            public OsBitEnum()
            {

            }

            public OsBitEnum(string value)
            {
                _value = value;
            }

            public static OsBitEnum FromValue(string value)
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

                if (this.Equals(obj as OsBitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsBitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsBitEnum a, OsBitEnum b)
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

            public static bool operator !=(OsBitEnum a, OsBitEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: Linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("Linux");

            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("Windows");

            /// <summary>
            /// Enum OTHER for value: Other
            /// </summary>
            public static readonly OsTypeEnum OTHER = new OsTypeEnum("Other");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Linux", LINUX },
                { "Windows", WINDOWS },
                { "Other", OTHER },
            };

            private string _value;

            public OsTypeEnum()
            {

            }

            public OsTypeEnum(string value)
            {
                _value = value;
            }

            public static OsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsTypeEnum a, OsTypeEnum b)
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

            public static bool operator !=(OsTypeEnum a, OsTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<PlatformEnum>))]
        public class PlatformEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly PlatformEnum WINDOWS = new PlatformEnum("Windows");

            /// <summary>
            /// Enum UBUNTU for value: Ubuntu
            /// </summary>
            public static readonly PlatformEnum UBUNTU = new PlatformEnum("Ubuntu");

            /// <summary>
            /// Enum REDHAT for value: RedHat
            /// </summary>
            public static readonly PlatformEnum REDHAT = new PlatformEnum("RedHat");

            /// <summary>
            /// Enum SUSE for value: SUSE
            /// </summary>
            public static readonly PlatformEnum SUSE = new PlatformEnum("SUSE");

            /// <summary>
            /// Enum CENTOS for value: CentOS
            /// </summary>
            public static readonly PlatformEnum CENTOS = new PlatformEnum("CentOS");

            /// <summary>
            /// Enum DEBIAN for value: Debian
            /// </summary>
            public static readonly PlatformEnum DEBIAN = new PlatformEnum("Debian");

            /// <summary>
            /// Enum OPENSUSE for value: OpenSUSE
            /// </summary>
            public static readonly PlatformEnum OPENSUSE = new PlatformEnum("OpenSUSE");

            /// <summary>
            /// Enum ORACLE_LINUX for value: Oracle Linux
            /// </summary>
            public static readonly PlatformEnum ORACLE_LINUX = new PlatformEnum("Oracle Linux");

            /// <summary>
            /// Enum FEDORA for value: Fedora
            /// </summary>
            public static readonly PlatformEnum FEDORA = new PlatformEnum("Fedora");

            /// <summary>
            /// Enum OTHER for value: Other
            /// </summary>
            public static readonly PlatformEnum OTHER = new PlatformEnum("Other");

            /// <summary>
            /// Enum COREOS for value: CoreOS
            /// </summary>
            public static readonly PlatformEnum COREOS = new PlatformEnum("CoreOS");

            /// <summary>
            /// Enum EULEROS for value: EulerOS
            /// </summary>
            public static readonly PlatformEnum EULEROS = new PlatformEnum("EulerOS");

            private static readonly Dictionary<string, PlatformEnum> StaticFields =
            new Dictionary<string, PlatformEnum>()
            {
                { "Windows", WINDOWS },
                { "Ubuntu", UBUNTU },
                { "RedHat", REDHAT },
                { "SUSE", SUSE },
                { "CentOS", CENTOS },
                { "Debian", DEBIAN },
                { "OpenSUSE", OPENSUSE },
                { "Oracle Linux", ORACLE_LINUX },
                { "Fedora", FEDORA },
                { "Other", OTHER },
                { "CoreOS", COREOS },
                { "EulerOS", EULEROS },
            };

            private string _value;

            public PlatformEnum()
            {

            }

            public PlatformEnum(string value)
            {
                _value = value;
            }

            public static PlatformEnum FromValue(string value)
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

                if (this.Equals(obj as PlatformEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlatformEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlatformEnum a, PlatformEnum b)
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

            public static bool operator !=(PlatformEnum a, PlatformEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum QUEUED for value: queued
            /// </summary>
            public static readonly StatusEnum QUEUED = new StatusEnum("queued");

            /// <summary>
            /// Enum SAVING for value: saving
            /// </summary>
            public static readonly StatusEnum SAVING = new StatusEnum("saving");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("deleted");

            /// <summary>
            /// Enum KILLED for value: killed
            /// </summary>
            public static readonly StatusEnum KILLED = new StatusEnum("killed");

            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("active");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "queued", QUEUED },
                { "saving", SAVING },
                { "deleted", DELETED },
                { "killed", KILLED },
                { "active", ACTIVE },
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

        [JsonConverter(typeof(EnumClassConverter<VirtualEnvTypeEnum>))]
        public class VirtualEnvTypeEnum
        {
            /// <summary>
            /// Enum FUSIONCOMPUTE for value: FusionCompute
            /// </summary>
            public static readonly VirtualEnvTypeEnum FUSIONCOMPUTE = new VirtualEnvTypeEnum("FusionCompute");

            /// <summary>
            /// Enum IRONIC for value: Ironic
            /// </summary>
            public static readonly VirtualEnvTypeEnum IRONIC = new VirtualEnvTypeEnum("Ironic");

            /// <summary>
            /// Enum DATAIMAGE for value: DataImage
            /// </summary>
            public static readonly VirtualEnvTypeEnum DATAIMAGE = new VirtualEnvTypeEnum("DataImage");

            private static readonly Dictionary<string, VirtualEnvTypeEnum> StaticFields =
            new Dictionary<string, VirtualEnvTypeEnum>()
            {
                { "FusionCompute", FUSIONCOMPUTE },
                { "Ironic", IRONIC },
                { "DataImage", DATAIMAGE },
            };

            private string _value;

            public VirtualEnvTypeEnum()
            {

            }

            public VirtualEnvTypeEnum(string value)
            {
                _value = value;
            }

            public static VirtualEnvTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VirtualEnvTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VirtualEnvTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
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

            public static bool operator !=(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<VisibilityEnum>))]
        public class VisibilityEnum
        {
            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly VisibilityEnum PRIVATE = new VisibilityEnum("private");

            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly VisibilityEnum PUBLIC = new VisibilityEnum("public");

            private static readonly Dictionary<string, VisibilityEnum> StaticFields =
            new Dictionary<string, VisibilityEnum>()
            {
                { "private", PRIVATE },
                { "public", PUBLIC },
            };

            private string _value;

            public VisibilityEnum()
            {

            }

            public VisibilityEnum(string value)
            {
                _value = value;
            }

            public static VisibilityEnum FromValue(string value)
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

                if (this.Equals(obj as VisibilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VisibilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VisibilityEnum a, VisibilityEnum b)
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

            public static bool operator !=(VisibilityEnum a, VisibilityEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<SupportFcInjectEnum>))]
        public class SupportFcInjectEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly SupportFcInjectEnum TRUE = new SupportFcInjectEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly SupportFcInjectEnum FALSE = new SupportFcInjectEnum("false");

            private static readonly Dictionary<string, SupportFcInjectEnum> StaticFields =
            new Dictionary<string, SupportFcInjectEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public SupportFcInjectEnum()
            {

            }

            public SupportFcInjectEnum(string value)
            {
                _value = value;
            }

            public static SupportFcInjectEnum FromValue(string value)
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

                if (this.Equals(obj as SupportFcInjectEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportFcInjectEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportFcInjectEnum a, SupportFcInjectEnum b)
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

            public static bool operator !=(SupportFcInjectEnum a, SupportFcInjectEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<HwFirmwareTypeEnum>))]
        public class HwFirmwareTypeEnum
        {
            /// <summary>
            /// Enum BIOS for value: bios
            /// </summary>
            public static readonly HwFirmwareTypeEnum BIOS = new HwFirmwareTypeEnum("bios");

            /// <summary>
            /// Enum UEFI for value: uefi
            /// </summary>
            public static readonly HwFirmwareTypeEnum UEFI = new HwFirmwareTypeEnum("uefi");

            private static readonly Dictionary<string, HwFirmwareTypeEnum> StaticFields =
            new Dictionary<string, HwFirmwareTypeEnum>()
            {
                { "bios", BIOS },
                { "uefi", UEFI },
            };

            private string _value;

            public HwFirmwareTypeEnum()
            {

            }

            public HwFirmwareTypeEnum(string value)
            {
                _value = value;
            }

            public static HwFirmwareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as HwFirmwareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HwFirmwareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HwFirmwareTypeEnum a, HwFirmwareTypeEnum b)
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

            public static bool operator !=(HwFirmwareTypeEnum a, HwFirmwareTypeEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<SupportArmEnum>))]
        public class SupportArmEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly SupportArmEnum TRUE = new SupportArmEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly SupportArmEnum FALSE = new SupportArmEnum("false");

            private static readonly Dictionary<string, SupportArmEnum> StaticFields =
            new Dictionary<string, SupportArmEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public SupportArmEnum()
            {

            }

            public SupportArmEnum(string value)
            {
                _value = value;
            }

            public static SupportArmEnum FromValue(string value)
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

                if (this.Equals(obj as SupportArmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportArmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportArmEnum a, SupportArmEnum b)
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

            public static bool operator !=(SupportArmEnum a, SupportArmEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("__backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        [JsonProperty("__data_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string DataOrigin { get; set; }

        [JsonProperty("__description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("__image_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSize { get; set; }

        [JsonProperty("__image_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageSourceTypeEnum ImageSourceType { get; set; }
        [JsonProperty("__imagetype", NullValueHandling = NullValueHandling.Ignore)]
        public ImagetypeEnum Imagetype { get; set; }
        [JsonProperty("__isregistered", NullValueHandling = NullValueHandling.Ignore)]
        public IsregisteredEnum Isregistered { get; set; }
        [JsonProperty("__originalimagename", NullValueHandling = NullValueHandling.Ignore)]
        public string Originalimagename { get; set; }

        [JsonProperty("__os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public OsBitEnum OsBit { get; set; }
        [JsonProperty("__os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        [JsonProperty("__os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        [JsonProperty("__platform", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformEnum Platform { get; set; }
        [JsonProperty("__productcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Productcode { get; set; }

        [JsonProperty("__support_diskintensive", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportDiskintensive { get; set; }

        [JsonProperty("__support_highperformance", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportHighperformance { get; set; }

        [JsonProperty("__support_kvm", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvm { get; set; }

        [JsonProperty("__support_kvm_gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvmGpuType { get; set; }

        [JsonProperty("__support_kvm_infiniband", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvmInfiniband { get; set; }

        [JsonProperty("__support_largememory", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportLargememory { get; set; }

        [JsonProperty("__support_xen", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXen { get; set; }

        [JsonProperty("__support_xen_gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXenGpuType { get; set; }

        [JsonProperty("__support_xen_hana", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXenHana { get; set; }

        [JsonProperty("__system_support_market", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemSupportMarket { get; set; }

        [JsonProperty("checksum", NullValueHandling = NullValueHandling.Ignore)]
        public string Checksum { get; set; }

        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerFormat { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskFormat { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        [JsonProperty("virtual_env_type", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualEnvTypeEnum VirtualEnvType { get; set; }
        [JsonProperty("virtual_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualSize { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityEnum Visibility { get; set; }
        [JsonProperty("__support_fc_inject", NullValueHandling = NullValueHandling.Ignore)]
        public SupportFcInjectEnum SupportFcInject { get; set; }
        [JsonProperty("hw_firmware_type", NullValueHandling = NullValueHandling.Ignore)]
        public HwFirmwareTypeEnum HwFirmwareType { get; set; }
        [JsonProperty("__support_arm", NullValueHandling = NullValueHandling.Ignore)]
        public SupportArmEnum SupportArm { get; set; }
        [JsonProperty("max_ram", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRam { get; set; }

        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }

        [JsonProperty("__os_feature_list", NullValueHandling = NullValueHandling.Ignore)]
        public string OsFeatureList { get; set; }

        [JsonProperty("__account_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountCode { get; set; }

        [JsonProperty("hw_vif_multiqueue_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string HwVifMultiqueueEnabled { get; set; }

        [JsonProperty("__is_offshelved", NullValueHandling = NullValueHandling.Ignore)]
        public string IsOffshelved { get; set; }

        [JsonProperty("__lazyloading", NullValueHandling = NullValueHandling.Ignore)]
        public string Lazyloading { get; set; }

        [JsonProperty("__root_origin", NullValueHandling = NullValueHandling.Ignore)]
        public string RootOrigin { get; set; }

        [JsonProperty("__sequence_num", NullValueHandling = NullValueHandling.Ignore)]
        public string SequenceNum { get; set; }

        [JsonProperty("active_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveAt { get; set; }

        [JsonProperty("__support_agent_list", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportAgentList { get; set; }

        [JsonProperty("__support_amd", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportAmd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageInfo {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  dataOrigin: ").Append(DataOrigin).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  imageSize: ").Append(ImageSize).Append("\n");
            sb.Append("  imageSourceType: ").Append(ImageSourceType).Append("\n");
            sb.Append("  imagetype: ").Append(Imagetype).Append("\n");
            sb.Append("  isregistered: ").Append(Isregistered).Append("\n");
            sb.Append("  originalimagename: ").Append(Originalimagename).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  productcode: ").Append(Productcode).Append("\n");
            sb.Append("  supportDiskintensive: ").Append(SupportDiskintensive).Append("\n");
            sb.Append("  supportHighperformance: ").Append(SupportHighperformance).Append("\n");
            sb.Append("  supportKvm: ").Append(SupportKvm).Append("\n");
            sb.Append("  supportKvmGpuType: ").Append(SupportKvmGpuType).Append("\n");
            sb.Append("  supportKvmInfiniband: ").Append(SupportKvmInfiniband).Append("\n");
            sb.Append("  supportLargememory: ").Append(SupportLargememory).Append("\n");
            sb.Append("  supportXen: ").Append(SupportXen).Append("\n");
            sb.Append("  supportXenGpuType: ").Append(SupportXenGpuType).Append("\n");
            sb.Append("  supportXenHana: ").Append(SupportXenHana).Append("\n");
            sb.Append("  systemSupportMarket: ").Append(SystemSupportMarket).Append("\n");
            sb.Append("  checksum: ").Append(Checksum).Append("\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  virtualEnvType: ").Append(VirtualEnvType).Append("\n");
            sb.Append("  virtualSize: ").Append(VirtualSize).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  supportFcInject: ").Append(SupportFcInject).Append("\n");
            sb.Append("  hwFirmwareType: ").Append(HwFirmwareType).Append("\n");
            sb.Append("  supportArm: ").Append(SupportArm).Append("\n");
            sb.Append("  maxRam: ").Append(MaxRam).Append("\n");
            sb.Append("  systemCmkid: ").Append(SystemCmkid).Append("\n");
            sb.Append("  osFeatureList: ").Append(OsFeatureList).Append("\n");
            sb.Append("  accountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  hwVifMultiqueueEnabled: ").Append(HwVifMultiqueueEnabled).Append("\n");
            sb.Append("  isOffshelved: ").Append(IsOffshelved).Append("\n");
            sb.Append("  lazyloading: ").Append(Lazyloading).Append("\n");
            sb.Append("  rootOrigin: ").Append(RootOrigin).Append("\n");
            sb.Append("  sequenceNum: ").Append(SequenceNum).Append("\n");
            sb.Append("  activeAt: ").Append(ActiveAt).Append("\n");
            sb.Append("  supportAgentList: ").Append(SupportAgentList).Append("\n");
            sb.Append("  supportAmd: ").Append(SupportAmd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.DataOrigin == input.DataOrigin ||
                    (this.DataOrigin != null &&
                    this.DataOrigin.Equals(input.DataOrigin))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageSize == input.ImageSize ||
                    (this.ImageSize != null &&
                    this.ImageSize.Equals(input.ImageSize))
                ) && 
                (
                    this.ImageSourceType == input.ImageSourceType ||
                    (this.ImageSourceType != null &&
                    this.ImageSourceType.Equals(input.ImageSourceType))
                ) && 
                (
                    this.Imagetype == input.Imagetype ||
                    (this.Imagetype != null &&
                    this.Imagetype.Equals(input.Imagetype))
                ) && 
                (
                    this.Isregistered == input.Isregistered ||
                    (this.Isregistered != null &&
                    this.Isregistered.Equals(input.Isregistered))
                ) && 
                (
                    this.Originalimagename == input.Originalimagename ||
                    (this.Originalimagename != null &&
                    this.Originalimagename.Equals(input.Originalimagename))
                ) && 
                (
                    this.OsBit == input.OsBit ||
                    (this.OsBit != null &&
                    this.OsBit.Equals(input.OsBit))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Productcode == input.Productcode ||
                    (this.Productcode != null &&
                    this.Productcode.Equals(input.Productcode))
                ) && 
                (
                    this.SupportDiskintensive == input.SupportDiskintensive ||
                    (this.SupportDiskintensive != null &&
                    this.SupportDiskintensive.Equals(input.SupportDiskintensive))
                ) && 
                (
                    this.SupportHighperformance == input.SupportHighperformance ||
                    (this.SupportHighperformance != null &&
                    this.SupportHighperformance.Equals(input.SupportHighperformance))
                ) && 
                (
                    this.SupportKvm == input.SupportKvm ||
                    (this.SupportKvm != null &&
                    this.SupportKvm.Equals(input.SupportKvm))
                ) && 
                (
                    this.SupportKvmGpuType == input.SupportKvmGpuType ||
                    (this.SupportKvmGpuType != null &&
                    this.SupportKvmGpuType.Equals(input.SupportKvmGpuType))
                ) && 
                (
                    this.SupportKvmInfiniband == input.SupportKvmInfiniband ||
                    (this.SupportKvmInfiniband != null &&
                    this.SupportKvmInfiniband.Equals(input.SupportKvmInfiniband))
                ) && 
                (
                    this.SupportLargememory == input.SupportLargememory ||
                    (this.SupportLargememory != null &&
                    this.SupportLargememory.Equals(input.SupportLargememory))
                ) && 
                (
                    this.SupportXen == input.SupportXen ||
                    (this.SupportXen != null &&
                    this.SupportXen.Equals(input.SupportXen))
                ) && 
                (
                    this.SupportXenGpuType == input.SupportXenGpuType ||
                    (this.SupportXenGpuType != null &&
                    this.SupportXenGpuType.Equals(input.SupportXenGpuType))
                ) && 
                (
                    this.SupportXenHana == input.SupportXenHana ||
                    (this.SupportXenHana != null &&
                    this.SupportXenHana.Equals(input.SupportXenHana))
                ) && 
                (
                    this.SystemSupportMarket == input.SystemSupportMarket ||
                    (this.SystemSupportMarket != null &&
                    this.SystemSupportMarket.Equals(input.SystemSupportMarket))
                ) && 
                (
                    this.Checksum == input.Checksum ||
                    (this.Checksum != null &&
                    this.Checksum.Equals(input.Checksum))
                ) && 
                (
                    this.ContainerFormat == input.ContainerFormat ||
                    (this.ContainerFormat != null &&
                    this.ContainerFormat.Equals(input.ContainerFormat))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DiskFormat == input.DiskFormat ||
                    (this.DiskFormat != null &&
                    this.DiskFormat.Equals(input.DiskFormat))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Protected == input.Protected ||
                    (this.Protected != null &&
                    this.Protected.Equals(input.Protected))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VirtualEnvType == input.VirtualEnvType ||
                    (this.VirtualEnvType != null &&
                    this.VirtualEnvType.Equals(input.VirtualEnvType))
                ) && 
                (
                    this.VirtualSize == input.VirtualSize ||
                    (this.VirtualSize != null &&
                    this.VirtualSize.Equals(input.VirtualSize))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.SupportFcInject == input.SupportFcInject ||
                    (this.SupportFcInject != null &&
                    this.SupportFcInject.Equals(input.SupportFcInject))
                ) && 
                (
                    this.HwFirmwareType == input.HwFirmwareType ||
                    (this.HwFirmwareType != null &&
                    this.HwFirmwareType.Equals(input.HwFirmwareType))
                ) && 
                (
                    this.SupportArm == input.SupportArm ||
                    (this.SupportArm != null &&
                    this.SupportArm.Equals(input.SupportArm))
                ) && 
                (
                    this.MaxRam == input.MaxRam ||
                    (this.MaxRam != null &&
                    this.MaxRam.Equals(input.MaxRam))
                ) && 
                (
                    this.SystemCmkid == input.SystemCmkid ||
                    (this.SystemCmkid != null &&
                    this.SystemCmkid.Equals(input.SystemCmkid))
                ) && 
                (
                    this.OsFeatureList == input.OsFeatureList ||
                    (this.OsFeatureList != null &&
                    this.OsFeatureList.Equals(input.OsFeatureList))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.HwVifMultiqueueEnabled == input.HwVifMultiqueueEnabled ||
                    (this.HwVifMultiqueueEnabled != null &&
                    this.HwVifMultiqueueEnabled.Equals(input.HwVifMultiqueueEnabled))
                ) && 
                (
                    this.IsOffshelved == input.IsOffshelved ||
                    (this.IsOffshelved != null &&
                    this.IsOffshelved.Equals(input.IsOffshelved))
                ) && 
                (
                    this.Lazyloading == input.Lazyloading ||
                    (this.Lazyloading != null &&
                    this.Lazyloading.Equals(input.Lazyloading))
                ) && 
                (
                    this.RootOrigin == input.RootOrigin ||
                    (this.RootOrigin != null &&
                    this.RootOrigin.Equals(input.RootOrigin))
                ) && 
                (
                    this.SequenceNum == input.SequenceNum ||
                    (this.SequenceNum != null &&
                    this.SequenceNum.Equals(input.SequenceNum))
                ) && 
                (
                    this.ActiveAt == input.ActiveAt ||
                    (this.ActiveAt != null &&
                    this.ActiveAt.Equals(input.ActiveAt))
                ) && 
                (
                    this.SupportAgentList == input.SupportAgentList ||
                    (this.SupportAgentList != null &&
                    this.SupportAgentList.Equals(input.SupportAgentList))
                ) && 
                (
                    this.SupportAmd == input.SupportAmd ||
                    (this.SupportAmd != null &&
                    this.SupportAmd.Equals(input.SupportAmd))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.DataOrigin != null)
                    hashCode = hashCode * 59 + this.DataOrigin.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImageSize != null)
                    hashCode = hashCode * 59 + this.ImageSize.GetHashCode();
                if (this.ImageSourceType != null)
                    hashCode = hashCode * 59 + this.ImageSourceType.GetHashCode();
                if (this.Imagetype != null)
                    hashCode = hashCode * 59 + this.Imagetype.GetHashCode();
                if (this.Isregistered != null)
                    hashCode = hashCode * 59 + this.Isregistered.GetHashCode();
                if (this.Originalimagename != null)
                    hashCode = hashCode * 59 + this.Originalimagename.GetHashCode();
                if (this.OsBit != null)
                    hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Productcode != null)
                    hashCode = hashCode * 59 + this.Productcode.GetHashCode();
                if (this.SupportDiskintensive != null)
                    hashCode = hashCode * 59 + this.SupportDiskintensive.GetHashCode();
                if (this.SupportHighperformance != null)
                    hashCode = hashCode * 59 + this.SupportHighperformance.GetHashCode();
                if (this.SupportKvm != null)
                    hashCode = hashCode * 59 + this.SupportKvm.GetHashCode();
                if (this.SupportKvmGpuType != null)
                    hashCode = hashCode * 59 + this.SupportKvmGpuType.GetHashCode();
                if (this.SupportKvmInfiniband != null)
                    hashCode = hashCode * 59 + this.SupportKvmInfiniband.GetHashCode();
                if (this.SupportLargememory != null)
                    hashCode = hashCode * 59 + this.SupportLargememory.GetHashCode();
                if (this.SupportXen != null)
                    hashCode = hashCode * 59 + this.SupportXen.GetHashCode();
                if (this.SupportXenGpuType != null)
                    hashCode = hashCode * 59 + this.SupportXenGpuType.GetHashCode();
                if (this.SupportXenHana != null)
                    hashCode = hashCode * 59 + this.SupportXenHana.GetHashCode();
                if (this.SystemSupportMarket != null)
                    hashCode = hashCode * 59 + this.SystemSupportMarket.GetHashCode();
                if (this.Checksum != null)
                    hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Protected != null)
                    hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VirtualEnvType != null)
                    hashCode = hashCode * 59 + this.VirtualEnvType.GetHashCode();
                if (this.VirtualSize != null)
                    hashCode = hashCode * 59 + this.VirtualSize.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.SupportFcInject != null)
                    hashCode = hashCode * 59 + this.SupportFcInject.GetHashCode();
                if (this.HwFirmwareType != null)
                    hashCode = hashCode * 59 + this.HwFirmwareType.GetHashCode();
                if (this.SupportArm != null)
                    hashCode = hashCode * 59 + this.SupportArm.GetHashCode();
                if (this.MaxRam != null)
                    hashCode = hashCode * 59 + this.MaxRam.GetHashCode();
                if (this.SystemCmkid != null)
                    hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                if (this.OsFeatureList != null)
                    hashCode = hashCode * 59 + this.OsFeatureList.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.HwVifMultiqueueEnabled != null)
                    hashCode = hashCode * 59 + this.HwVifMultiqueueEnabled.GetHashCode();
                if (this.IsOffshelved != null)
                    hashCode = hashCode * 59 + this.IsOffshelved.GetHashCode();
                if (this.Lazyloading != null)
                    hashCode = hashCode * 59 + this.Lazyloading.GetHashCode();
                if (this.RootOrigin != null)
                    hashCode = hashCode * 59 + this.RootOrigin.GetHashCode();
                if (this.SequenceNum != null)
                    hashCode = hashCode * 59 + this.SequenceNum.GetHashCode();
                if (this.ActiveAt != null)
                    hashCode = hashCode * 59 + this.ActiveAt.GetHashCode();
                if (this.SupportAgentList != null)
                    hashCode = hashCode * 59 + this.SupportAgentList.GetHashCode();
                if (this.SupportAmd != null)
                    hashCode = hashCode * 59 + this.SupportAmd.GetHashCode();
                return hashCode;
            }
        }
    }
}
