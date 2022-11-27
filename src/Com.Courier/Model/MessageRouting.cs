using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "MessageRouting")]
    public partial class MessageRouting : IEquatable<MessageRouting>, IValidatableObject
    {
        [JsonConstructor]
        protected MessageRouting() { }

        public MessageRouting(string method, object channels)
        {
            this.Method = method ?? throw new ArgumentNullException("method is a required property for MessageRouting and cannot be null");
            this.Channels = channels ?? throw new ArgumentNullException("channels is a required property for MessageRouting and cannot be null");
        }

        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public object Channels { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageRouting {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            // can add more stuff later
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as MessageRouting);
        }

        public bool Equals(MessageRouting input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) &&
                (
                    this.Channels == input.Channels ||
                    this.Channels.Equals(input.Channels)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
