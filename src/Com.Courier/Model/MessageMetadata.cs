using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "MessageMetadata")]
    public partial class MessageMetadata : IEquatable<MessageMetadata>, IValidatableObject
    {
        public MessageMetadata()
        {
        }

        [DataMember(Name = "event", EmitDefaultValue = false)]
        public string Event { get; set; }

        [DataMember(Name = "trace_id", EmitDefaultValue = false)]
        public string TraceId { get; set; }

        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public object Tags { get; set; }

        [DataMember(Name = "utm", EmitDefaultValue = false)]
        public UTM Utm { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMetadata {\n");
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
            return this.Equals(input as MessageMetadata);
        }

        public bool Equals(MessageMetadata input)
        {
            if (input == null)
                return false;

            return true;
            // can add more stuff later
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                // can add more stuff later
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
