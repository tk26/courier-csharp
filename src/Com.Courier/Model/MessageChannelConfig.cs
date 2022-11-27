using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Com.Courier.Model
{
    [DataContract(Name = "MessageChannelConfig")]
    public partial class MessageChannelConfig : IEquatable<MessageChannelConfig>, IValidatableObject
    {
        public MessageChannelConfig()
        {
        }

        [DataMember(Name = "brand_id", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        [DataMember(Name = "providers", EmitDefaultValue = false)]
        public object Providers { get; set; }

        [DataMember(Name = "routing_method", EmitDefaultValue = false)]
        public string RoutingMethod { get; set; }

        [DataMember(Name = "if", EmitDefaultValue = false)]
        public string If { get; set; }

        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public object Timeout { get; set; }

        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public object Metadata { get; set; }

        [DataMember(Name = "override", EmitDefaultValue = false)]
        public object Override { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageChannelConfig {\n");
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
            return this.Equals(input as MessageChannelConfig);
        }

        public bool Equals(MessageChannelConfig input)
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
